﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.Json;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        //string path = "M:/API/API/wwwroot/users.txt";
        private readonly Manager326239886Context _managerContext;
        public UserRepository(Manager326239886Context managerContext)
        {
            _managerContext = managerContext;
        }

        public async Task<User> addUser(User user)
        {
            await _managerContext.Users.AddAsync(user);
            await _managerContext.SaveChangesAsync();
            return user;

        }
        public async Task<User> getUser(string userName, string password)
        {
            User foundUser = await _managerContext.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync();
            if(foundUser.Password==password)
            {
                return foundUser;
            }
            return null;
        }

        public async Task<User> editUser(User userToUpdate)
        {
             _managerContext.Users.Update(userToUpdate);
             await _managerContext.SaveChangesAsync();
            return userToUpdate;

        }


    }
}