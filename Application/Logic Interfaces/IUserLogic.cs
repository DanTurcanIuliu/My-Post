﻿using Shared.DTOs;
using Shared.Models;

namespace Application.Logic_Interfaces;

public interface IUserLogic
{
    Task<User> CreateAsync(UserCreationDto userToCreate); //RegisterUser
    Task<User> ValidateUser(string username, string password);

}