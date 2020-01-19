using System;
using System.Collections.Generic;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(120, "Ferrari");
            Automovil a1 = new Automovil(120, 5, "Renault");
            PalaMecanica p1 = new PalaMecanica(30, 60, "Bosch");


            // La herencia nos permite acceder a los metodos de la clase padre
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Add(v1);
            vehiculos.Add(a1);
            vehiculos.Add(p1);

            a1.Acelerar(30);
        }
    }
}
