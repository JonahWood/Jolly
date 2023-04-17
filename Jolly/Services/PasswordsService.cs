namespace Jolly.Services;

public class PasswordsService{
private readonly PasswordsRepository _repo;

    public PasswordsService(PasswordsRepository repo)
    {
        _repo = repo;
    }

    internal List<Password> GetAll()
    {
        List<Password> passwords = _repo.GetAll();
        return passwords;
    }
}