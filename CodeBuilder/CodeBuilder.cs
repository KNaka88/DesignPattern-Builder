using System;

namespace CodeBuilder
{
    public class CodeBuilder
    {
        private readonly string ClassName;
        ClassElement root = new ClassElement();

        public CodeBuilder(string className)
        {
            ClassName = className;
            root.ClassName = className;
        }
        
        public CodeBuilder AddField(string field, string type)
        {
            var e = new ClassElement(field, type);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
}