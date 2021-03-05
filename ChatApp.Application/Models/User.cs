using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [InverseProperty("To")]
        [JsonIgnore]
        public List<Message> ReceivedMessages { get; set; }
        [InverseProperty("From")]
        [JsonIgnore]
        public List<Message> SentMessages { get; set; }
    }
}
