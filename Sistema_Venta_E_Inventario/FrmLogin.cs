using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venta_E_Inventario
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text) || string.IsNullOrWhiteSpace(txtContrasenaLogin.Text))
            {
                MessageBox.Show("Favor de llenar los campos en blanco!", "ERROR INICIO SESION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = Conexion.abrirConexion())
                {
                    cn.Open();

                    string query = "Select Count(1) From Usuario Where Usuario = @usuario AND Contrasena = @contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", txtUsuarioLogin.Text.Trim());
                        cmd.Parameters.AddWithValue("@contrasena", txtContrasenaLogin.Text.Trim());

                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                        if(resultado > 0)
                        {
                            MessageBox.Show("Bienvenido al sistema!", "INICIO SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FrmMenuPrincipal frmmenuprincipal = new FrmMenuPrincipal();
                            frmmenuprincipal.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contrasena incorrectos!", "ERROR INICIO SESION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtContrasenaLogin.Clear();
                            txtUsuarioLogin.Clear();
                        }

                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion a la base de datos" + ex.Message, "ERROR BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
