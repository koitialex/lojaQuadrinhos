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
        public Quadrinho(QuadrinhosEnum marca, )
        {
            Marca = marca;

        }
        public double CalcularPreco(double valor)
        {
            switch(Marca)
            {
                case QuadrinhosEnum.marvel:
                    valor = 20.50;
                    break;
                case QuadrinhosEnum.dc:
                    valor = 19.20;
                    break;
                case QuadrinhosEnum.blackhorse:
                    valor = 14.99;
                    break;
                
            }
            return;
        }
    }
}
