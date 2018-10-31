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
            this.Key = " ";//= generar clave
            this.Value = new cUsuario();
           // this.Eliminado = false;
        }
        public cNodo(cUsuario  u)
        {
            this.Key = " "; //=generar clave
            this.Value = u;
           // this.Eliminado = false;
        }
        public string Key { get; set; }
        public cUsuario Value { get; set; }
        public bool  eliminado { get; set; }
    }
}

        
