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

namespace EstacionamentoMbs
{
    public partial class Backup : Form
    {        

        public Backup()
        {
            InitializeComponent();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if(folderBrowser.ShowDialog()== DialogResult.OK)
            {
                textBoxCaminhoCriar.Text = folderBrowser.SelectedPath;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string dataBase = sqlConnection.Database.ToString();

            if (textBoxCaminhoCriar.Text == "")
            {
                MessageBox.Show("insira um caminho", "mensagem",MessageBoxButtons.OK);
            }
            else
            {                

                string comando = "BACKUP DATABASE [" + dataBase + "] TO DISK = '" + textBoxCaminhoCriar.Text + "\\backup-" + DateTime.Today.ToString("dd-mm-yyyy") + ".bak'";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Backup realizado com sucesso!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxCaminhoCriar.Text = "";
            }


        }

        private void buttonProcurarArq_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "SQL SERVER database backups files|*.bak";
            fileDialog.Title = "Importar Banco de Dados";

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxImportar.Text = fileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string dataBase = sqlConnection.Database.ToString();

            if (textBoxImportar.Text == "")
            {
                MessageBox.Show("insira um caminho", "mensagem", MessageBoxButtons.OK);
            }
            else
            {
                //GRANT “permissão” ON “objeto” TO “usuário”
                /*string comando = "GRANT ALTER ON [ " + dataBase + " ] TO USER";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.ExecuteNonQuery();*/

                string comando1 = "ALTER DATABASE [ " + dataBase + " ] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                SqlCommand sqlCommand1 = new SqlCommand(comando1, sqlConnection);
                sqlCommand1.ExecuteNonQuery();

                //RESTORE DATABASE Vendas FROM DISK = 'C:\Boson\DBVENDAS_20190115.BAK' WITH REPLACE
                string comando2 = "USE MASTER RESTORE DATABASE [ " + dataBase + " ] FROM DISK = '" + textBoxImportar.Text + "' WITH REPLACE;";
                SqlCommand sqlCommand2 = new SqlCommand(comando2, sqlConnection);
                sqlCommand2.ExecuteNonQuery();

                string comando3 = "ALTER DATABASE [ " + dataBase + " ] SET MULTI_USER;";
                SqlCommand sqlCommand3 = new SqlCommand(comando3, sqlConnection);
                sqlCommand3.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Dados importados com sucesso!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
