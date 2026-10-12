using BookTracker_.Models;
namespace BookTracker_.Data.Services
{
    public interface IBookAddService
    {
        Task<IEnumerable<Parameters>> GetAll();
        Task AddBook(Parameters parameters);

    }
}
