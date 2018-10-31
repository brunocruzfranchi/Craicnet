using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
    public class cBalde
    {

        public LinkedList<cNodo> Lista { get; set; }
        public int Clave { get; set; }
        public static int CA { get; set; }
        public const int CMAX = 100; //getter??
               
        static cBalde()
        {
            CA = 0;
        }
        public cBalde()
        {
            this.Lista = new LinkedList<cNodo>();
            this.Clave = CA;
            CA++; //chequear con CMAX, rehash?
        }
        //metodos: agregar, eliminar, buscar
    }
}
