using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
    class cUsuario
    {
        public cUsuario()
        {
            this.Id = " ";
            this.Password = " ";
        }
        public cUsuario(string id, string password)
        {
            this.Id = id;
            this.Password = password;
        }
        public string Id { get; set; }
        public string Password { get; set; }
    }
}
