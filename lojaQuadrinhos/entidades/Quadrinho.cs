using lojaQuadrinhos.enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaQuadrinhos.entidades
{
    public class Quadrinho : Revista
    {

        public Quadrinho(QuadrinhosEnum marca,capaEnum capa, TipoArteEnum cor)
        {
            Marca = marca;

            PrecoCapa = ValorCapa();
            ValorColorido();
            Preco = PrecoCapa + PrecoCor + CalcularPreco(Marca);

        }
        public double ValorCapa()
        {
            double precoCapa = 0;
            switch (Capa)
            {
                case capaEnum.Dura:
                    precoCapa = 10.00;
                    break;
                case capaEnum.paperback:
                    precoCapa = 4.00;
                    break;
                case capaEnum.Sobrecapa:
                    precoCapa = 3.00;
                    break;

            }
            return precoCapa;
        }
        public void ValorColorido()
        {
            switch(Arte)
            {
                case TipoArteEnum.Colorido:
                    PrecoCor = 7.00;
                    break;
                case TipoArteEnum.PretoeBranco:
                    PrecoCor = 2.50;
                    break;
            }
        }
        public double CalcularPreco(double preco)
        {
            switch(Marca)
            {
                case QuadrinhosEnum.marvel:
                    preco = 3.70;
                    break;
                case QuadrinhosEnum.dc:
                    preco = 3.70;
                    break;
                case QuadrinhosEnum.blackhorse:
                    preco = 1.99;
                    break;
                
            }
            return preco;
        }
        
    }
}
