using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicarnes
{
    public class Telefono
    {
        private List<string> listaTelefono;
        public List<string> ListaTelefono { get => listaTelefono; set => listaTelefono = value; }

        public Telefono()
        {
            listaTelefono = new List<string>();
        }

        public void agregarTelefono(string telf)
        {
            ListaTelefono.Add(telf);
        }

        public string telefono(int index)
        {
            return listaTelefono.ElementAt(index - 1);
        }

        public void limpiar()
        {
            listaTelefono.Clear();
        } 

        public string presentarTelf()
        {
            string result = "";
            foreach (string i in listaTelefono)
                result += i + "    ";
            return result;
        }
    }
}
