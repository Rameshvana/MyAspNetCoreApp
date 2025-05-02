using Microsoft.EntityFrameworkCore;

namespace MvcAppication_pr1.Models
{
    public class Person
    {
        public int Id { get; set; }            
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string Email { get; set; }
        public long MobileNo { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }


        public Person() {
            
        }
        public Person(int id,string firstName, string lastName, string email, long mobileNo, string address, int age, string occupation)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            MobileNo = mobileNo;
            Address = address;
            Age = age;
            Occupation = occupation;
           
        }
    }
}
