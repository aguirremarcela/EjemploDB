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
            /*CreatePersons createPersons = new CreatePersons();
            DateTime created = DateTime.Now;
            DateTime updated = new DateTime(2023, 1, 1, 10, 30, 0);
            Persons personas = new Persons("Juan O", null, updated, created);
            createPersons.Add(personas);*/

            
           /* DeletePersona d = new DeletePersona();
            d.Delete(2);*/


            //Traer todas las Persons 

            /*ReadPersons readPersons = new ReadPersons();
            var persons=readPersons.GetAll();
            
             foreach ( var p in persons ) {
                 Console.WriteLine("Id: "+ p.Id+ " Name: "+p.Name );
            }*/

            //Modificar una persona

            /*UpdatePersons updatePersons = new UpdatePersons();
            DateTime created = DateTime.Now;
            DateTime updated = new DateTime(2023, 1, 1, 10, 30, 35);
            Persons p1 = new Persons("Felipe", null, updated, created);
            updatePersons.Update(p1, 5);*/

        }
    }
}
