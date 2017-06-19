using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cookie.DataCenter.D2O.Enums;
using Cookie.DataCenter.D2O.Files;
using Cookie.IO.Enums;
using Cookie.IO.Interfaces;
using Newtonsoft.Json;

namespace Cookie.DataCenter.D2O
{
    public class D2OJsonUnpacker
    {
        private readonly IReader _reader;
        private readonly Dictionary<int, int> _objectMapper;
        private readonly Dictionary<int, D2OClass> _d2OClasses;

        public string JsonFullString { get; }

        public D2OJsonUnpacker(IReader reader, Dictionary<int, int> objectMapper, Dictionary<int, D2OClass> d2OClasses)
        {
            _reader = reader;
            _objectMapper = objectMapper;
            _d2OClasses = d2OClasses;

            var stringBuilder = new StringBuilder();

            stringBuilder.Append("[");
            var indexTableKeys = _objectMapper.Keys.ToArray();

            for (var i = 0; i < indexTableKeys.Length; i++)
            {
                stringBuilder.Append(GetJsonObjectString(indexTableKeys[i]))
                    .Append(WriteCommaIfHasMore(indexTableKeys.Length, i))
                    .AppendLine();
            }
            stringBuilder.Append("]");

            JsonFullString = stringBuilder.ToString();
        }

        public string GetJsonObjectString(int objectId)
        {
            var objectPointer = _objectMapper[objectId];
            _reader.Position = objectPointer;

            var objectClassId = _reader.ReadValue<int>();

            var objectBuilder = new StringBuilder();

            objectBuilder.Append(GetObjectBuilder(objectClassId));

            return objectBuilder.ToString();
        }

        private static string WriteCommaIfHasMore(int count, int i)
            => HasMoreElement(count, i) ? "," : string.Empty;

        private static bool HasMoreElement(int count, int i)
            => i != count - 1;


        private string GetObjectBuilder(int classId)
        {
            var classDefinition = _d2OClasses[classId];
            return GetPropertiesBuilder(classDefinition);
        }
        private string GetPropertiesBuilder(D2OClass d2Oclass)
        {
            var propertyBuilder = new StringBuilder();
            var numberOfFields = d2Oclass.Properties.Count;
            propertyBuilder.AppendLine("{");
            for (var i = 0; i < numberOfFields; i++)
            {
                propertyBuilder
                    .Append(GetPropertyBuilder(d2Oclass.Properties[i]))
                    .Append(WriteCommaIfHasMore(numberOfFields, i))
                    .AppendLine();
            }
            propertyBuilder.Append("}");

            return propertyBuilder.ToString();
        }
        private string GetPropertyBuilder(D2OProperty property)
        {
            var propertyBuilder = new StringBuilder();

            propertyBuilder
                .Append(JsonConvert.ToString(property.PropertyName))
                .Append(": ")
                .Append(GetFieldValueBuilder(property));

            return propertyBuilder.ToString();
        }
        private string GetFieldValueBuilder(D2OProperty property)
        {
            var propertyValueBuilder = new StringBuilder();

            switch (property.PropertyType)
            {
                case D2ODataType.Vector:
                    propertyValueBuilder.Append("[");
                    var vectorLength = _reader.ReadValue<int>();

                    for (var i = 0; i < vectorLength; i++)
                    {
                        propertyValueBuilder
                            .Append(GetFieldValueBuilder(property.InnerProperty))
                            .Append(WriteCommaIfHasMore(vectorLength, i));
                    }

                    propertyValueBuilder.Append("]");
                    break;
                case D2ODataType.Int:
                    propertyValueBuilder.Append(_reader.ReadValue<int>());
                    break;
                case D2ODataType.UInt:
                    propertyValueBuilder.Append(_reader.ReadValue<uint>());
                    break;
                case D2ODataType.I18N:
                    propertyValueBuilder.Append(_reader.ReadValue<int>());
                    break;
                case D2ODataType.String:
                    propertyValueBuilder.Append(JsonConvert.ToString(_reader.ReadString(StringType.Utf8)));
                    break;
                case D2ODataType.Bool:
                    propertyValueBuilder.Append(JsonConvert.ToString(_reader.ReadValue<bool>())); //in json bool is true/false not True/False
                    break;
                case D2ODataType.Double:
                    propertyValueBuilder.Append(JsonConvert.ToString(_reader.ReadValue<double>())); //handling the "," vs "." problem of the culture specifics
                    break;
                default:
                    if (property.PropertyType > 0) //if type is an object
                    {
                        var classId = _reader.ReadValue<int>();
                        if (_d2OClasses.ContainsKey(classId))
                            propertyValueBuilder.Append(GetObjectBuilder(classId));
                    }
                    else
                        throw new ArgumentException(nameof(property.PropertyType));
                    break;
            }
            return propertyValueBuilder.ToString();
        }
    }
}
