using Cookie.Core.Extensions;
using Cookie.DataCenter.D2O.Enums;
using Cookie.IO.Interfaces;

namespace Cookie.DataCenter.D2O.Files
{
    public class D2OProperty
    {
        public D2OProperty(IReader reader)
        {
            PropertyName = reader.ReadValue<string>().Capitalize();

            ReadType(reader);
        }

        public string PropertyName { get; }
        public D2ODataType PropertyType { get; set; }
        public D2OProperty InnerProperty { get; set; }

        public void ReadType(IReader reader)
        {
            var fieldType = (D2ODataType) reader.ReadValue<int>();

            if (fieldType == D2ODataType.Vector)
                InnerProperty = new D2OProperty(reader);

            PropertyType = fieldType;
        }
    }
}