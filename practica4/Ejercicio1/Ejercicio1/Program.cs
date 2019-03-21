using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        struct Alumno
        {
            public String carnet;
            public String nombre;
            public void Show(Alumno X)
            {
                Console.WriteLine("--> Nombre: " + X.nombre);
                Console.WriteLine("--> Carnet: " + X.carnet);
            }
        }
        static void Main(string[] args)
        {
            Alumno[] alumno = new Alumno[10];
            int op=0;
            int cantidad = 0;
            Console.Title="UTILIZANDO ESTRUCTURAS Y PROCEDIMIENTOS";
            do
            {
                Console.Clear();
                Console.WriteLine("               _____    MENÚ    ______");
                Console.WriteLine("\t1.  Ingresar registro");
                Console.WriteLine("\t2.  Mostrar registro");
                Console.WriteLine("\t3.  Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("_INGRESAR REGISTRO DE ALUMNO_");
                        Console.Write("Alumnos a registar: ");
                        cantidad = int.Parse(Console.ReadLine());
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("-- Alumno: " + (i + 1));
                            Console.Write("\tNombre: ");
                            alumno[i].nombre = Console.ReadLine();
                            Console.Write("\tCarnet:  ");
                            alumno[i].carnet = Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("_LISTA DE ALUMNOS REGISTRADOS_");
                        if (cantidad == 0)
                        {
                            Console.WriteLine(" NO HAY ALUMNOS REGISTRADOS!");
                        }
                        else
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("-- ALUMNO: " + (i + 1) + " --");
                                alumno[i].Show(alumno[i]);
                                Console.WriteLine("______________________________");
                            }
                            Console.ReadKey();
                        }
                        break;
                }
            } while (op != 3);
        }
    }
}
