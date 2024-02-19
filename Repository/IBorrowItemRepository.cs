using BusinessObject.Models;

namespace Repository;

public interface IBorrowItemRepository
{
    List<BorrowItem> GetBorrowItemsByAccount(Account account, bool includeReturnedBooks = false);
    BorrowItem BorrowBook(BorrowItem borrowItem);
    BorrowItem? GetBorrowItemByAccountAndBook(int accountId, int bookId);
    BorrowItem ReturnBook(BorrowItem borrowItem);
}
