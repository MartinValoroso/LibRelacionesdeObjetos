using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesdeObjetos.Caso_6
{
    internal class Clinica
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public List<Director> directores { get; set; }

    }
}
