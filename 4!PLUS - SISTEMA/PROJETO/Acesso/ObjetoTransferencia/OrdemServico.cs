using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class OrdemServico
    {
        public int ID_OS { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_DEFEITO { get; set; }
        public int ID_VEICULO { get; set; }
        public int ID_MECANICA { get; set; }
        public string DATA { get; set; }
        public string STATUS_OS { get; set; }
        public string NOME_CLIENTE { get; set; }
        public string CPF_CLIENTE { get; set; }
        public string PLACA_CLIENTE { get; set; }
        public string MARCA_CLIENTE { get; set; }
        public string MODELO_CLIENTE { get; set; }
        public int ANO_CLIENTE { get; set; }
        public string NOME_MECANICA { get; set; }
        public string NOME_DEFEITO { get; set; }
        public string DESCRIÇÃO_DEFEITO { get; set; }
        public string VALOR_DEFEITO { get; set; }
        public string VALOR_MECANICA { get; set; }
        public string VALOR_OFICINA { get; set; }
        public string VALOR_TOTAL { get; set; }
        public string CADASTRO { get; set; }
    }
}
