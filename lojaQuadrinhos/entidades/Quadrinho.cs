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

        public Quadrinho(QuadrinhosEnum marca,capaEnum capa, TipoArteEnum arte)
        {
            Marca = marca;
            Capa = capa;
            Arte = arte;

            PrecoCapa = ValorCapa();
            PrecoCor = ValorColorido();
            Marca = CalcularPreco();
            Preco = PrecoCapa + PrecoCor + Marca;



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
        public double ValorColorido()
        {
            double precoCor = 0;
            switch(Arte)
            {
                case TipoArteEnum.Colorido:
                    precoCor = 7.00;
                    break;
                case TipoArteEnum.PretoeBranco:
                    precoCor = 2.50;
                    break;
            }
            return precoCor;
        }
        public double CalcularPreco()
        {
            double precoMarca = 0;
            switch(Marca)
            {
                case QuadrinhosEnum.marvel:
                    precoMarca = 3.70;
                    break;
                case QuadrinhosEnum.dc:
                    precoMarca = 3.70;
                    break;
                case QuadrinhosEnum.blackhorse:
                    precoMarca = 1.99;
                    break;
                
            }
            return precoMarca;
        }
        
    }
}
