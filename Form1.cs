using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoMbs
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            autoComplete();
        }
        private void autoComplete()
        {
            AutoCompleteStringCollection dadosModelo = new AutoCompleteStringCollection();
            AutoCompleteStringCollection dadosCor = new AutoCompleteStringCollection();

            string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT modelo,cor FROM relatorio";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            try
            {
                while (sqlDataReader.Read())
                {                    
                    string modelo = sqlDataReader["modelo"].ToString();
                    string cor = sqlDataReader["cor"].ToString();
                    dadosModelo.Add(modelo);
                    dadosCor.Add(cor);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);                
            }

            textBoxModelo.AutoCompleteCustomSource = dadosModelo;
            textBoxCor.AutoCompleteCustomSource = dadosCor;

            sqlConnection.Close();

        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "INSERT INTO Estatus(modelo, cor, placa, horaEntrada) VALUES(@modelo, @cor, @placa, @horaEntrada)";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@modelo", textBoxModelo.Text);
                sqlCommand.Parameters.AddWithValue("@cor", textBoxCor.Text);
                sqlCommand.Parameters.AddWithValue("@placa", maskedTextBoxPlaca.Text);
                sqlCommand.Parameters.AddWithValue("@horaEntrada", DateTime.Now.ToString());
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                disparar_datagrid();
                autoComplete();
                
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            

            try
            {
                //StreamWriter para gravar um arquivo
                StreamWriter objetoarquivo = new StreamWriter(textBoxModelo.Text + " reciboEntrada.txt", false);//false gera um novo arq toda vez,true grava todos no mesmo arq
                objetoarquivo.WriteLine("============ Estacionamento MBS ==============");
                objetoarquivo.WriteLine("================== Recibo ====================");
                objetoarquivo.WriteLine(" ");
                objetoarquivo.WriteLine("Entrada:");
                objetoarquivo.WriteLine("\tData " + DateTime.Now);
                objetoarquivo.WriteLine("\tRecebemos o Veiculo : " + textBoxModelo.Text);
                objetoarquivo.WriteLine("\tCor : " + textBoxCor.Text);
                objetoarquivo.WriteLine("\tPlaca : " + maskedTextBoxPlaca.Text);
                objetoarquivo.WriteLine("==============================================");
                objetoarquivo.Close();
                Process.Start(textBoxModelo.Text + " reciboEntrada.txt");
                
                /*
                if(printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                    printDocument1.Print();
                }

                */

                
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO");
            }

            textBoxModelo.Text = "";
            textBoxCor.Text = "";
            maskedTextBoxPlaca.Text = "";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            disparar_datagrid();
        }
        public void disparar_datagrid()
        {
            string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            string comando = "SELECT * FROM Estatus";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridViewEstatus.DataSource = dt;
            dataGridViewEstatus.AutoResizeColumns();

            sqlConnection.Close();
        }

        private void buttonSaida_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Estatus WHERE placa = '" + dataGridViewEstatus.CurrentRow.Cells[3].Value.ToString() + "'";
                cmd.ExecuteNonQuery();

                sqlConnection.Close();

                disparar_datagrid();
                
                conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
                sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO relatorio(modelo, cor, placa, horaEntrada, horaSaida) VALUES(@modelo, @cor, @placa, @horaEntrada, @horaSaida)";
                cmd.Parameters.AddWithValue("@modelo", textBoxModelo.Text);
                cmd.Parameters.AddWithValue("@cor", textBoxCor.Text);
                cmd.Parameters.AddWithValue("@placa", maskedTextBoxPlaca.Text);
                cmd.Parameters.AddWithValue("@horaEntrada", textBoxHoraEntrada.Text);
                cmd.Parameters.AddWithValue("@horaSaida", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                
                sqlConnection.Close();
               
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

            try
            {
                //StreamWriter para gravar um arquivo
                StreamWriter objetoarquivo = new StreamWriter(textBoxModelo.Text + " reciboSaida.txt", false);//false gera um novo arq toda vez,true grava todos no mesmo arq
                objetoarquivo.WriteLine("========== Estacionamento MBS ===============");
                objetoarquivo.WriteLine("================ Recibo =====================");
                objetoarquivo.WriteLine(" ");
                objetoarquivo.WriteLine("Saida:");
                objetoarquivo.WriteLine("\tData " + DateTime.Now);
                objetoarquivo.WriteLine("\tDo Veiculo : " + textBoxModelo.Text);
                objetoarquivo.WriteLine("\tCor : " + textBoxCor.Text);
                objetoarquivo.WriteLine("\tPlaca : " + maskedTextBoxPlaca.Text);
                objetoarquivo.WriteLine("\tValor Cobrado : R$" + total.ToString());
                objetoarquivo.WriteLine("==============================================");
                objetoarquivo.Close();
                Process.Start(textBoxModelo.Text + " reciboSaida.txt");

                

                textBoxModelo.Text = "";
                textBoxCor.Text = "";
                maskedTextBoxPlaca.Text = "";
                labelHoraEntrada.Visible = false;
                textBoxHoraEntrada.Visible = false;
                textBoxHoraEntrada.Text = "";
                buttonSaida.Visible = false;
                buttonNao.Visible = false;
                labelAlerta.Text = "";
                buttonCadastrar.Visible = true;
                labelValorCobrar.Visible = false;
                labelTotal.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO");
            }

        }

        double horas, total;

        private void dataGridViewEstatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewEstatus.CurrentRow == null)
            {
                MessageBox.Show("Não há carros estacionados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelAlerta.Text = "Dar Saida Para " + dataGridViewEstatus.CurrentRow.Cells[1].Value.ToString() + "?";
                textBoxModelo.Text = dataGridViewEstatus.CurrentRow.Cells[1].Value.ToString();
                textBoxCor.Text = dataGridViewEstatus.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxPlaca.Text = dataGridViewEstatus.CurrentRow.Cells[3].Value.ToString();
                labelHoraEntrada.Visible = true;
                textBoxHoraEntrada.Visible = true;
                textBoxHoraEntrada.Text = dataGridViewEstatus.CurrentRow.Cells[4].Value.ToString();
                buttonNao.Visible = true;
                buttonSaida.Visible = true;
                buttonCadastrar.Visible = false;
                labelValorCobrar.Visible = true;
                labelTotal.Visible = true;

                DateTime dataEntrada, dataSaida;
                TimeSpan result;
                
                double minutos;

                dataEntrada = Convert.ToDateTime(dataGridViewEstatus.CurrentRow.Cells[4].Value.ToString());
                dataSaida = Convert.ToDateTime(DateTime.Now.ToString());                

                result = dataSaida - dataEntrada;
                horas = Convert.ToDouble(result.Hours.ToString()) * 5;
                minutos = Convert.ToDouble(result.Minutes.ToString()) * 0.09;

                total = horas + minutos;

                labelValorCobrar.Text = "R$ " + total.ToString();
            }
            
        }

        private void buttonRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.ShowDialog();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelAlerta.Text = "";
            textBoxModelo.Text = "";
            maskedTextBoxPlaca.Text = "";
            textBoxCor.Text = "";
            labelHoraEntrada.Visible = false;
            textBoxHoraEntrada.Visible = false;
            buttonSaida.Visible = false;
            buttonNao.Visible = false;
            buttonCadastrar.Visible = true;
            labelValorCobrar.Visible = false;
            labelTotal.Visible = false;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int x = 10;
            int y = 10;
            e.Graphics.DrawString("============ Estacionamento MBS ==============", font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString("================== Recibo ====================", font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString(" ", font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString("Entrada:", font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString("\tData " + DateTime.Now, font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString("\tRecebemos o Veiculo : " + textBoxModelo.Text, font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString("\tCor : " + textBoxCor.Text, font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString("\tPlaca : " + maskedTextBoxPlaca.Text, font, Brushes.Black, x, y+=20);
            e.Graphics.DrawString("==============================================", font, Brushes.Black, x, y+=20);

        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
