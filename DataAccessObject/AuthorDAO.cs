using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject;

public class AuthorDAO
{
    private readonly LibMgmtContext _dbContext = new();
    public static AuthorDAO Instance => Instance ?? new();
    private AuthorDAO() { }

    public DbSet<Author> Get() => _dbContext.Authors;
}
