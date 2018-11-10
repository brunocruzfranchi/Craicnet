using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_Craicnet
{
    public class cBaldeExt
    {

        public LinkedList<KeyValuePair<int, cUsuario>> Lista { get; set; }
        public int Clave_Balde { get; set; }
        public static int CA_Baldes { get; set; }
        public const int CMAX = 4; // Cant max de elementos x balde

        static cBaldeExt()
        {
            CA_Baldes = 0;
        }

        public cBaldeExt()
        {
            this.Lista = new LinkedList<KeyValuePair<int, cUsuario>>();
            this.Clave_Balde = CA_Baldes;
            CA_Baldes++;
        }

        public bool Agregar(KeyValuePair<int, cUsuario> pair)
        {
            if (Lista.Count >= CMAX)
                return false;
            Lista.AddLast(pair);
            return true;
        }

        public bool Agregar(int key, cUsuario value)
        {
            KeyValuePair<int, cUsuario> pair = new KeyValuePair<int, cUsuario>(key, value);
            return Agregar(pair);
        }

        public bool Eliminar(int key)
        {
            foreach (KeyValuePair<int, cUsuario> pair in Lista)
            {
                if (pair.Key == key)
                {
                    Lista.Remove(pair);
                    return true;
                }
            }
            return false; //no encontrado
        }
        public KeyValuePair<int, cUsuario> Buscar_par(int key, string id)
        {
            foreach (KeyValuePair<int, cUsuario> pair in Lista)
            {
                if (pair.Key == key)

                    if (pair.Value.Id == id)
                        return pair;
            }

            return new KeyValuePair<int, cUsuario>(-1, null);
        }
        public cUsuario Buscar_usuario(int key, string id)
        {
            KeyValuePair<int, cUsuario> aux = Buscar_par(key, id);

            return aux.Value;

        }
        public cUsuario Buscar_usuario(string id)
        {
            foreach (KeyValuePair<int, cUsuario> pair in Lista)
            {
                if (pair.Value.Id == id)
                    return pair.Value;
            }
            return null;
        }

        //metodos: agregar, eliminar, buscar
    }
}
