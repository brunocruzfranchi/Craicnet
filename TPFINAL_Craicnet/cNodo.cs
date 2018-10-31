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
            this.Key = " ";
            this.Value = new cUsuario();
        }
        public string Key { get; set; }
        public cUsuario Value { get; set; }
        public bool  eliminado { get; set; }
    }

        
