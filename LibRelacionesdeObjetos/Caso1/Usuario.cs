using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesdeObjetos.Tarea1
{
    internal class Usuario
    {
        public string nombre { get; set; }
        public string password { get; set; }

        List <Cliente> clientes { get; set; } 
    }
}
