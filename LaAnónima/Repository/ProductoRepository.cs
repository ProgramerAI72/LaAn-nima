using LaAnonima.Data;
using LaAnónima.Models;

//prueba

namespace LaAnónima.Repository
{

    public class ProductoRepository
    {
        private readonly LaAnonimaContext _context;

        public ProductoRepository(LaAnonimaContext context)
        {
            _context = context;
        }

        public Producto ObtenerProducto(int productoId)
        {

            Producto Producto = _context
                    .Producto
                    .Where(ddd => ddd.Id == productoId)
                    .FirstOrDefault();

            productoId.EstanteriaId = _context.Producto
          .Where(elProducto => elProducto.Id == productoId.NombreProducto)
          .FirstOrDefault();

            return Producto;



        }

    }
}
