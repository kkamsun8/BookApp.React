using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApp.Shared
{
    public interface IBookRepository : IBookCrudRepository<Book>
    {
        
    }
}
