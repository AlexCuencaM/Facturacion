using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public sealed class CargaTelefonoEmpresa : CargaDeDatos<Label>
    {
        public CargaTelefonoEmpresa(Label labelTelfonoDeEmpresa)
        {
            campo = labelTelfonoDeEmpresa;
        }
        protected override void presentarData(Plantilla dato)
        {
            TelefonoEmpresaDAO datoTelf = (TelefonoEmpresaDAO)dato;
            campo.Text += "  " + datoTelf.Persona.Cliente.Telf.presentarTelf();
        }
    }
}
