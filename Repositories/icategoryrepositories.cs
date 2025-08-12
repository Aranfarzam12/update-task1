using task1.models;

namespace task1.Repositories
{
    public interface icategoryrepositories
    {
        IEnumerable<Categories> GetAll();
        Categories GetById(int id);
        void Add(Categories cate);
        void Update(Categories cate);
        void Delete(int id);
        void Save();
    }
}
