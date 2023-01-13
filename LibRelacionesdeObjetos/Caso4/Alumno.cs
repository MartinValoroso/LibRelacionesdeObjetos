using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesdeObjetos.Caso4
{
    internal class Alumno : Docente
    {
        public Docente Docente { get; set; }
    }
}
