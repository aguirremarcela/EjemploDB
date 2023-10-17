using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public class Persons : Registros
    {
        public int Id { get; set; }
        //el nombre debe tener 10 caracteres (contnado los espacios en blanco ) para ingresar en la base de dato y
        //tambien nos deben permitir null 
        public String Name { get; set; }

        public Persons(String name, DateTime? deleted, DateTime created, DateTime update) : base(deleted, created, update)
        {
            this.Name = name;
        }
        public Persons(int id, DateTime? deleted, DateTime created, DateTime update) : base(deleted, created, update)
        {
            this.Id = id;
        }
    }
}
