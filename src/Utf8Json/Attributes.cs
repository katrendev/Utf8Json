using System;
using System.Collections.Generic;
using System.Text;

namespace Utf8Json
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class JsonFormatterAttribute : Attribute
    {
        public Type FormatterType { get; private set; }
        public object[] Arguments { get; private set; }

        public JsonFormatterAttribute(Type formatterType)
        {
            this.FormatterType = formatterType;
        }

        public JsonFormatterAttribute(Type formatterType, params object[] arguments)
        {
            this.FormatterType = formatterType;
            this.Arguments = arguments;
        }
    }

    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
    public class SerializationConstructorAttribute : Attribute
    {

    }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class JsonMemberNameAttribute : Attribute
    {
        public JsonMemberNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed partial class JsonMemberIgnoreAttribute : Attribute
    {
        public JsonMemberIgnoreAttribute() { }
    }
}
