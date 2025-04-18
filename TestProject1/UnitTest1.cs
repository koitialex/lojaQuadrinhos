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
            Quadrinho quadrinho = new Quadrinho(QuadrinhosEnum.marvel,capaEnum.Dura, TipoArteEnum.Colorido);
            double precoFinal = quadrinho.PrecoCapa + quadrinho.PrecoCor  + quadrinho.PrecoMarca + precoproduto;
            Assert.Equal(, precoFinal);

        }
    }
}