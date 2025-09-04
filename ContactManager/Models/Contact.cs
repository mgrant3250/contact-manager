using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        //The Contact tables primary key is ContactId and its foreign key is CategoryId
        public int ContactId {  get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an Email.")]
        public string Email {  get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage ="Please select a category")]
        public int CategoryId {  get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        public DateTime DateAdded { get; set; } = DateTime.Now;

        //slug for route adds the first name in lowercase with a dash and then the last name in lowercase
        public string Slug => FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
