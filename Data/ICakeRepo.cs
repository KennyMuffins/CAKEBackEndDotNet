using System.Collections.Generic;
using Cake.Models;

namespace Cake.Data
{
    public interface ICakeRepo
    {
        bool SaveChanges();
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}