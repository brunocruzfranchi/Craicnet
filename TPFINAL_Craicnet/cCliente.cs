using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
   public class cCliente:cUsuario
    {
        public LinkedList<cPeliculas_Alquiladas> Peliculas_Alquiladas { get; set; }
        //constructor
    }
}
