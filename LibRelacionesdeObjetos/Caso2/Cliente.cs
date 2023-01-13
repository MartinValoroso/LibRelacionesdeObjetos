using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesdeObjetos.Caso2
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string id { get; set; }

        public List<Pedidos> Pedidos  { get; set; }
    }
}
