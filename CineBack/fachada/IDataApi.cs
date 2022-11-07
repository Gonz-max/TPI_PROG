using CineBack.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.fachada
{
    public interface IDataApi
    {
        public List<Entrada> GetEntradas();

        public bool SaveComprobante(Comprobante comprobante);

    }
}
