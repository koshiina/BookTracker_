using BookTracker_.Models;
using Microsoft.EntityFrameworkCore;
namespace BookTracker_.Data.Services
{
    public class AddBookService : IBookAddService
    {
        private readonly AppContextB _context;
        public AddBookService(AppContextB context)
        {
            _context = context;//privaciame kintamajame saugom aplikacijos konteksta
            //t.y. sasaja su duombaze
        }

        public async Task Add(Parameters parameters)
        {
            _context.Parameters.Add(parameters);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Parameters>> GetAll()
        {
            var books = await _context.Parameters.ToListAsync();
            return books;
        }

    }
}
