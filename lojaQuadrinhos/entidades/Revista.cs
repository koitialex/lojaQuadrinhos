using lojaQuadrinhos.enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaQuadrinhos
{
    public abstract class Revista
    {
        public TipoArteEnum Cor { get; set; }
        public double Preco { get; set; }
        public capaEnum Capa {  get; set; }
        public QuadrinhosEnum Marca { get; set; }

    };


}
