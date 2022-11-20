using System.ComponentModel.DataAnnotations;

namespace Emp.Manage.System.ViewModels
{   
    public class AddViewModel
    {
        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{3,20}")]
        public string FatherName { get; set; }
        [Required]

        public string FIN { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        

        public AddViewModel()
        {

        }
        public AddViewModel(string firstName, string lastName, string fatherName, string fIN, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            FIN = fIN;
            Email = email;
            
        }
    }
}
