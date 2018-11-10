using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPFINAL_Craicnet
{
    class HashExt
    {
        public List<cBaldeExt> T_Hash { get; set; }
        public const float FC_MAX = 0.7F;
        public int BaldesMAX;
        public int CA_Elementos { get; set; }
        public HashExt()
        {
            this.BaldesMAX = 23;
            this.T_Hash = new List<cBaldeExt>();
            for (int i = 0; i < BaldesMAX; i++)
            {
                T_Hash[i] = new cBaldeExt(); //ERROR

            }
            this.CA_Elementos = 0;
        }
        public HashExt(int baldesmax)
        {
            this.BaldesMAX = baldesmax;
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
        public bool NecesitoRehash()
        {
            float fc = CalcularFC();
            if (fc < FC_MAX)
                return false;
            return true;
        }
        public int DefinoClave(string key)
        {
            return int.Parse(key.Substring(3, 3));
        }
        public int FuncionHash(string id)
        {

            return DefinoClave(id) % BaldesMAX;
        }
        public int FuncionHash(int key)
        {
            return key % BaldesMAX;
        }
        public bool Agregar(cUsuario usuario)
        {
            int key = DefinoClave(usuario.Id);
            if (Buscar_usuario(usuario.Id) != null)
                return false; // Id ya existente
            CA_Elementos++;
            int n_balde = FuncionHash(usuario.Id);

            bool aux = T_Hash[n_balde].Agregar(key, usuario);
            if (!aux)
            {
                Rehash();
                aux = T_Hash[n_balde].Agregar(key, usuario);
            }
            if (NecesitoRehash())
                Rehash();

            return aux;

        }
        public bool Eliminar(int key)
        {
            T_Hash[FuncionHash(key)].Eliminar(key);

            CA_Elementos--;
            return true;
        }
        public cUsuario Buscar_usuario(string id)
        {
            int clave = DefinoClave(id);
            return T_Hash[FuncionHash(clave)].Buscar_usuario(clave, id); //ERROR
        }

        /* public cUsuario Buscar_usuario(string id)
         {
             foreach (cBaldeExt balde in T_Hash)
             {
                return balde.Buscar_usuario(id);
             }
             return null;
         }*/
        public void Rehash()
        {
            List<cBaldeExt> Lista_nueva = new List<cBaldeExt>();
            BaldesMAX = BaldesMAX * 2;
            for (int i = 0; i < BaldesMAX; i++)
                Lista_nueva[i] = new cBaldeExt();

            foreach (cBaldeExt balde in T_Hash) //Agrego todos a mi nueva lista
                foreach (KeyValuePair<int, cUsuario> pair in balde.Lista)
                    Lista_nueva[FuncionHash(pair.Key)].Agregar(pair);

            T_Hash = Lista_nueva;  //liberar memoria??
        }

        // metodos: agregar, eliminar (buscar y cambiar bool), buscar, backup(??? no hace falta porque es extensible), rehash
    }



}

