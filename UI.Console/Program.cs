using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuarios User = new Usuarios();
            User.Menu();
        }
    }

    public class Usuarios
    {
        public Business.Logic.UsuarioLogic UsuariosNegocio { get; set; }

        public Usuarios()
        {
            UsuariosNegocio = new UsuarioLogic();
        }

        
        private void ListadoGeneral()
        {
            //Recorre los usuarios de la BD y los lista

            Console.Clear();

            foreach(Usuario usr in UsuariosNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
            Console.ReadKey();

        }

        private void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();
        }

        private void Consultar()
        {
            //Pide un id de usuario, lo consulta en la BD y si lo encuentra lo muestra
            Console.Clear();

            try
            {
                Console.WriteLine("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuariosNegocio.GetOne(ID));
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un número entero.");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nPrecione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        private void Modificar()
        {
            try
            {
                Console.Clear();

                Console.Write("Ingrese ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());

                Usuario usr = UsuariosNegocio.GetOne(ID);
                Console.Write("\tNombre: ");
                usr.Nombre = Console.ReadLine();
                Console.Write("\tApellido: ");
                usr.Apellido = Console.ReadLine();
                Console.Write("\tNombre de usuario: ");
                usr.NombreUsuario = Console.ReadLine();
                Console.Write("\tClave: ");
                usr.Clave = Console.ReadLine();
                Console.Write("\tEmail: ");
                usr.Email = Console.ReadLine();
                Console.Write("\tHabilitacion (1-Si / Otro-No): ");
                usr.Habilitado = (Console.ReadLine() == "1");
                usr.State = BusinessEntity.States.Modified;

                UsuariosNegocio.Save(usr);


            }
            catch (FormatException e)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un número entero.");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nPrecione una tecla para continuar.");
                Console.ReadKey();
            }

        }

        private void Agregar()
        {
            Usuario usr = new Usuario();

            Console.Clear();
            Console.Write("\tNombre: ");
            usr.Nombre = Console.ReadLine();
            Console.Write("\tApellido: ");
            usr.Apellido = Console.ReadLine();
            Console.Write("\tNombre de usuario: ");
            usr.NombreUsuario = Console.ReadLine();
            Console.Write("\tClave: ");
            usr.Clave = Console.ReadLine();
            Console.Write("\tEmail: ");
            usr.Email = Console.ReadLine();
            Console.Write("\tHabilitacion (1-Si / Otro-No): ");
            usr.Habilitado = (Console.ReadLine() == "1");
            usr.State = BusinessEntity.States.New;

            UsuariosNegocio.Save(usr);
            Console.WriteLine("\nID: {0}", usr.ID);

        }

        private void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());

                UsuariosNegocio.Delete(ID);
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un número entero.");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nPrecione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        public void Menu()
        {
            int opMenu = 1;

            while(opMenu != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1-Listado General\n2-Consulta\n3-Agregar\n4-Modificar\n5-Eliminar");
                Console.WriteLine("0-Salir");
                opMenu = Convert.ToInt32(Console.ReadLine());

                switch (opMenu)
                {
                    case 1:
                        {
                            this.ListadoGeneral();
                            break;
                        }

                    case 2:
                        {
                            this.Consultar();
                            break;
                        }

                    case 3:
                        {
                            this.Agregar();
                            break;
                        }

                    case 4:
                        {
                            this.Modificar();
                            break;
                        }

                    case 5:
                        {
                            this.Eliminar();
                            break;
                        }
                }

            }
        }
    }
}
