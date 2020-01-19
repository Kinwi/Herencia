using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class Automovil : Vehiculo
    {
        public int CantidadPuertas { get; set; }

        // Con base(caballosFuerza) se hace referencia a los atributos heredados de la clase padre.
        // Si hacemos click con el Ctrl pulsado en base nos llevara a la clase padre
        public Automovil(int cantidadPuertas,int caballosFuerza):base(caballosFuerza)
        {
            CantidadPuertas = cantidadPuertas;
        }

        public Automovil(int cantidadPuertas, int caballosFuerza,string marca) : base(caballosFuerza,marca)
        {
            CantidadPuertas = cantidadPuertas;
        }
        public void Acelerar(int cuanto)
        {
            Arrancar();
            Console.WriteLine($"Has acelerado {cuanto} km/h");
            Detener();
        }
    }
}
