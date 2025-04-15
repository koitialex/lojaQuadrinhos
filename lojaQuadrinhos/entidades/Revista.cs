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
        public string franquia { get; set; }
        public double valor { get; set; }
        public bool capa {  get; set; }
        public QuadrinhosEnum Marca { get; set; }

    };


}
