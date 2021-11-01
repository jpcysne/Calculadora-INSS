using INSS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Models
{
    public class TabelaINSS : ITabelaINSS
    {
        public decimal Aliquota { get; set; }
        public decimal Teto { get; set; }

        public TabelaINSS()
        {
        }
    }
}
