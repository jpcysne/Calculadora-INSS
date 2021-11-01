using INSS.Abstract;
using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.TabelasINSS
{
    public class Aliquota2012 : TabelaINSSAbstract
    {
        public override TabelaINSS CalculoAliquota(decimal salario)
        {
            TabelaINSS tabelaINSS = new TabelaINSS();

            switch (salario)
            {
                case decimal salarioBase when (salarioBase <= 1000M):
                    tabelaINSS.Aliquota = 7;
                    tabelaINSS.Teto = 0;
                    break;
                case decimal salarioBase when ((salarioBase >= 1000.01M) && (salarioBase <= 1500M)):
                    tabelaINSS.Aliquota = 8;
                    tabelaINSS.Teto = 0;
                    break;
                case decimal salarioBase when ((salarioBase >= 1500.01M) && (salarioBase <= 3000M)):
                    tabelaINSS.Aliquota = 9;
                    tabelaINSS.Teto = 0;
                    break;
                case decimal salarioBase when ((salarioBase >= 3000.01M) && (salarioBase <= 4000M)):
                    tabelaINSS.Aliquota = 11;
                    tabelaINSS.Teto = 0;
                    break;
                default:
                    tabelaINSS.Aliquota = 8;
                    tabelaINSS.Teto = 500M;
                    break;
            }

            return tabelaINSS;
        }
    }
}
