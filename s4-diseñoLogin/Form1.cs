using Org.BouncyCastle.Pqc.Crypto.Lms;
using s4_diseñoLogin.Datos;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace s4_diseñoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaLogin = new DataTable();
                Datos.Usuarios dato = new Datos.Usuarios();
                tablaLogin = dato.Log_Usu(txtUser.Text, txtPass.Text);
                if (tablaLogin.Rows.Count > 0)
                {
                    MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal Principal = new frmPrincipal();
                    Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                    Principal.usuario = Convert.ToString(txtUser.Text);
                    Principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrecto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión o consulta: " + ex.Message);
            }
        }

    }
}
