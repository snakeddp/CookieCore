using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cookie.IO.Enums;
using Cookie.IO.Interfaces;
using Cookie.IO.Reader;

namespace Cookie.DataCenter.D2I
{
    //TODO: FIX
    public class D2IUnpacker
    {
        private readonly IReader _reader;
        private readonly Dictionary<int, int> _indexes;

        public string FileName { get; }
        public string FilePath { get; }

        public D2IUnpacker(string filePath)
        {
            FileName = Path.GetFileNameWithoutExtension(filePath);
            FilePath = filePath;

            var d2OFileBytes = File.ReadAllBytes(filePath);

            if (!d2OFileBytes.Any())
                throw new ArgumentNullException(nameof(d2OFileBytes));

            Console.WriteLine($"Reading {FileName}.d2i ...");

            _reader = new FastBinaryReader(d2OFileBytes);

            if (_indexes == null)
                _indexes = new Dictionary<int, int>();
            var unDiacriticalIndex = new Dictionary<int, int>();
            var textIndexes = new Dictionary<string, int>();
            var textSortIndex = new Dictionary<int, int>();

            var position = _reader.ReadValue<int>();
            _reader.Position = position;

            var indexCount = _reader.ReadValue<int>();

            for (var index = 0; index < indexCount; index += 9)
            {
                var key = _reader.ReadValue<int>();
                var diacriticalText = _reader.ReadValue<bool>();
                var pointeur = _reader.ReadValue<int>();
                _indexes.Add(key, pointeur);

                if (diacriticalText)
                {
                    index += 4;
                    unDiacriticalIndex.Add(key, _reader.ReadValue<int>());
                }
                else
                    unDiacriticalIndex.Add(key, pointeur);
            }

            var textIndexesCount = _reader.ReadValue<int>();

            while (textIndexesCount > 0)
            {
                position = _reader.Position;
                textIndexes.Add(_reader.ReadString(StringType.Utf8), _reader.ReadValue<int>());
                textIndexesCount -= _reader.Position - position;
            }

            textIndexesCount = _reader.ReadValue<int>();

            var i = 0;

            while (textIndexesCount > 0)
            {
                position = _reader.Position;
                textSortIndex.Add(_reader.ReadValue<int>(), ++i);
                textIndexesCount -= _reader.Position - position;
            }
        }

        public string GetTextById(int id)
        {
            if (_indexes == null || !_indexes.ContainsKey(id))
                throw new ArgumentOutOfRangeException(nameof(id));

            _reader.Position = _indexes[id];

            return _reader.ReadString(StringType.Utf8);
        }
    }
}
