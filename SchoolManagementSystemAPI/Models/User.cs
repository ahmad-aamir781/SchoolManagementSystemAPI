﻿namespace SchoolManagementSystemAPI.Models
{
    public class User
   {

        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword{ get; set; }
        public string? PhoneNumber{ get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }
        public string? Token { get; set; }

    }
}
