using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoMbs.Model
{
    public class Veiculo
    {
        public Veiculo(string modelo, string cor, string placa, DateTime dataEntrada)
        {
            this.Modelo = modelo;
            this.Cor = cor;
            this.Placa = placa;
            this.DataEntrada = dataEntrada;

            try
            {
                string conexao = EstacionamentoMbs.Properties.Settings.Default.BdMbs;
                SqlConnection sqlConnection = new SqlConnection(conexao);
                sqlConnection.Open();

                string comando = "INSERT INTO Estatus(modelo, cor, placa, horaEntrada) " +
                    "VALUES(@modelo, @cor, @placa, @horaEntrada)";
                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@modelo", modelo);
                sqlCommand.Parameters.AddWithValue("@cor", cor);
                sqlCommand.Parameters.AddWithValue("@placa", placa);
                sqlCommand.Parameters.AddWithValue("@horaEntrada", dataEntrada);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }        
    }
}
