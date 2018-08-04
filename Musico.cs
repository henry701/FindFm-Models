using System;
using System.Collections.Generic;

namespace Models
{
    public class Musico : User
    {
        public override Type Kind { get { return typeof(Musico); } }

        public DateTime Nascimento { get; set; }
        public IList<Instrumento> Instrumentos { get; set; }
    }
}
