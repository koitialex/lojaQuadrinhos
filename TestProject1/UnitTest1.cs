using lojaQuadrinhos;
using lojaQuadrinhos.entidades;
using lojaQuadrinhos.enumeradores;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestarPrecoQuadrinho_Fact()
        {
            double precoproduto = 5;
            Quadrinho quadrinho = new Quadrinho(QuadrinhosEnum.marvel, capaEnum.Dura, TipoArteEnum.Colorido);
            double precoFinal = quadrinho.PrecoCapa + quadrinho.PrecoCor + quadrinho.PrecoMarca + precoproduto;
            Assert.Equal(25.7, precoFinal);

        }
        [Fact]
        public void TestarPrecoManga_Fact()
        {
            double precoproduto = 3;
            Manga manga = new Manga(MangaEnum.SousouNoFrieren, capaEnum.paperback, TipoArteEnum.PretoeBranco);
            double precoFinal = manga.PrecoCapa + manga.PrecoCor + manga.PrecoMarca + precoproduto;
            Assert.Equal(14.9, precoFinal);

        }
        [Fact]
        public void TestarPrecoLivro_Fact()
        {
            double precoproduto = 3;
            Livro livro = new Livro(LivroEnum.HungerGames, capaEnum.Dura, TipoArteEnum.PretoeBranco);
            double precoFinal = livro.PrecoCapa + livro.PrecoCor + livro.PrecoMarca + precoproduto;
            Assert.Equal(28.4, precoFinal);

        }
        [Theory]
        [InlineData(QuadrinhosEnum.marvel, capaEnum.Dura, TipoArteEnum.Colorido, 5, 25.7)]
        [InlineData(QuadrinhosEnum.dc, capaEnum.paperback, TipoArteEnum.PretoeBranco, 3, 13.2)]
        [InlineData(QuadrinhosEnum.blackhorse, capaEnum.Sobrecapa, TipoArteEnum.Colorido, 2, 13.99)]
        public void TestarPrecoQuadrinho_Theory(QuadrinhosEnum marca, capaEnum capa, TipoArteEnum arte, double precoProduto, double precoEsperado)
        {
            var quadrinho = new Quadrinho(marca, capa, arte);

            var precoFinal = quadrinho.PrecoCapa + quadrinho.PrecoCor + quadrinho.PrecoMarca + precoProduto;

            Assert.Equal(precoEsperado, precoFinal, precision: 2);
        }
        
        [Theory]
        [InlineData(MangaEnum.FullMetalAlchemist, capaEnum.Dura, TipoArteEnum.Colorido, 5, 25.4)]
        [InlineData(MangaEnum.SousouNoFrieren, capaEnum.paperback, TipoArteEnum.PretoeBranco, 3, 14.9)]
        [InlineData(MangaEnum.ShingekiNoKyojin, capaEnum.Sobrecapa, TipoArteEnum.Colorido, 2, 16.0)]
        public void TestarPrecoManga_Theory(MangaEnum marca, capaEnum capa, TipoArteEnum arte, double precoProduto, double precoEsperado)
        {
            var manga = new Manga(marca, capa, arte);

            var precoFinal = manga.PrecoCapa + manga.PrecoCor + manga.PrecoMarca + precoProduto;

            Assert.Equal(precoEsperado, precoFinal, precision: 2);
        }
        [Theory]
        [InlineData(LivroEnum.PercyJackson, capaEnum.Dura, TipoArteEnum.Colorido, 5, 37.0)]
        [InlineData(LivroEnum.HungerGames, capaEnum.paperback, TipoArteEnum.PretoeBranco, 3, 21.4)]
        [InlineData(LivroEnum.Narnia, capaEnum.Sobrecapa, TipoArteEnum.Colorido, 2, 24.5)]
        public void TestarPrecoLivro_Theory(LivroEnum marca, capaEnum capa, TipoArteEnum arte, double precoProduto, double precoEsperado)
        {
            var livro = new Livro(marca, capa, arte);

            var precoFinal = livro.PrecoCapa + livro.PrecoCor + livro.PrecoMarca + precoProduto;

            Assert.Equal(precoEsperado, precoFinal, precision: 2);
        }

    }
}