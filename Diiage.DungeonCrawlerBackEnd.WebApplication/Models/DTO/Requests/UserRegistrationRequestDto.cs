﻿using System.ComponentModel.DataAnnotations;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Models.DTO.Requests
{
    public class UserRegistrationRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; } //to be a suivre...
    }
}
