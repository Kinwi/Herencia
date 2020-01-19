using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class DinamicFile : MultimediaFile
    {
        //// VIRTUAL : Hace referencia a que el metodo podra ser sobreescrito posteriormente

        //string duracion;

        ////public DinamicFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento) : base(_fechaCreacion, _fechaModificacion, _nombre, _tipoElemento)
        ////{
        ////}

        //public virtual void Reproducir() 
        //{
        //    Console.WriteLine("Reproduciendo");

        //}

        //public virtual void Pausar()
        //{
        //    Console.WriteLine("Pausar");

        //}


        //public virtual void Detener() 
        //{
        //    Console.WriteLine("Detener");

        //}

        //// Para poder sobreescribir el metodo "DesplegarInformacion" de la clase padre "MultimediaFile" es necesario poner
        //// "virtual" en ese metodo
        //public override void DesplegarInformacion()
        //{
        //    Console.WriteLine("Soy un archivo dinamico");
        //    //base.DesplegarInformacion();
        //}

        public override string ObtenerTipo()
        {
            return "Archivo Dinamico";
        }
    }
}
