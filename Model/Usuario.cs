using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoMbs.Model
{
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string grupo { get; set; }
        public static bool logado { get; set; } = false;

        public Usuario(int id, string usuario, string senha, string grupo)
        {
            this.id = id;
            this.usuario = usuario;
            this.senha = senha;
            this.grupo = grupo;
        }

        public static void login(string usuario, string senha)
        {
            string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT senha FROM Usuarios WHERE usuario = @usuario";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@usuario", usuario);

            if (sqlCommand.ExecuteScalar() == null)
            {
                MessageBox.Show("usuario não exite!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else if (sqlCommand.ExecuteScalar().ToString() != senha)
            {
                MessageBox.Show("senha invalida!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                logado = true;
            }
            sqlConnection.Close();
        }
    }
}
