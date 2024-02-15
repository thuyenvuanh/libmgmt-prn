using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject;

public class BookDAO
{
    private readonly LibMgmtContext _dbContext = new();

    public static BookDAO Instance => Instance ?? new();

    private BookDAO() { }

    public DbSet<Book> Get() => _dbContext.Books;
}
