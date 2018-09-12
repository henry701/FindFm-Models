using System;

namespace Models
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    public sealed class RootEntityAttribute : Attribute
    {
        public string Description { get; set; }
    }
}
