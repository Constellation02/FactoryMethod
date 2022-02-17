using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Cerveza : BebidaAlcholica
    {
        public override int NivelDeAlchol()
        {
            return 6; 
        }

    }
}
