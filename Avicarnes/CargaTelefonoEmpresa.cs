﻿using System.Windows.Forms;
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
            campo.Text += "  " + datoTelf.Campo.Cliente.Telf.presentarTelf();
        }
    }
}
