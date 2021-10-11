using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoMbs.Model
{
    class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

        public Usuario(int id, string usuario, string senha)
        {
            this.id = id;
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
