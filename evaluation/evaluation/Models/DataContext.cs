using System.Data.Entity;

namespace evaluation.Models
{
    public class DataContext :DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}