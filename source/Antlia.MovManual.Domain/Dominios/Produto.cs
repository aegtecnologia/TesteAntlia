using Antlia.MovManual.Domain.Contratos.Dominios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Antlia.MovManual.Domain.Dominios
{
    public class Produto: Entity
    {

        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }
        public ICollection<ProdutoCosif> Produto_Cosifs { get; set; }

        
    }
}
