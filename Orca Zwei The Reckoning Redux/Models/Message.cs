using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Orca_Zwei_The_Reckoning_Redux.Models
{
    public class Message
    {
        [Required]
        public int MessageID { get; set; }

        [Required]
        public string SentFrom { get; set; }
        [Required]
        [Display(Name="To:")]
        public string SentTo { get; set; }

        [Display(Name = "Subject:")]
        public string Subject { get; set; }
        [Display(Name = "Message:")]
        public string MessageSent { get; set; }

        public bool Read { get; set; }
        public DateTime Sent { get; set; }

    }
}