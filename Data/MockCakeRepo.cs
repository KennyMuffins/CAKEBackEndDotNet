using System.Collections.Generic;
using Cake.Models;

namespace Cake.Data
{
    public class MockCakeRepo : ICakeRepo
    {
        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    Id = 0,
                    UserName = "Kenny",
                    Password = "Password",
                    DisplayName = "Kenny",
                    MobileNumber = "12345678",
                    Email = "Kenny@gmail.com",
                    ProfilePicUrl = "MyPic.jpg"
                }
            };

            return users;
        }

        public User GetUserById(int id)
        {
            return new User
            {
                Id = 0,
                UserName = "Kenny",
                Password = "Password",
                DisplayName = "Kenny",
                MobileNumber = "12345678",
                Email = "Kenny@gmail.com",
                ProfilePicUrl = "MyPic.jpg"
            };
        }

        void ICakeRepo.CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        void ICakeRepo.DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<User> ICakeRepo.GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        User ICakeRepo.GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        bool ICakeRepo.SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        void ICakeRepo.UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}