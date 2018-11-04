using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
     public class cUsuario
    {
        public cUsuario()
        {
            this.Id = " ";
            this.Password = " ";
            this.Admin = false;
            this.peliculas_alquiladas = new List<cPelicula>();          //Lo podemos usar para almacenar las peliculas alquiladas
        }
        public cUsuario(string id, string password, bool admin)
        {
            this.Id = id;
            this.Password = password;
            this.Admin = admin;
            this.peliculas_alquiladas = new List<cPelicula>();
        }
        public string Id { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }//la idea es eliminarlo y usar algun tipo de dynamic cast
        public List<cPelicula> peliculas_alquiladas { get; set; }
    }
}
