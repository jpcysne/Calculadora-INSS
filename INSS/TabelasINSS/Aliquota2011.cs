using INSS.Abstract;
using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.TabelasINSS
{
    public class Aliquota2011 : TabelaINSSAbstract
    {
        public override TabelaINSS CalculoAliquota(decimal salario)
        {
            TabelaINSS tabelaINSS = new TabelaINSS();

            switch (salario)
            {
                case decimal salarioBase when (salarioBase <= 1106.90M):
                    tabelaINSS.Aliquota = 8;
                    tabelaINSS.Teto = 0;               
                    break;
                case decimal salarioBase when ((salarioBase >= 1106.91M) && (salarioBase <= 1844.83M)):
                    tabelaINSS.Aliquota = 9;
                    tabelaINSS.Teto = 0;
                    break;
                case decimal salarioBase when ((salarioBase >= 1844.84M) && (salarioBase <= 3689.66M)):
                    tabelaINSS.Aliquota = 11;
                    tabelaINSS.Teto = 0;
                    break;
                default:
                    tabelaINSS.Aliquota = 0;
                    tabelaINSS.Teto = 405.86M;
                    break;
            }

            return tabelaINSS;
        }
    }
}
