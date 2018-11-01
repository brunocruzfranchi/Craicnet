using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
    public class cBaldeExt
    {

        public LinkedList< KeyValuePair<int, cUsuario> > Lista { get; set; }
        public int Clave { get; set; }
        public static int CA { get; set; }
        public const int CMAX = 100; //getter??
               
        static cBaldeExt()
        {
            CA = 0;
        }
        public cBaldeExt()
        {
            this.Lista = new LinkedList<KeyValuePair<int, cUsuario>>();
            this.Clave = CA;
            CA++; //chequear con CMAX, rehash?
        }
        //metodos: agregar, eliminar, buscar
    }
}
