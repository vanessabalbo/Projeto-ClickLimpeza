using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickLimpeza.Classes
{
    internal class Ordem
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ServicoId { get; set; }
        public int FuncionarioId { get; set; }
        public bool Situacao { get; set; }
    }
}
