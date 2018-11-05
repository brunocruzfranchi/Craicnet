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
        public const float FC_MAX = 0.8F;
        public const int BaldesMAX = 23;
        public int CA_Elementos { get; set; }
        public HashExt()
        {
            this.T_Hash = new List<cBaldeExt>();
            for (int i = 0; i < BaldesMAX; i++)
            {
                T_Hash[i] = new cBaldeExt();
            }
            this.CA_Elementos = 0;

        }
        public float CalcularFC()
        {
            return CA_Elementos / (T_Hash.Count * cBaldeExt.CMAX); ;
        }
        public bool NecesitoRehash() {
            float fc = CalcularFC();
            if (fc < FC_MAX)
                return false;
            return  true;           
        }
        public int FuncionHash(int key) {
            return key % BaldesMAX;
        }
        public bool Agregar(cUsuario usuario)
        {
            if (Buscar_usuario(usuario.Id) != null)
                return false; // Id ya existente
            int key = CA_Elementos;
            CA_Elementos++;
            int n_balde = FuncionHash(key);
            return T_Hash[n_balde].Agregar(key, usuario);
        
        }
        public bool Eliminar(int key)
        {
            T_Hash[FuncionHash(key)].Eliminar(key);

            CA_Elementos--;
            return true;
        }
        public cUsuario Buscar_usuario(int key)
        {
            return T_Hash[FuncionHash(key)].Buscar_usuario(key);
        }
        public cUsuario Buscar_usuario(string id)
        {
            foreach (cBaldeExt balde in T_Hash)
            {
               return balde.Buscar_usuario(id);
            }
            return null;
        }
       
        // metodos: agregar, eliminar (buscar y cambiar bool), buscar, backup, rehash
    }

   

}

