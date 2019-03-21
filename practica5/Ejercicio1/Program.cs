using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio1
{
    class Program
    {
        struct Contacto
        {
            public String nombre;
            public String DUI;
            public String Direccion;
            public String telefono;
            public String email;
            public String profesion;
        }
        static void Main(string[] args)
        {
            StreamWriter output;
            StreamReader input;
            int opcion = 0;
            String query;
            String inputline;
            Console.Title = "A G E N D A";
            Contacto contacto = new Contacto();
            do
            {
                Console.Clear();
                Console.WriteLine("     ___________    AGENDA    __________");
                Console.WriteLine("");
                Console.WriteLine("\tElija una opción");
                Console.WriteLine("");
                Console.WriteLine("\t 1. Ingresar Contactos");
                Console.WriteLine("\t 2. Mostrar Contactos");
                Console.WriteLine("\t 3. Buscar Contacto");
                Console.WriteLine("\t 4. Salir");
                Console.WriteLine("");
                Console.Write("Opcion:   ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (opcion)
                {
                    case 1:
                        output = new StreamWriter("contactos.txt",true);
                        Console.WriteLine("_____ INGRESAR CONTACTO  ____");
                        Console.WriteLine("");
                        Console.Write("DUI: ");
                        contacto.DUI = Console.ReadLine();
                        Console.Write("Nombre: ");
                        contacto.nombre = Console.ReadLine();
                        Console.Write("Dirección: ");
                        contacto.Direccion = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        contacto.telefono = Console.ReadLine();
                        Console.Write("Email: ");
                        contacto.email = Console.ReadLine();
                        Console.Write("Profesión u oficio: ");
                        contacto.profesion = Console.ReadLine();
                        Console.WriteLine("___________________________________________________________________________");
                        output.WriteLine("DUI: "+contacto.DUI);
                        output.WriteLine("Nombre: "+contacto.nombre);
                        output.WriteLine("Dirección: "+contacto.Direccion);
                        output.WriteLine("Teléfono: "+contacto.telefono);
                        output.WriteLine("Email: "+contacto.email);
                        output.WriteLine("Profesión u oficio: "+contacto.profesion);
                        output.WriteLine("___________________________________________________________________________");
                        output.Close();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("_____ MOSTRAR CONTACTOS  ____");
                        Console.WriteLine("");
                        input = new StreamReader("contactos.txt",true);
                        while ((inputline=input.ReadLine()) != null)
                        {
                            Console.WriteLine(inputline);
                        }
                        input.Close();
                        Console.ReadKey();
                        break;
                    case 3:
                        String found;
                        input = new StreamReader("contactos.txt", true);
                        Console.WriteLine("");
                        Console.WriteLine("____ BÚSQUEDA DE CONTACTO ____");
                        Console.WriteLine("");
                        Console.Write("\t -> Ingrese la DUI del contacto: ");
                        query = "DUI: "+Console.ReadLine();
                        while ((inputline = input.ReadLine()) != null)
                        {
                            if (query==inputline)
                            {
                                Console.WriteLine(inputline);
                                for (int i = 0; i < 5; i++)
                                {
                                    found = input.ReadLine();
                                    Console.WriteLine(found);
                                }
                            }
                        }
                        input.Close();
                        Console.ReadKey();
                        break;
                    case 4:
                        System.IO.File.WriteAllText("contactos.txt", String.Empty);
                        break;
                }
            } while (opcion != 4);
            System.IO.File.WriteAllText("contactos.txt", String.Empty);
        }
    }
}