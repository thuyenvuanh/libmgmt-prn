using BusinessObject.Models;
using DataAccessObject;

namespace Repository;

public class BookRepository : IBookRepository
{
    public bool Delete(Book book) => BookDAO.Instance.Delete(book);

    public List<Book> GetAll() => BookDAO.Instance.Get().ToList();

    public Book? GetById(int id) => BookDAO.Instance.GetById(id);

    public Book Save(Book book) => BookDAO.Instance.Save(book);

    public List<Book> SearchByName(string keyword) => BookDAO.Instance.SearchByName(keyword);
}
