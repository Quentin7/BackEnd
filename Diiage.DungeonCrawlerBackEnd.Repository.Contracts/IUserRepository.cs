﻿using Diiage.DungeonCrawlerBackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Repository.Contract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void SignIn();
        void SignOut();
        void ResetPassword(User user, User newPassword);
    }
}