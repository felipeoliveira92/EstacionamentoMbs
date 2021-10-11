using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoMbs.Model
{
    class Veiculo
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string placa { get; set; }

        public Veiculo(int id, string modelo, string cor, string placa)
        {
            this.id = id;
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;
        }
    }
}
