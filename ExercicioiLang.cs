using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaPoupanca
{
    class ContaPoupanca
    {
        private static double taxaDeJurosAnual;
        private double saldoPoupanca;
        
        public double CalcularJuromensal()
        {
            double jurosInterno;
            jurosInterno =  (this.saldoPoupanca * taxaDeJurosAnual) / 12;

            saldoPoupanca = jurosInterno;

            return saldoPoupanca;
        }

        public double AlterarTaxaDeJuros()
        {
            double taxaVariavel;
            double taxaFinal;

            taxaFinal = taxaDeJurosAnual * taxaVariavel;

            taxaDeJurosAnual = taxaFinal;

            return taxaDeJurosAnual;
        }
    }
}