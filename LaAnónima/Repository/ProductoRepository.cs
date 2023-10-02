using LaAnónima.Models;

namespace LaAnónima.Repository
{
    public class ProductoRepository
    {
        public Producto ObtenerProducto(string NombreDelProducto) 
        {
           
        Producto NombreDelProducto = _context
                .Producto
                .Where(ddd => ddd.Id == NombreDelProducto)
                .FirstOrDefault();

            NombreDelProducto.EstanteriaId = _context.Producto
          .Where(elProducto => elProducto.Id == NombreDelProducto.NombreProducto)
          .FirstOrDefault();

            return NombreDelProducto;



        }

    }
}
