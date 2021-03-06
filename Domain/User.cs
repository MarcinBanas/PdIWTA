using PdiwtA;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PdiwtA
{
    public class User
    {
        public User()
        {

        }

        public User(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }

        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
}



    public class UsersInMemoryRepository : IUserRepository
    {
    private readonly List<User> _users = new List<User>
        {
            new User("1@mail.com", "123456789"),
            new User("2@mail.com", "333333333"),

        };

        public List<User> GetAll()
        {
            return _users;
        }


        public User Save(User user)
        {
            _users.Add(user);
            return user;
        }

    List<User> IUserRepository.GetAll()
    {
        throw new System.NotImplementedException();
    }

    
}

