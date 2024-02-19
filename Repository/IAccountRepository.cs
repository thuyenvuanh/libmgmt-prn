using BusinessObject;
using BusinessObject.Models;

namespace Repository;

public interface IAccountRepository
{
    List<Account> GetAll();
    List<Account> GetAllByRole(ERole role);
    Account? GetByEmail(string email);
    Account? GetByID(int id);
    Account SaveAccount(Account account);
    bool Login(string email, string password);
    bool Delete(Account account);
    List<Account> SearchByEmail(string email);
}
