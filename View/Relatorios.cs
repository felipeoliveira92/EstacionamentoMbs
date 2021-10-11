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
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }        

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewRelatorios.Visible = true;
                string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                SqlCommand comando = sqlConnection.CreateCommand();
                comando.CommandType = CommandType.Text;

                if(textBoxModelo.Text == "" && textBoxPlaca.Text == "")
                {
                    comando.CommandText = "SELECT * FROM relatorio WHERE horaEntrada between @dataInicio and @dataFim order by horaEntrada";
                }
                else if(textBoxModelo.Text != "")
                {
                    comando.CommandText = "SELECT * FROM relatorio WHERE horaEntrada between @dataInicio and @dataFim and modelo like @modelo order by horaEntrada";
                }
                else if (textBoxPlaca.Text != "")
                {
                    comando.CommandText = "SELECT * FROM relatorio WHERE horaEntrada between @dataInicio and @dataFim and placa = @placa order by horaEntrada";
                }

                comando.Parameters.AddWithValue("@dataInicio", dateTimePickerInicio.Value.ToString());
                comando.Parameters.AddWithValue("@dataFim", dateTimePickerFim.Value.ToString());
                comando.Parameters.AddWithValue("@modelo", "%" + textBoxModelo.Text + "%");
                comando.Parameters.AddWithValue("@placa", textBoxPlaca.Text);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dataGridViewRelatorios.DataSource = dt;
                dataGridViewRelatorios.Columns[0].Visible = false;
                dataGridViewRelatorios.AutoResizeColumns();

                sqlConnection.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            
        }

        private void dataGridViewRelatorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            dateTimePickerInicio.Value = DateTime.Now.AddDays(-0.5);
            dataGridViewRelatorios.AutoResizeColumns();
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {            
            string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
            SqlConnection sqlConnection = new SqlConnection(conexao);
            sqlConnection.Open();

            SqlCommand comando = sqlConnection.CreateCommand();
            comando.CommandType = CommandType.Text;

            if (textBoxModelo.Text == "" && textBoxPlaca.Text == "")
            {
                comando.CommandText = "select * from relatorio where horaEntrada between @dataInicio and @dataFim order by horaEntrada";
            }
            else if (textBoxModelo.Text != "")
            {
                comando.CommandText = "select * from relatorio where horaEntrada between @dataInicio and @dataFim and modelo like @modelo order by horaEntrada";
            }
            else if (textBoxPlaca.Text != "")
            {
                comando.CommandText = "select * from relatorio where horaEntrada between @dataInicio and @dataFim and placa = @placa order by horaEntrada";
            }

            comando.Parameters.AddWithValue("@dataInicio", dateTimePickerInicio.Value.ToString());
            comando.Parameters.AddWithValue("@dataFim", dateTimePickerFim.Value.ToString());
            comando.Parameters.AddWithValue("@modelo", "%" + textBoxModelo.Text + "%");
            comando.Parameters.AddWithValue("@placa", textBoxPlaca.Text);  

            SqlDataReader sqlDataReader = comando.ExecuteReader();            

            try
            {
                //int i = 130;
                int j = 160;

                e.Graphics.DrawString("Relatorio", new Font("Centuey Gothic", 36, FontStyle.Bold), Brushes.Black, new PointF(250, 40));
                e.Graphics.DrawString("Modelo", new Font("Centuey Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 130));
                e.Graphics.DrawString("Cor", new Font("Centuey Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(180, 130));
                e.Graphics.DrawString("Placa", new Font("Centuey Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(270, 130));
                e.Graphics.DrawString("Hora entrada", new Font("Centuey Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(400, 130));
                e.Graphics.DrawString("Hora saida", new Font("Centuey Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 130));

                while (sqlDataReader.Read())
                {
                    string modelo = sqlDataReader["modelo"].ToString();
                    string cor = sqlDataReader["cor"].ToString();
                    string placa = sqlDataReader["placa"].ToString();
                    string horaEntrada = sqlDataReader["horaEntrada"].ToString();
                    string horaSaida = sqlDataReader["horaSaida"].ToString();

                    e.Graphics.DrawString(modelo, new Font("Centuey Gothic", 12, FontStyle.Bold), Brushes.Gray, new PointF(50, j));
                    e.Graphics.DrawString(cor, new Font("Centuey Gothic", 12, FontStyle.Bold), Brushes.Gray, new PointF(180, j));
                    e.Graphics.DrawString(placa, new Font("Centuey Gothic", 12, FontStyle.Bold), Brushes.Gray, new PointF(270, j));
                    e.Graphics.DrawString(horaEntrada, new Font("Centuey Gothic", 12, FontStyle.Bold), Brushes.Gray, new PointF(400, j));
                    e.Graphics.DrawString(horaSaida, new Font("Centuey Gothic", 12, FontStyle.Bold), Brushes.Gray, new PointF(600, j));
                    //i += 10;
                    j += 35;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

            sqlConnection.Close();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
