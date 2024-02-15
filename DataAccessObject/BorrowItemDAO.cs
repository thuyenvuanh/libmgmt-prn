using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject;

public class BorrowItemDAO
{
    private readonly LibMgmtContext _dbContext = new();

    public static BorrowItemDAO Instance => Instance ?? new();

    private BorrowItemDAO() { }

    public DbSet<BorrowItem> Get() => _dbContext.BorrowItems;
}
