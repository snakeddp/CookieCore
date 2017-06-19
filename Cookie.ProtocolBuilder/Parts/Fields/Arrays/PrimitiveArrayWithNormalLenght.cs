using System.Text;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Fields.Arrays
{
    public class PrimitiveArrayWithNormalLenght
    {
        public bool Predicat(Field fi) => 
               fi.IsVector 
            && fi.Type.IsPrimitiveType()
            && !fi.WriteMethod.Contains("Var")
            && !fi.IsDynamicLength
            && !fi.UseTypeManager;

        public void OnMatch(StringBuilder writer, Field fi)
        {
            if(!string.IsNullOrEmpty(fi.WriteLengthMethod))
                writer.AppendLine($"        [LengthType(typeof({fi.WriteLengthMethod.GetLengthType()}))]");
            writer.AppendLine($"        public {fi.Type.TypeToCSharpFormat()}[] {fi.Name.Capitalize()} {{ get; set; }}");
        }
    }
}
