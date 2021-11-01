using INSS.Interface;
using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Service
{
    class CalculadorINSS : ICalculadorInss
    {
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            try
            {
                decimal valorDescontoINSS = 0;
                string ano = data.Year.ToString();

                BuscarTabelaINSS buscarTabelaINSS = new BuscarTabelaINSS();
                TabelaINSS tabelaINSS = buscarTabelaINSS.BuscarTabelaAliquotaINSS(ano, salario);

                if (tabelaINSS.Teto == 0)
                {
                    valorDescontoINSS = ((salario * tabelaINSS.Aliquota) / 100);
                }
                else
                {
                    valorDescontoINSS = tabelaINSS.Teto;
                }

                return valorDescontoINSS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
