using LaAnonima.Data;
using LaAnónima.Models;

namespace LaAnónima.Repository
{

    public class ProductoRepository
    {
        private readonly LaAnonimaContext _context;

        public ProductoRepository(LaAnonimaContext context)
        {
            _context = context;
        }

        //public Producto ObtenerProducto(string NombreDelProducto)
        //{

        //    Producto NombreDelProducto = _context
        //            .Producto
        //            .Where(ddd => ddd.Id == NombreDelProducto)
        //            .FirstOrDefault();

        //    NombreDelProducto.EstanteriaId = _context.Producto
        //  .Where(elProducto => elProducto.Id == NombreDelProducto.NombreProducto)
        //  .FirstOrDefault();

        //    return NombreDelProducto;



        //}

    }
}
