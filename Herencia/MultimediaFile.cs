using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class MultimediaFile: System.Object
    {
        //public string fechaCreacion;
        //public string fechaModificacion;
        //string nombre;
        //string tipoElemento;

        //// REGLAS A TENER EN CUENTA CON VIRTUAL Y OVERRIDE

        //// 1. Un metodo declarado como virtual no puede ser privado
        //// 2. La sobreescritura "override" de este virtual (recordamos que hacemos el metodo virtual para poder sobreescribirlos en las
        //// clases hijas) debera devolver los mismos valores que la clase de donde procede
        //// 3. No se puede hacer override sin que el metodo padre sea virtual
        //// 4. Un metodo override se convierte automaticamente en virtual
        //public virtual void DesplegarInformacion()
        //{
        //    string informacion = fechaCreacion + " " + fechaModificacion + " " + nombre + " " + tipoElemento;
        //    Console.WriteLine(informacion);

        //}

        ////public MultimediaFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
        ////{
        ////    fechaCreacion = _fechaCreacion;
        ////    fechaModificacion = _fechaModificacion;
        ////    nombre = _nombre;
        ////    tipoElemento = _tipoElemento;

        ////}

        //// Override para sobreescribir el metodo ToString()
        //public override string ToString()

        //{

        //    return "ToString sobreescrito";

        //}


        public virtual string ObtenerTipo()
        {

            return "Archivo Multimedia";
        }
    }

  

  
}
