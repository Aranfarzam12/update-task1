using System;
using task1.models;

namespace task1.Repositories
{
    public class userrepositories : iuserrepositories
    {
        private readonly datacontext _context;

        public userrepositories(datacontext context)
        {
            _context = context;
        }

        public IEnumerable<Users> GetAll()
        {
            return _context.Users.ToList();
        }

        public Users GetById(int id)
        {
            return _context.Users.Find(id);

            
        }

        public void Add(Users user)
        {
            _context.Users.Add(user);
        }

        public void Update(Users user)
        {
            _context.Users.Update(user);
        }

        public void Delete(int id)
        {
            var check = _context.Users.Find(id);

            if (check != null)
            {
                _context.Users.Remove(check);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
