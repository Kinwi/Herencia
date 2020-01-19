using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class Vehiculo
    {

        public int CaballosFuerza { get; set; }
        public string Marca { get; set; }

        public Vehiculo(int caballosFuerza)
        {
            CaballosFuerza = caballosFuerza;
        }

        public Vehiculo(int caballosFuerza, string marca) 
        {
            CaballosFuerza = caballosFuerza;
            Marca = marca;
        }

        public void Arrancar()
        {

            Console.WriteLine("El vehiculo ha arrancado");
        }

        public void Detener()
        {

            Console.WriteLine("El vehiculo se ha detenido");
        }
    }
}
