using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class PalaMecanica:Vehiculo
    {

        public int PML { get; set; }

        public PalaMecanica(int pML, int caballosFuerza ,string marca) : base(caballosFuerza, marca)
        {
            PML = pML;
        }
    }

    
}
