using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
    public class cBaldeExt
    {

        public LinkedList<KeyValuePair<int, cUsuario>> Lista { get; set; }
        public int Clave_Balde { get; set; }
        public static int CA_Baldes { get; set; }
        public const int CMAX = 10 ; //getter?? Cant max de elementos x balde
               
        static cBaldeExt()
        {
            CA_Baldes = 0;
        }
        public cBaldeExt()
        {
            this.Lista = new LinkedList<KeyValuePair<int, cUsuario>>();
            this.Clave_Balde = CA_Baldes ;
            CA_Baldes++; //chequear con CMAX, rehash?
        }

       public bool Agregar(KeyValuePair<int,cUsuario> pair)
        {
            Lista.AddLast(pair);
            return true;
        }

       public bool Agregar(int key, cUsuario value)
        {
            KeyValuePair<int,cUsuario> pair = new KeyValuePair<int, cUsuario>(key,value);
            return Agregar(pair);
        }

        
        //metodos: agregar, eliminar, buscar
    }
}
