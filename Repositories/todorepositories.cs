using task1.models;

namespace task1.Repositories
{
    public class todorepositories : itodorepositories
    {
        private readonly datacontext _context;

        public todorepositories(datacontext context)
        {
            _context = context;
        }

        public IEnumerable<ToDo> GetAll()
        {
            return _context.ToDos.ToList();
        }

        public ToDo GetById(int id)
        {
           return  _context.ToDos.Find(id);
        }

        public void Add(ToDo todo)
        {
            _context.ToDos.Add(todo);
        }

        public void Update(ToDo todo)
        {
            _context.ToDos.Update(todo);
        }

        public void Delete(int id)
        {
            var check = _context.ToDos.Find(id);

            if (check != null)
            {
                _context.ToDos.Remove(check);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
