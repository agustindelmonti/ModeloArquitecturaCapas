using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;
using System.Text.RegularExpressions;

//probar que ande
namespace Escritorio
{
    public partial class AbmUsuarios : ManejadorForm
    {
        public AbmUsuarios()
        {
            InitializeComponent();

            PersonaLogic per = new PersonaLogic();
            List<Persona> listaper = (List<Persona>)per.GetAll();
            cbPersona.DataSource = listaper;
            cbPersona.DisplayMember = "Apellido" + " " + "Nombre";
        }

        public Usuario UsuarioActual { get; set; }

        public AbmUsuarios(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public AbmUsuarios(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioLogic us = new UsuarioLogic();
            UsuarioActual = us.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = UsuarioActual.UsuarioID.ToString();
            chkHabilitado.Checked = UsuarioActual.Habilitado;
            txtUsuario.Text = UsuarioActual.NombreUsuario;
            txtClave.Text = UsuarioActual.Clave;
            txtConfirmarClave.Text = UsuarioActual.Clave;
            cbPersona.SelectedItem = UsuarioActual.Persona;//esto no creo que ande
            if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
        }


        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {

                if (Modo == ModoForm.Alta)
                {
                    Usuario usu = new Usuario();
                    UsuarioActual = usu;
                }
                else
                {
                    UsuarioActual.UsuarioID = int.Parse(txtID.Text);
                }

                UsuarioActual.Habilitado = chkHabilitado.Checked;
                UsuarioActual.NombreUsuario = txtUsuario.Text;
                UsuarioActual.Clave = txtClave.Text;
                UsuarioActual.Persona = (Persona) cbPersona.SelectedItem;
                UsuarioActual.CambioClave = chkCambiaClave.Checked;
            }
            else if (Modo == ModoForm.Baja)
            {
                UsuarioActual.State = BusinessEntity.States.Deleted;
            }
        }


        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic us = new UsuarioLogic();
            if (Modo == ModoForm.Alta)
            {
                us.Add(UsuarioActual);
            }
            else if (Modo == ModoForm.Modificacion)
            {
                us.Update(UsuarioActual);

            }
            else if (Modo == ModoForm.Baja)
            {
                us.Delete(UsuarioActual.UsuarioID);
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(cbPersona.Text))
            {
                Notificar("ERROR!", "Debe seleccionar una persona propietaria de este usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                Notificar("ERROR!", "Debe ingresar un Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                Notificar("ERROR!", "Debe ingresar una Clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtConfirmarClave.Text))
            {
                Notificar("ERROR!", "Debe ingresar la Clave nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((txtClave.Text).Length < 8)
            {
                Notificar("ERROR!", "La clave debe contener 8 caraceres como minimo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtConfirmarClave.Text != txtClave.Text)
            {
                Notificar("ERROR!", "La clave no coincide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
