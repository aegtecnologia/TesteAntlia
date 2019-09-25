using Antlia.MovManual.Domain.Contratos.Dominios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Antlia.MovManual.Domain.Dominios
{
    public class ProdutoCosif: Entity
    {

        public string COD_PRODUTO { get; set; }
        public string COD_COSIF { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }
        public virtual ICollection<MovimentoManual> Contatos { get; set; }
    }
}
