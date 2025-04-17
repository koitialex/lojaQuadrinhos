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
            return Capa switch
            {
                capaEnum.Dura => 9.50,
                capaEnum.paperback => 3.50,
                capaEnum.Sobrecapa => 2.00,

            };
        }

        private double CalcularPrecoArte()
        {
            return Arte switch
            {
                TipoArteEnum.Colorido => 6.00,
                TipoArteEnum.PretoeBranco => 3.00,

            };
        }

        private double CalcularPrecoTitulo()
        {
            return Titulo switch
            {
                MangaEnum.FullMetalAlchemist => 4.90,
                MangaEnum.SousouNoFrieren => 5.40,
                MangaEnum.ShingekiNoKyojin => 6.00,

            };
        }

    }
}

