using BusinessObject.Models;

namespace Repository;

public interface IBookRepository
{
    List<Book> GetAll();
    List<Book> SearchByName(string keyword);
    Book? GetById(int id);
    bool Delete(Book book);
    Book Save(Book book);
}
