using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class DataReferenceToken<TData> : ReferenceToken
    {
        /// <summary>
        /// Another entity referenced by this token.
        /// For some TokenTypes this field is mandatory, while for others, it is optional.
        /// </summary>
        public TData AdditionalData { get; set; }
    }
}
