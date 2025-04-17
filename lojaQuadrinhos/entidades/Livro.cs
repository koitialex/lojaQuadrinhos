using lojaQuadrinhos.enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaQuadrinhos
{
    public class Livro : Revista
    {
        public LivroEnum Titulo { get; set; }

        public Livro(LivroEnum titulo, capaEnum capa, TipoArteEnum arte)
        {
            Titulo = titulo;
            Capa = capa;
            Arte = arte;

            PrecoCapa = CalcularPrecoCapa();
            PrecoCor = CalcularPrecoArte();
            Preco = PrecoCapa + PrecoCor + CalcularPrecoTitulo();
        }

        private double CalcularPrecoCapa()
        {
            double precoCapa = 0; //aqui é obrigado atribuir algum valor se não ele não aceita
            switch(Capa)
            {

                case capaEnum.Dura:
                    precoCapa = 12.00;
                    break;
                case capaEnum.paperback:
                    precoCapa = 5.00;
                    break;
                case capaEnum.Sobrecapa:
                    precoCapa = 3.50;
                    break;
            };
            return precoCapa;
        }

        private double CalcularPrecoArte()
        {
            double precoArte = 0;
            switch(Arte)
            {
                case TipoArteEnum.Colorido:
                    precoArte = 8.00;
                    break;
                case TipoArteEnum.PretoeBranco:
                    precoArte = 4.00;
                    break;
            };
            return precoArte;
        }

        private double CalcularPrecoTitulo()
        {
            double precoTitulo = 0;
            switch(Titulo)
            {
                case LivroEnum.PercyJackson:
                    precoTitulo = 12.00;
                    break;
                case LivroEnum.HungerGames:
                    precoTitulo = 9.40;
                    break;
                case LivroEnum.Narnia:
                    precoTitulo = 11.00;
                    break;
            };
            return precoTitulo;
        }
    }
}
