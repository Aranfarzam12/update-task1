using task1.models;

namespace task1.Repositories
{
    public interface itodorepositories
    {
        IEnumerable<ToDo> GetAll();
        ToDo GetById(int id);
        void Add(ToDo todo);
        void Update(ToDo todo);
        void Delete(int id);
        void Save();
    }
}
