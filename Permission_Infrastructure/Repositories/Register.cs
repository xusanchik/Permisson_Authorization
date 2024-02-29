﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Permission_Application.Abstractions.Repositories;
using Permission_Application.Dto_s;
using Permission_Domen.Entityes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Permission_Infrastructure.Repositories
{
    public class Register : IRegister
    {
        private readonly AppDbContext _appDbContext;
        public Register(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Permission_Domen.Entityes.User> Registration(RegisterDTO registerDTO)
        {
            var newuser = new User();
            newuser.Name = registerDTO.Name;
            newuser.Email = registerDTO.Email;
            newuser.Password = registerDTO.Password;
            newuser.ERole = registerDTO.ERole;
            newuser.Price = registerDTO.Price;
            newuser.CreatedAt = DateTime.UtcNow;

            await _appDbContext.AddAsync(newuser);
            await _appDbContext.SaveChangesAsync();
            return newuser;
        }
    }
}
