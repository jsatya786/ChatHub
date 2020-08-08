using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chatter.Models
{
    public class Message
    {
        public Message() {
            When = DateTime.Now;
        }
        public int Id { get; set; }
        [Required]
        public string UserName{set;get;}
        [Required]
        public string Text { set; get; }
        public DateTime When { set; get; }

        public string UserId { get; set; }
        public virtual AppUser Sender { set; get; }
    }
}
