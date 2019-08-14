﻿using Oqtane.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oqtane.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();

        Task<User> GetUserAsync(int UserId);

        Task<User> GetUserAsync(string Username);

        Task<User> AddUserAsync(User User);

        Task<User> UpdateUserAsync(User User);

        Task DeleteUserAsync(int UserId);

        Task<User> GetCurrentUserAsync();

        Task<User> LoginUserAsync(User User);

        Task LogoutUserAsync();

        bool IsAuthorized(User User, string AccessControlList);
    }
}