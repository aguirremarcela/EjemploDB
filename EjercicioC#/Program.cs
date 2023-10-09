using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using EjercicioC_.Models;

namespace EjercicioC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PersonsDB db = new PersonsDB();

            //Traer todas las Persons 

            /* var persons = db.getAll();
             foreach ( var p in persons ) {
                 Console.WriteLine("Id: "+ p.Id+ " Name: "+p.Name );
            }*/

            //Para agregar una Persons a la base de datos debemos pasarle
            // name, deleted, created  y updated

            /*DateTime created = DateTime.Now;
              DateTime updated = new DateTime(2023, 1, 1, 10, 30, 0);
              Persons personas = new Persons("Felipe",null,updated,created);
              db.Add(personas);*/

            //Modificar actualizar una persona 

            /*
             DateTime created = DateTime.Now;
              DateTime updated = new DateTime(2023, 1, 1, 10, 30, 35);
              Persons p1 = new Persons("Juan",null,updated,created);
              db.Update(p1, 1);
            */

            //Eliminar una persona, se debe pasar como parametro su id

            /*db.Delete(1);
             */
            



           
          

        }




    }
}
