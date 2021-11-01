using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Interface
{
    public interface ITabelaINSS
    {
        decimal Aliquota { get; }
        decimal Teto { get; }
    }
}
