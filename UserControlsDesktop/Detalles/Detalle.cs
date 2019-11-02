using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace UserControlsDesktop
{
    public partial class Detalle : UserControl
    {
        public ModoForm Modo { get; set; }

        public Detalle()
        {
            InitializeComponent();
        }

        public virtual void MapearDeDatos() { }

        public virtual void MapearADatos() { }

        public virtual void GuardarCambios() { }

        public virtual bool Validar() { return false; }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons

        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
    }
}
