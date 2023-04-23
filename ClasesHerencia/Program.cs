using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "jPerez";
            estudiante.Password = "12323";
            estudiante.Nombre = "Cris";
            estudiante.Matricula = "3513asd";

            estudiante.login("jPerez", "12323");
            estudiante.login();

            //Listas en ves de Arrays em .Net C#
            /*List<Docente> listaDocente = new List<Docente>();
            listaDocente.Add(new Docente()
            {
                Cuenta = "Suman",
                Password = "3431",
                Nombre = "Saul",
                Sueldo = 2347,
            });

            listaDocente.Add(new Docente()
            {
                Cuenta = "Perez",
                Password = "2131",
                Nombre = "Carla",
                Sueldo = 123,
            });

            listaDocente.Add(new Docente()
            {
                Cuenta = "swiii",
                Password = "5121",
                Nombre = "Ana",
                Sueldo = 321,
            });*/

            List<Estudiante> listaestudiante = new List<Estudiante>();
            listaestudiante.Add(new Estudiante()
            {
                Cuenta = "Juanitope",
                Password = "9289",
                Nombre = "Juancho",
                Matricula = "2424fq",
                Edad = 16,
            });

            listaestudiante.Add(new Estudiante()
            {
                Cuenta = "sSamuelwi",
                Password = "63134",
                Nombre = "Galindo",
                Matricula = "dfi312",
                Edad = 21,
            });

            listaestudiante.Add(new Estudiante()
            {
                Cuenta = "Saraihpri",
                Password = "3515413",
                Nombre = "Sara",
                Matricula = "bs3212",
                Edad = 18,
            });

            listaestudiante.Add(new Estudiante()
            {
                Cuenta = "Andylk",
                Password = "253132",
                Nombre = "Andres",
                Matricula = "sfagb32",
                Edad = 20,
            });

            listaestudiante.Add(new Estudiante()
            {
                Cuenta = "Josialel",
                Password = "621323",
                Nombre = "Jpsias",
                Matricula = "da31ewd",
                Edad = 13,
            });

            MostrarLista(listaestudiante);
            Double edadProm1 = getedadProm1(listaestudiante);
            Console.WriteLine("\n----1Promedio de edad :{0}", edadProm1.ToString("##.##"));

            double edadProm2 = getedadProm2(listaestudiante);
            Console.WriteLine("\n----2Promedio de edad:{0}", edadProm2.ToString("##.##"));

            double edadProm3 = getedadProm3(listaestudiante);
            Console.WriteLine("\n----3Promedio de edad:{0}", edadProm3.ToString("##.##"));

            double edadProm4 = getedadProm4(listaestudiante);
            Console.WriteLine("\n----4Promedio de edad:{0}", edadProm4.ToString("##.##"));

            /*MostrarLista(listaDocente);

            Double promedio = getPromedio(listaDocente);
            Console.WriteLine("\n----Promedio:{0}", promedio.ToString("##.##"));

            double promedio2 = getPromedioDos(listaDocente);
            Console.WriteLine("\n----PromedioDos:{0}", promedio2.ToString("##.##"));

            double promedio3 = getPromedioTres(listaDocente);
            Console.WriteLine("\n----PromedioTres:{0}", promedio3.ToString("##.##"));

            double promedio4 = getPromediocCuatro(listaDocente);
            Console.WriteLine("\n----PromedioCuatro:{0}", promedio4.ToString("##.##"));*/

            Console.ReadKey();

        }

        private static double getedadProm4(List<Estudiante> listaestudiante)
        {
            //MEtodo LINQ
            var prom = (
                    from item in listaestudiante
                    where item.Edad>=20
                    select item.Edad).Average();
            return (double)prom;
        }

        private static double getedadProm3(List<Estudiante> listaestudiante)
        {
            //Metodo lambda
            decimal sum = listaestudiante.Sum(x => x.Edad);
            int total = listaestudiante.Count();
            return (double)(sum / total);
        }

        private static double getedadProm2(List<Estudiante> listaestudiante)
        {
            //Metodo lambda
            decimal promedio = listaestudiante.Average(x => x.Edad);
            return (double)promedio;
        }

        private static double getedadProm1(List<Estudiante> listaestudiante)
        {
            //metodo Foreach
            Decimal suma = 0;
            foreach (Estudiante item in listaestudiante)
            {
                suma += item.Edad;
            }
            return (double)(suma / listaestudiante.Count());
        }

        private static void MostrarLista(List<Estudiante> listaestudiante)
        {
            Console.WriteLine("\n------------LISTA DE ESTUDIANTES------------\n");
            foreach(Estudiante item in listaestudiante)
            {
                Console.WriteLine(item.ToString());
            }
        }


        /*
        private static double getPromediocCuatro(List<Docente> listaDocente)
        {
            //consultas LINQ
            var prom=(
                    from item in listaDocente
                    where item.Sueldo>200 
                    select item.Sueldo).Average();
            return (double)prom;
        }

        private static double getPromedioTres(List<Docente> listaDocente)
        {
            //Funciones lambda
            decimal sum = listaDocente.Sum(x => x.Sueldo);
            int total = listaDocente.Count();
            return (double)(sum / total); 
        }
        private static double getPromedioDos(List<Docente> listaDocente)
        {
            //Funciones lambda
            decimal promedio = listaDocente.Average(x => x.Sueldo);
            return (double)promedio;
        }
        private static double getPromedio(List<Docente> listaDocente)
        {
            Decimal suma = 0;
            foreach (Docente item in listaDocente)
            {
                suma += item.Sueldo;
            }
            return (double)(suma / listaDocente.Count());//CAST
        }

        private static void MostrarLista(List<Docente> listaDocente)
        {
            Console.WriteLine("\n------------LISTA DE DOCENTES------------\n");
            foreach(Docente item in listaDocente)
            {
                Console.WriteLine(item.ToString());
            }
        }*/
    }
}
