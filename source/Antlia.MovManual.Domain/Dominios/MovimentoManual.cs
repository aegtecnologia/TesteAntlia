using Antlia.MovManual.Domain.Contratos.Dominios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Antlia.MovManual.Domain.Dominios
{
    public class MovimentoManual : Entity
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
        public int NUM_LANCAMENTO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string COD_COSIF { get; set; }
        public double VAL_VALOR { get; set; }
        public string DES_DESCRICAO { get; set; }
        public DateTime DAT_MOVIMENTO { get; set; }
        public string COD_USUARIO { get; set; }
    }
}
