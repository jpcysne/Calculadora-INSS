using INSS.Abstract;
using INSS.Interface;
using INSS.Models;
using INSS.TabelasINSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Service
{
    public class BuscarTabelaINSS : IBuscarTabelaINSS
    {
        public TabelaINSS BuscarTabelaAliquotaINSS(string ano, decimal salario)
        {
            TabelaINSS tabelaINSS = new TabelaINSS();
            TabelaINSSAbstract tabelaINSSAbstract;

            switch (ano)
            {
                case "2011":
                    tabelaINSSAbstract = new Aliquota2011();
                    tabelaINSS = tabelaINSSAbstract.CalculoAliquota(salario);
                    break;
                case "2012":
                    tabelaINSSAbstract = new Aliquota2012();
                    tabelaINSS = tabelaINSSAbstract.CalculoAliquota(salario);
                    break;
                default:
                    break;
            }

            return tabelaINSS;
        }
    }
}
