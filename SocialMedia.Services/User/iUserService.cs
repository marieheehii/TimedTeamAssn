using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface IUserService
    {
        Task<bool> RegisterUserAsync(UserRegister model);

    }