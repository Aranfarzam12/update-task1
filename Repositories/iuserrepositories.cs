using task1.models;

namespace task1.Repositories
{
    public interface iuserrepositories
    {
        IEnumerable<Users> GetAll();
        Users GetById(int id);
        void Add(Users user);
        void Update(Users user);
        void Delete(int id);
        void Save();
    }
}
