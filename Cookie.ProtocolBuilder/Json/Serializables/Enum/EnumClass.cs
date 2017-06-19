using System.Collections.Generic;

namespace Cookie.ProtocolBuilder.Json.Serializables.Enum
{
    public class EnumClass
    {
        public string Name { get; set; }

        public List<EnumValue> Values { get; set; }
    }
}
