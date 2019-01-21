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
        private string numeroTelefonos;
        public List<string> ListaTelefono { get => listaTelefono; set => listaTelefono = value; }
        public string NumeroTelefonos { get => numeroTelefonos; set => numeroTelefonos = value; }
        
        
        public Telefono()
        {
            NumeroTelefonos = "";
            listaTelefono = new List<string>();
        }

        public void agregarTelefono(string telf)
        {
            ListaTelefono.Add(telf);
        }

       
        public void limpiar()
        {
            listaTelefono.Clear();
        } 

        public string presentarTelf()
        {            
            foreach (string i in listaTelefono)
                numeroTelefonos += i + "  ";
            return numeroTelefonos;
        }
    }
}
