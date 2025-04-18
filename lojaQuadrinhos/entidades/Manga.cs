using lojaQuadrinhos.enumeradores;

namespace lojaQuadrinhos
{
    public class Manga : Revista
    {
        public MangaEnum Titulo { get; set; }

        public Manga(MangaEnum titulo, capaEnum capa, TipoArteEnum arte)
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
            double precoCapa = 0;
            switch (Capa)
            {
                case capaEnum.Dura:
                    precoCapa = 9.50;
                    break;
                case capaEnum.paperback:
                    precoCapa = 3.50;
                    break;
                case capaEnum.Sobrecapa:
                    precoCapa = 2.00;
                    break;
            }
            return precoCapa;
        }

        private double CalcularPrecoArte()
        {
            double precoArte = 0;
            switch (Arte)
            {
                case TipoArteEnum.Colorido:
                    precoArte = 6.00;
                    break;
                case TipoArteEnum.PretoeBranco:
                    precoArte = 3.00;
                    break;
            }
            return precoArte;
        }

        private double CalcularPrecoTitulo()
        {
            double precoTitulo = 0;
            switch (Titulo)
            {
                case MangaEnum.FullMetalAlchemist:
                    precoTitulo = 4.90;
                    break;
                case MangaEnum.SousouNoFrieren:
                    precoTitulo = 5.40;
                    break;
                case MangaEnum.ShingekiNoKyojin:
                    precoTitulo = 6.00;
                    break;
            }
            return precoTitulo;
        }

    }
}

