using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesdeObjetos.Caso5
{
    internal class DatosdeContacto
    {
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public List<DatosdeContacto> contactos { get; set; }
        public List<Empleado> empleados { get; set; }   
    }
}
