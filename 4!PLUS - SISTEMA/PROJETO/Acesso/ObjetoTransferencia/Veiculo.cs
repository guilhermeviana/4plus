using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Veiculo
    {
        public int ID_VEICULO { get; set; }
        public int ID_CLIENTE { get; set; }
        public string PLACA { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public int ANO { get; set; }
        public string COR { get; set; }
        public string COMBUSTIVEL { get; set; }
        public string NOME_CLIENTE { get; set; }
    }
}
