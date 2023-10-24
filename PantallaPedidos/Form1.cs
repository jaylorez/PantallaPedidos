using System;
using biblioUsuario;
using System.Windows.Forms;
using System.Collections;

namespace PantallaPedidos
{
    public partial class PizzaFlix : Form
    {
        private ArrayList usuarios;
        private Boolean terminar = true;
        private byte index;
        public PizzaFlix()
        {
            InitializeComponent();
            usuarios = new ArrayList();
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            usuarios.Add(new Usuarios("Tony", "eljefe69"));
            usuarios.Add(new Usuarios("Carlotta", "pizzalover4"));
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            foreach (object usuario in usuarios)
            {
                terminar = true;
                Usuarios miUsuario = (Usuarios)usuario;
                if (txtbUsuario.Text == miUsuario.NomUsuario && txtbContrasena.Text ==
                miUsuario.Password)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    terminar = false;
                    break;
                }
            }
            if (terminar)
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
        }


    }
}
