using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPFINAL_Craicnet
{
    class HashExt
    {
        public List <cBaldeExt> T_Hash { get; set; }
        public float factor_de_cargas { get; set; }
        public const float FC_MAX = 0.8F;
        public const int BaldesMAX = 23;
        public int CA_Elementos { get; set; }
        public HashExt()
        {
            this.CA_Elementos = 0;

        }
        public bool NecesitoRehash() {
            float fc = CA_Elementos/(T_Hash.Count * cBaldeExt.CMAX);
            if (fc < FC_MAX)
                return false;
            return  true;           
        }
        public int FuncionHash(int key) {
            return key % BaldesMAX;
        }
        public bool Agregar(cUsuario usuario)
        {
            int key = CA_Elementos;
            CA_Elementos++;
            int n_balde = FuncionHash(key);
            return T_Hash[n_balde].Agregar(key, usuario);
        }
        // metodos: agregar, eliminar (buscar y cambiar bool), buscar, backup, rehash
    }

   

}

