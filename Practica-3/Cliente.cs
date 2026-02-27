using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string apellido { get; set; }

        public string direccion { get; set; }

        public string sex { get; set; }

        public Cliente() { }

        public Cliente(int id, string nombre, string apellido, string email)
        { 
        this.Id = id;

            this.Nombre = nombre;
            this.apellido = apellido;
            this.direccion = email;
            this.sex = email;

        }


    }
}
