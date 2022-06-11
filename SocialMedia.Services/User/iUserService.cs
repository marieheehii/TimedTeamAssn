using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface iUserService
    {
        Task<bool> RegisterUserAsync(UserRegister model);
        Task<UserDetail> GetUserByIDAsync(int userId);

    }