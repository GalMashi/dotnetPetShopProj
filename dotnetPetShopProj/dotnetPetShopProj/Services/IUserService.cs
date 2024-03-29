﻿using dotnetPetShopProj.Entities;

namespace dotnetPetShopProj.Services
{
    public interface IUserService
    {
        
    Task<User> Authenticate(string username, string password);
    Task<IEnumerable<User>> GetAll();
    }
}
