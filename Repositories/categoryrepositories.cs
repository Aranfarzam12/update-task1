using task1.models;

namespace task1.Repositories
{
    public class categoryrepositories : icategoryrepositories
    {
        private readonly datacontext _context;

        public categoryrepositories(datacontext context)
        {
            _context = context;
        }

        public IEnumerable<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Categories GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Add(Categories cate)
        {
            _context.Categories.Add(cate);
        }

        public void Update(Categories cate)
        {
            _context.Categories.Update(cate);
        }

        public void Delete(int id)
        {
            var check = _context.Categories.Find(id);

            if (check != null)
            {
                _context.Categories.Remove(check);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
