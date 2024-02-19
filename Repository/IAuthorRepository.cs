using BusinessObject.Models;

namespace Repository;

public interface IAuthorRepository
{
    List<Author> GetAll();
    Author? GetById(int id);
    List<Author> SearchAuthors(string keyword);
}
