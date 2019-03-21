using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
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
            
            public void MostrarContacto(Contacto c)
            {
                Console.WriteLine("_________________________________________");
                Console.WriteLine("-> Nombre: " + nombre);
                Console.WriteLine("-> DUI: " + DUI);
                Console.WriteLine("-> Dirección: " + Direccion);
                Console.WriteLine("-> Teléfono: " + telefono);
                Console.WriteLine("-> Email: " + email);
                Console.WriteLine("-> Profesion u oficio: " + profesion);
                Console.WriteLine("_________________________________________");
            }
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            int cantidad = 0;
            String query;
            Console.Title = "A G E N D A";
            Console.WriteLine("     ___________    AGENDA    __________");
            Console.WriteLine("");
            Console.Write("Antes de iniciar ¿Cuántos contactos tendrá su agenda? :");
            cantidad = int.Parse(Console.ReadLine());
            Contacto[] contacto = new Contacto[cantidad];
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
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("_____ INGRESAR CONTACTOS  ____");
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Contacto " + (i + 1));
                            Console.Write("Nombre: ");
                            contacto[i].nombre = Console.ReadLine();
                            Console.Write("DUI: ");
                            contacto[i].DUI = Console.ReadLine();
                            Console.Write("Dirección: ");
                            contacto[i].Direccion= Console.ReadLine();
                            Console.Write("Teléfono: ");
                            contacto[i].telefono = Console.ReadLine();
                            Console.Write("Email: ");
                            contacto[i].email = Console.ReadLine();
                            Console.Write("Profesión u oficio: ");
                            contacto[i].profesion = Console.ReadLine();
                            Console.WriteLine("___________________________________________________________________________");

                        }
                        break;
                    case 2:
                        for(int i = 0; i < cantidad; i++)
                        {
                            contacto[i].MostrarContacto(contacto[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("____ BÚSQUEDA DE CONTACTO ____");
                        Console.WriteLine("");
                        Console.Write("\t -> Ingrese la DUI del contacto: ");
                        query = Console.ReadLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (query == contacto[i].DUI)
                            {
                                contacto[i].MostrarContacto(contacto[i]);
                                Console.ReadKey();
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }
    }
}
