using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using EjercicioC_.Models;
using EjercicioC_.Models.ReceiptsDB;

namespace EjercicioC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CreatePersons createPersons = new CreatePersons();*/
            DateTime created = DateTime.Now;
            DateTime updated = new DateTime(2023, 1, 1, 10, 30, 0);
            /*Persons personas = new Persons("Hola", null, updated, created);*/
           /* createPersons.add(personas);*/

            CreateReceipts createReceipts = new CreateReceipts();
            receipts r = new receipts(updated,20,"50", null, created, updated);
            createReceipts.add(r);
           
           

            
           /* DeletePersona d = new DeletePersona();
            d.Delete(50);*/


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
