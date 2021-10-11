using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoMbs
{
    public partial class login : Form
    {
        Thread thread;

        public login()
        {
            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT senha FROM Usuarios WHERE usuario = @usuario";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@usuario", textBoxUsuario.Text);

            if(sqlCommand.ExecuteScalar() == null)
            {
                MessageBox.Show("usuario não exite!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUsuario.Focus();
            }
            else if(sqlCommand.ExecuteScalar().ToString() == textBoxSenha.Text)
            {
                this.Close();
                thread = new Thread(abrirHome);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();                
            }
        }
        private void abrirHome(object obj)
        {
            Application.Run(new Home());
        }
    }
}
