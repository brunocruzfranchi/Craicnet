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
            this.Admin = false;
        }
        public cUsuario(string id, string password, bool admin)
        {
            this.Id = id;
            this.Password = password;
            this.Admin = admin;
        }
        public string Id { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
    }
}
