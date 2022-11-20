using System.ComponentModel.DataAnnotations;

namespace Emp.Manage.System.ViewModels
{
    public class UpdateViewModel
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
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

     

        public UpdateViewModel(string firstName, string lastName, string fatherName, string fin, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            Email = email;
           
         


        }





    }
}
