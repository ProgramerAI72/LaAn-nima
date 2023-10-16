using LaAnonima.Data;
using LaAnónima.Models;

namespace LaAnónima.Repository
{
    public class PasilloRepository
    {

        public int CrearPasillo(Pasillo pasillo) 
        {
            Pasillo.Add(pasillo);
            

            return pasillo;
        }
        
    }
}
