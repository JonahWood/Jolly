namespace Jolly.Services
{
    public class PasswordsService
    {
        private readonly PasswordsRepository _repo;

        public PasswordsService(PasswordsRepository repo)
        {
            _repo = repo;
        }

        internal Password Find()
        {
            Password password = _repo.Find();
            return password;
        }
    }
}