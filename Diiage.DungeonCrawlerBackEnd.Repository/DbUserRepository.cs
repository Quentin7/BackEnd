using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Entity.Context;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Repository
{
    class DbUserRepository : IUserRepository
    {
        /// <summary>
        /// Allow to add a new user into the DB
        /// <param name="entity">user we want to add</param>
        public void Add(User entity)
        {
            using (var context = new DungeonCrawlerDbContext())
            {
                context.Set<User>().Add(entity);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Allow to add a list of new users
        /// </summary>
        /// <param name="entities">list of users we want to add</param>
        public void Add(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to delete an user
        /// </summary>
        /// <param name="id">id of the user we want to delete</param>
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to delete an user
        /// </summary>
        /// <param name="entityToDelete">user we want to delete</param>
        public void Delete(User entityToDelete)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow delete a list of users
        /// </summary>
        /// <param name="entities">list of users we want to delete</param>
        public void Delete(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to get all users
        /// </summary>
        /// <returns>list of all users</returns>
        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to get one user
        /// </summary>
        /// <param name="keyValues">id of the user we want</param>
        /// <returns>the user uwser we want</returns>
        public User GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to reset the password
        /// </summary>
        /// <param name="user">user we want to reset password</param>
        public void ResetPassword(User user, User newPassword)
        {
            using (var context = new DungeonCrawlerDbContext())
            {
                user.UserPasswordHash = newPassword.UserPasswordHash;
                user.UserPasswordSalt = newPassword.UserPasswordSalt;
                context.Update<User>(user);
                context.SaveChanges();
            }
        }

        public void ResetPassword(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to connect an user
        /// </summary>
        public void SignIn()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to disconnect an user
        /// </summary>
        public void SignOut()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to update user
        /// </summary>
        /// <param name="entity">user we want to update</param>
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allow to update users
        /// </summary>
        /// <param name="entities">list of users wa want to update</param>
        public void Update(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }
    }
}
