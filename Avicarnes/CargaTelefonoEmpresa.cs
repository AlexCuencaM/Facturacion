using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public class CargaTelefonoEmpresa : CargaDeDatos
    {
        public CargaTelefonoEmpresa(Label labelTelfonoDeEmpresa)
        {
            campo = labelTelfonoDeEmpresa;
        }
        public override void presentarData(Plantilla dato)
        {
            TelefonoEmpresaDAO datoTelf = (TelefonoEmpresaDAO)dato;
            campo.Text += "  " + datoTelf.Persona.Cliente.Telf.presentarTelf();
        }
    }
}
