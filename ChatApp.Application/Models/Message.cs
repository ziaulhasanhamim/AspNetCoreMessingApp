using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Models
{
    public class Message
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int FromId { get; set; }
        [Required]
        [ForeignKey("FromId")]
        public User From { get; set; }
        [Required]
        public int ToId { get; set; }
        [Required]
        [ForeignKey("ToId")]
        public User To { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
