using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject;

public class AuthorDAO
{
    private readonly LibMgmtContext _dbContext = new();

    private static AuthorDAO _instance;

    public static AuthorDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AuthorDAO();
            }
            return _instance;
        }
    }
    private AuthorDAO() { }

    public DbSet<Author> Get() => _dbContext.Authors;
}
