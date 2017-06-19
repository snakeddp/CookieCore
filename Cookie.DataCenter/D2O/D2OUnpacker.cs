using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cookie.DataCenter.D2O.Files;
using Cookie.IO.Enums;
using Cookie.IO.Interfaces;
using Cookie.IO.Reader;
using Newtonsoft.Json;

namespace Cookie.DataCenter.D2O
{
    public class D2OUnpacker
    {
        private readonly IReader _reader;
        private readonly D2OJsonUnpacker _jsonUnpacker;
        private readonly Dictionary<int, int> _objectMapper;
        private readonly int _contentOffset;

        public string FileName { get; }
        public string FilePath { get; }
        public Dictionary<int, D2OClass> Objects { get; }

        public D2OUnpacker(string filePath)
        {
            FileName = Path.GetFileNameWithoutExtension(filePath);
            FilePath = filePath;

            var d2OFileBytes = File.ReadAllBytes(filePath);

            if(!d2OFileBytes.Any())
                throw new ArgumentNullException(nameof(d2OFileBytes));

            Console.WriteLine($"Reading {FileName}.d2o ...");

            _reader = new FastBinaryReader(d2OFileBytes);

            // Reading header to see if the file is valid
            if (_reader.ReadString(StringType.Utf8, 3) != "D2O")
            {
                _reader.Position = 0;

                var signature = _reader.ReadString(StringType.Utf8);

                if(signature != "AKSF")
                    throw new ArgumentException($"{FileName} is corrupted", nameof(d2OFileBytes));

                _reader.Position += 2;

                var len = _reader.ReadValue<int>();

                _reader.Position = _reader.Position + len;
                _contentOffset = _reader.Position + 7;

                var realHeader = _reader.ReadString(StringType.Utf8);

                if (realHeader != "D2O")
                    throw new ArgumentException($"{FileName} is corrupted", nameof(d2OFileBytes));
            }

            // Table pointer initializer
            var tablePointer = _reader.ReadValue<int>();

            _reader.Position = tablePointer + _contentOffset;

            var objectPointerTableLen = _reader.ReadValue<int>();

            _objectMapper = new Dictionary<int, int>(objectPointerTableLen);

            for (var i = 0; i < objectPointerTableLen; i += 8)
            {
                var key = _reader.ReadValue<int>();
                var pointer = _reader.ReadValue<int>();

                _objectMapper.Add(key, pointer + _contentOffset);
            }

            // D2O Files initializer
            var classCount = _reader.ReadValue<int>();

            Objects = new Dictionary<int, D2OClass>(classCount);
            for (var i = 0 ; i < classCount ; i++)
            {
                var classId = _reader.ReadValue<int>();

                var className = _reader.ReadString(StringType.Utf8);
                var packageName = _reader.ReadString(StringType.Utf8);

                var d2OClass = new D2OClass(className, packageName);

                var fieldsCount = _reader.ReadValue<int>();

                for(var j = 0 ; j < fieldsCount ; j++)
                {
                    d2OClass.AddField(_reader);
                    i++;
                }
                Objects.Add(classId, d2OClass);
            }

            _jsonUnpacker = new D2OJsonUnpacker(_reader, _objectMapper, Objects);
        }

        public T GetObjectById<T>(int objectId)
            => JsonConvert.DeserializeObject<T>(_jsonUnpacker.GetJsonObjectString(objectId));

        public T[] GetObjects<T>()
            => JsonConvert.DeserializeObject<T[]>(_jsonUnpacker.JsonFullString);

        public string GetObjectJsonStringById(int objectId)
            => _jsonUnpacker.GetJsonObjectString(objectId);

        public string GetObjectJsonFullString()
            => _jsonUnpacker.JsonFullString;
    }
}
