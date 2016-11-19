using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JQueryValidation.Models
{
    public class RsvpResponse
    {
        [Required(ErrorMessage= "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        [RegularExpression(@"^\S@\S+$", ErrorMessage = "The email is not in the proper format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your favorite game.")]
        public string FavoriteGame { get; set; }
        [Required(ErrorMessage = "Please specify if you will attend.")]
        public bool? WillAttend { get; set; }
    }
}