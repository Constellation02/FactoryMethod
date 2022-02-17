using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Romo : BebidaAlcholica
    {
        public override int NivelDeAlchol()
        {
            return 15; 
        }
    }
}
