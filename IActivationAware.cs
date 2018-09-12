using System;

namespace Models
{
    public interface IActivationAware
    {
        DateTime? DeactivationDate { get; set; }
    }
}
