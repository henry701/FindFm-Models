using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IActivationAware
    {
        DateTime? DeactivationDate { get; set; }
    }
}
