using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // VIRTUAL : Hace referencia a que el metodo podra ser sobreescrito posteriormente

    class StaticFile:MultimediaFile
    {

        public override string ObtenerTipo()
        {
            return "Archivo Estatico";
        }
        ////public StaticFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento) : base(_fechaCreacion, _fechaModificacion, _nombre, _tipoElemento)
        ////{
        ////}

        //public virtual void Editar() 
        //{
        //    Console.WriteLine("Editando");

        //}

        //public override void DesplegarInformacion()
        //{
        //    Console.WriteLine("Soy un archivo estatico");
        //    //base.DesplegarInformacion();
        //}
    }
}
