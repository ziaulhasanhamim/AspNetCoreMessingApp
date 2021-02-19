﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Models
{
    public class User : IdentityUser<int>
    {
        [Required]
        public string ProfileImage { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FulName 
        { 
            get
            {
                return FirstName + " " +LastName;
            }
        }
    }
}