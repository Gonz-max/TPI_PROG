using CineBack.acceso_a_datos;
using CineBack.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.fachada
{
    public class DataApiImp : IDataApi
    {
        private IComprobanteDao dao;

        public DataApiImp()
        {
            dao = new ComprobanteDao();
        }

        public List<Entrada> GetEntradas()
        {
            return dao.GetEntradas();
        }

        public bool SaveComprobante(Comprobante comprobante)
        {
            return dao.Crear(comprobante);
        }

    }
}
