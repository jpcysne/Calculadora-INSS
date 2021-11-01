using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Interface
{
    public interface IBuscarTabelaINSS
    {
        TabelaINSS BuscarTabelaAliquotaINSS(string ano, decimal salario);
    }
}
