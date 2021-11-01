using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Abstract
{
    public abstract class TabelaINSSAbstract
    {
        public abstract TabelaINSS CalculoAliquota(decimal salario);
    }
}
