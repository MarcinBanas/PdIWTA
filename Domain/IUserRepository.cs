using System;
using System.Collections.Generic;

namespace PdiwtA
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Save(User user);
    }
}
