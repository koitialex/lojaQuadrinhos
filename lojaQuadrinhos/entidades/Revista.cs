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
        public capaEnum Capa { get; set; }              
        public TipoArteEnum Arte { get; set; }
        public double PrecoCapa { get; set; }
        public double PrecoCor { get; set; }
        public double PrecoMarca { get; set; }
        public double Preco { get; set; }
    
        public QuadrinhosEnum Marca { get; set; }

    };


}
