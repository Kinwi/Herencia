using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Herencia : A tener en cuenta

    // 1. No se puede heredar de 2 clases diferentes
    // 2. Los metodos de la clase padre se heredaran a todas las clases hijas
    // 3. Los atributos de la clase padre tambien se heredan pero han de ser publicos para ser compartidos
    // 3. Los metodos propios de cada clase hija son como su nombre dice , propios ; NO HEREDABLES
    // 4. Sabemos que una "struct" y una "class" son muy "parecidas". Muy bien pues uno de los grandes cambios
    //    es que las estructuras no pueden heredar .
    class Program
    {
        static void Main(string[] args)
        {

            //Modificadores de acceso

            // Public -- Acceso desde cualquier programa o clase
            // Private --- Acceso solo desde la misma clase
            // Protected --- Lo utilizamos para poder utilizar variables, campos y metodos entre clase padre y clase   hija. Asi solo se compartiran estos metodos entre estas clases
            



            // Polimorfismo - Como podemos ver ejecutamos siempre el mismo enunciado "multimedia.ObtenerTipo()"
            // pero con diferentes resultados. Por temas de sobreescrituta. Un enunciado definido puede llevar a cabo
            // diferentes acciones dependiendo del contexto



            MultimediaFile multimedia;
            DinamicFile dinamic = new DinamicFile();
            StaticFile statico = new StaticFile();
            OtherFile otherfile = new OtherFile();


            multimedia = dinamic;
            Console.WriteLine(multimedia.ObtenerTipo());

            multimedia = statico;
            Console.WriteLine(multimedia.ObtenerTipo());

            multimedia = otherfile;
            Console.WriteLine(multimedia.ObtenerTipo());

            Console.ReadLine();

            //MultimediaFile mfile = new MultimediaFile();

            //mFile.DesplegarInformacion();



          
            

            //DinamicFile dFile = new DinamicFile();

            //dFile.DesplegarInformacion();
            
            //StaticFile sFile = new StaticFile();

            
            //sFile.fechaCreacion = "15/03/1986";
            //sFile.Editar();

            //MultimediaFile mFile2 = dFile;

            //mFile.ToString();
            //dFile.DesplegarInformacion();
            //sFile.DesplegarInformacion();
            //Console.WriteLine(sFile);
            //Console.WriteLine(dFile);
            //Console.WriteLine(mFile);

            //Console.ReadLine();


        }
    }
}
