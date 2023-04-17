namespace Jolly.Repositories;

public class PasswordsRepository
{
    private readonly IDbConnection _db;

    public PasswordsRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Password> GetAll()
    {
        string sql = @"
        SELECT
        *
        FROM passwords;
        ";
        List<Password> passwords = _db.Query<Password>(sql).ToList();
        return passwords;
    }
}