using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venta_E_Inventario
{
    public partial class FrmCobrar : Form
    {
        public decimal MontoPago { get; private set; }
        public decimal MontoDevuelta { get; private set; }

        private decimal totalFactura;
        public FrmCobrar(decimal total)
        {
            InitializeComponent();
            totalFactura = total;
            txtTotalCobrar.Text = totalFactura.ToString("N2");
        }

        private void FrmCobrar_Load(object sender, EventArgs e)
        {

        }

        private void txtEfectivoRecibido_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEfectivoRecibido.Text, out decimal efectivo))
            {
                decimal cambio = efectivo - totalFactura;
                if (cambio >= 0)
                {
                    txtDevuelta.Text = cambio.ToString("N2");
                }
                else
                {
                    txtDevuelta.Text = "Esta faltando dinero!";
                }
            }
            else
            {
                txtDevuelta.Clear();
            }
        }

        private void btnAceptarCobro_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(txtEfectivoRecibido.Text, out decimal efectivo) || efectivo < totalFactura)
            {
                MessageBox.Show("El monto ingresado es invalido o menor que el monto a pagar!", "ERROR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MontoPago = efectivo;
            MontoDevuelta = efectivo - totalFactura;

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
