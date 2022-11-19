namespace Emp.Manage.System.ViewModels
{
    public class ListViewModel
    {

        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }

        public ListViewModel(string employeeCode, string firstName, string lastName, string fatherName)
        {
            EmployeeCode = employeeCode;
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
        }
    }
}
