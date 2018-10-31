using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPFINAL_Craicnet
{
    class Hash
    {
        public LinkedList <cBalde> T_Hash { get; set; }
        public float factor_de_cargas { get; set; }
        public const float FC_MAX = 0.8F;

        // metodos: agregar, eliminar (buscar y cambiar bool), buscar, backup, calcular factor de carga, rehash
    }
}
