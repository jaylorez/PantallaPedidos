using System;
using System.Collections;
using System.Windows.Forms;
using biblioContabilidad;

namespace PantallaPedidos
{
    public partial class Menu : Form
    {
        private byte[] miPedido;
        Contabilidad conta = new Contabilidad();


        public Menu()
        {
            InitializeComponent();
            miPedido = new byte[3];
            
        }
        private void btnPepperoni_Click(object sender, EventArgs e)
        {
            miPedido[0] += 1;
            MostrarPedido();
        }
        private void btnHawaiiana_Click(object sender, EventArgs e)
        {
            miPedido[1] += 1;
            MostrarPedido();

        }

        private void btnTresCarnes_Click(object sender, EventArgs e)
        {
            miPedido[2] += 1;
            MostrarPedido();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
            if (conta.VerificarStock(miPedido))
            {
                conta.ActualizarStock(miPedido);
                lbPrecioTotal.Text = conta.Precios(miPedido).ToString();
            }
            else
            {
                MessageBox.Show(" Ya no hay suficientes ingredientes");
            }
            conta.Total=0;
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            for (int i = 0;i<3;i++)
            {
                miPedido[i] = 0;
            }
            lbPrecioTotal.Text = "";
            lbOrdenPepperoni.Text = "";
            lbOrdenHawaiiana.Text = "";
            lbOrdenTresCarnes.Text = "";

        }
        private void MostrarPedido()
        {
            lbOrdenPepperoni.Text= miPedido[0].ToString();
            lbOrdenHawaiiana.Text= miPedido[1].ToString();
            lbOrdenTresCarnes.Text = miPedido[2].ToString();

        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {

            PantallaContabilidad pantallaCierre = new PantallaContabilidad(conta.TotalPedidos);
            pantallaCierre.Show();

        }
    }
}