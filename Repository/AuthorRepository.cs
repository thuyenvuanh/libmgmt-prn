using BusinessObject.Models;
using DataAccessObject;

namespace Repository;

public class AuthorRepository : IAuthorRepository
{
    public List<Author> GetAll() => AuthorDAO.Instance.Get();

    public Author? GetById(int id) => AuthorDAO.Instance.GetById(id);

    public List<Author> SearchAuthors(string keyword) => AuthorDAO.Instance.SearchAuthors(keyword);
}
