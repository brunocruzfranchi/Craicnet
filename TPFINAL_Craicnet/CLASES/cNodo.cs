using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
    public class cNodo
    {
        public cNodo()
        {
            this.Key = CT_Nodos ;//= generar clave
            this.Value = new cUsuario();
           this.Eliminado = false;
            CT_Nodos++;
        }
        public cNodo(cUsuario  u)
        {
            this.Key = CT_Nodos; //=generar clave
            this.Value = u;
           this.Eliminado = false;
            CT_Nodos++;
        }
        public int Key { get; set; }
        public cUsuario Value { get; set; }
        public bool Eliminado { get; set; }
        public static int CT_Nodos { get; set; }

        static cNodo()
        {
            CT_Nodos = 0;
        }
    }
}

        
