using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaAlcholica nBebida = Creador.CreadorBebida(Creador.CERVEZA);
            Console.WriteLine(nBebida.NivelDeAlchol());
        }
    }
}
