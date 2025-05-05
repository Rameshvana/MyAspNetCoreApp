namespace MvcAdo.Net_Projct1.Models.Student
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public int Fees { get; set; }

        public string Address { get; set; }
        public Student() { }
    }
}
