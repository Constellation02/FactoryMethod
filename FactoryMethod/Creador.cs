using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Creador
    {
        public const int CERVEZA = 1;
        public const int ROMO = 2; 

        public static BebidaAlcholica CreadorBebida(int Tipo)
        {
            switch(Tipo)
            {
                case CERVEZA:
                    return new Cerveza();
                case ROMO:
                    return new Romo();
                default: return null;
            }
        }

    }
}
