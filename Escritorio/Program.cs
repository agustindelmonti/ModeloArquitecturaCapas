using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            Usuario usuarioActual = loginForm.UsuarioAutenticado;
            if (usuarioActual != null)
            {
                switch (usuarioActual.Persona.TipoPersona)
                {
                    case Persona.Rol.Alumno: { Application.Run(new ListaPlanes()); break; }
                    case Persona.Rol.Docente: { Application.Run(new MenuDocente(usuarioActual)); break; }
                    case Persona.Rol.No_Docente: { Application.Run(new MenuNoDocente(usuarioActual)); break;  }
                    default: break;
                }
            }
        }
    }
}
