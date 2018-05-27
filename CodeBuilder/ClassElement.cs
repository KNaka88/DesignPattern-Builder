using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBuilder
{
    public class ClassElement
    {
        public string ClassName;
        public string Field;
        public string Type;
        public List<ClassElement> Elements = new List<ClassElement>();  

        public ClassElement()
        {

        }

        public ClassElement(string field, string type)
        {
            Field = field ?? throw new ArgumentNullException(paramName: nameof(field));
            Type = type ?? throw new ArgumentNullException(paramName: nameof(type));
        }

        private string ToStringImpl()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"public class {ClassName}");
            sb.AppendLine("{");

            foreach (var e in Elements)
            {
                sb.AppendLine($"  public {e.Type} {e.Field};");
            }
            sb.AppendLine("}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl();
        }
    }
}