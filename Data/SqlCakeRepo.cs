using System;
using System.Collections.Generic;
using System.Linq;
using Cake.Models;

namespace Cake.Data
{
    public class SqlCakeRepo : ICakeRepo
    {
        private readonly CakeContext _context;

        public SqlCakeRepo(CakeContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.Users.Remove(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        void ICakeRepo.UpdateUser(User user)
        {

        }
    }
}
