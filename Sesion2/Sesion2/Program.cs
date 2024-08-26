using Sesion2.clases;

namespace Sesion2
{
    //Leer los datos de una persona y decir si es mayor o menor de edad.
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechaNac;
            Personas personas = new Personas();
            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("En que fecha naciste");
            fechaNac = DateTime.Parse(Console.ReadLine());

            personas.Nombre = nombre;
            personas.FechaNac = fechaNac;
            Console.WriteLine(personas.EvaluarEdad());    
        }
    }
}
