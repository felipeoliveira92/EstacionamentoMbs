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
                    comando.CommandText = "select * from relatorio where horaEntrada between @dataInicio and @dataFim order by horaEntrada";
                }
                else if(textBoxModelo.Text != "")
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
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dataGridViewRelatorios.DataSource = dt;
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
            dateTimePickerInicio.Value = DateTime.Now.AddDays(-1);
            dataGridViewRelatorios.AutoResizeColumns();
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
