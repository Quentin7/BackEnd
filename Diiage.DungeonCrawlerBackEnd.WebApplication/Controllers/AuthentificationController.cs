using Diiage.DungeonCrawlerBackEnd.Business.Contracts;
using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.WebApplication.Configuration;
using Diiage.DungeonCrawlerBackEnd.WebApplication.Models.DTO.Requests;
using Diiage.DungeonCrawlerBackEnd.WebApplication.Models.DTO.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Controllers
{
    public class AuthentificationController : Controller
    {
        readonly private IAuthentificationService _authentificationService;
        readonly private JwtConfig _jwtConfig;

        public AuthentificationController( IAuthentificationService authentificationService, JwtConfig jwtConfig)
        {
            _authentificationService = authentificationService;
            _jwtConfig = jwtConfig;
        }

        /// <summary>
        /// Allow to register a new user
        /// </summary>
        /// <param name="user">user we want to register</param>
        [HttpPost]
        [Route("register")]
        public RegistrationResponse Register(User user)
        {
            if (this.ModelState.IsValid)
            {
                if (_authentificationService.VerificationEMail(user.UserEMail) != new User())//wik
                {
                    _authentificationService.Register(user);


                    //_authentificationService.SignIn();
                    GenerateJwtToken(user);


                    return new RegistrationResponse()
                    {
                        Result = true,

                    };

                }
                else
                {
                    return new RegistrationResponse()
                    {
                        Result = false,
                        Errors = new List<string>() 
                        { 
                            "Email already exist"
                        }
                    };
                }
            }
            return new RegistrationResponse()
            {
                Result = false,
                Errors = new List<string>()
                        {
                            "Model invalid"
                        }
            };


        }

        /// <summary>
        /// Allow to connect an user
        /// </summary>
        [HttpPost]
        public void SignIn()
        {
            _authentificationService.SignIn();
        }
        
        /// <summary>
        /// Allow to disconnect an user
        /// </summary>
        [HttpPost]
        public void Disconnect()
        {
            _authentificationService.SignOut();
        }

        /// <summary>
        /// Allow to reset the password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPassword"></param>
        [HttpPost]
        public void ResetPassord(User user, User newPassword)
        {
            _authentificationService.ResetPassword(user, newPassword);
        }

        private string GenerateJwtToken(User user)
        {
            var identityUser = new IdentityUser()
            {
                Email = user.UserEMail,
            };

            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor() 
            {
                Subject = new ClaimsIdentity(new[] 
                {
                    new Claim(JwtRegisteredClaimNames.Sub, identityUser.Email),
                    new Claim(JwtRegisteredClaimNames.Email, identityUser.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(4),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)

            };


            var token = jwtTokenHandler.CreateToken(tokenDescriptor);

            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }


    }
}
