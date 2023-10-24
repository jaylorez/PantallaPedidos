using System;
using System.Windows.Forms;
//using biblioContabilidad;

namespace PantallaPedidos
{
    public partial class PantallaContabilidad : Form
    {
            //Contabilidad conta2 = new Contabilidad();
            private byte[] porcionesPepperoni = { 1, 1, 1, 1, 0, 0, 0 };
            private byte[] porcionesHawaiiana = { 1, 1, 1, 0, 0, 1, 1 };
            private byte[] porcionesTresCarnes = { 1, 1, 1, 1, 1, 1, 0 };
            private double[] costosIngredientes = { 7.5, 14.25, 34.17, 46.5, 40, 30, 8 };
            private double costoPizza;
            private double[] precios = { 150, 180, 200 };
        private byte[] totalPedidos = {0,0,0};
        public double CostoPizza { get => costoPizza; set => costoPizza = value; }

        public PantallaContabilidad(byte[] pedidos)
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                totalPedidos[i] = pedidos[i];
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbPizzasPedidasPepperoni.Text = totalPedidos[0].ToString();
            lbPizzasPedidasHawaiiana.Text = totalPedidos[1].ToString();
            lbPizzasPedidasTresCarnes.Text = totalPedidos[2].ToString();
            lbGananciaTotal.Text = "$"+GananciaTotal(totalPedidos).ToString();
        }
        //Método para calcular los costos y la ganancia, recibe un arreglo 3x1 con el número de pizzas por pedido
        private double GananciaTotal(byte[] pedido)
        {
            byte[] misPizzas = new byte[7];
            for (int i = 0; i < 7; i++)
            {
                misPizzas[i] = (byte)(pedido[0] * porcionesPepperoni[i]
                    + pedido[1] * porcionesHawaiiana[i]
                    + pedido[2] * porcionesTresCarnes[i]);
                CostoPizza += misPizzas[i] * costosIngredientes[i];
            }

            return (pedido[0] * precios[0] + pedido[1] * precios[1] + pedido[2] * precios[2])-CostoPizza ;
        }

    }
}
