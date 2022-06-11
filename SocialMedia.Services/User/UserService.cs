using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class UserService : iUserService
{
    public Task<UserDetail> GetUserByIDAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RegisterUserAsync(UserRegister model)
    {
        throw new NotImplementedException();
    }
}
