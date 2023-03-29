namespace Jolly.Repositories
{
    public class PasswordsRepository
    {
        private readonly IDbConnection _db;

        public PasswordsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Password Find()
        {
            string sql = @"
            SELECT * FROM passwords;
            ";
            List<Password> passwords = _db.Execute(sql);
            return passwords;
        }
    }
}