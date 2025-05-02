using System.Collections.Generic;
using System.Diagnostics;

namespace MvcAppication_pr1.Models
{
    static class PersonRepo
    {
        public static List<Person> PersonsList { get; set; }

        static PersonRepo()
        {
            PersonsList = new List<Person>
            {
                new Person(1,"Ramesh", "Kumar", "ramesh@gmail.com", 97007666, "Hyderabad", 20, "Software Engineer"),
                new Person(2,"Sita", "Kumar", "sita.kumar@example.com", 98451234, "Bangalore", 22, "Designer"),
                new Person(3,"Arjun", "Verma", "arjun.verma@example.com", 91234567, "Delhi", 25, "Data Analyst")
            };
        }

        public static void AddPerson(Person newPerson)
        {
            Debug.WriteLine(newPerson);
            if (newPerson != null)
            {
                newPerson.Id = (PersonsList.LastOrDefault()?.Id ?? 0) + 1;

                PersonsList.Add(newPerson);
            }
        }

        public static void DeletePerson(int id)
        {
            var person = PersonsList.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                PersonsList.Remove(person);
            }
        }

        public static void UpdatePerson(Person updatePerson)

        {

            var existingPerson = PersonsList.FirstOrDefault(p => p.Id == updatePerson.Id);

            if (existingPerson != null)
            {
               
                existingPerson.FirstName = updatePerson.FirstName;
                existingPerson.LastName = updatePerson.LastName;
                existingPerson.Email = updatePerson.Email;
                existingPerson.MobileNo = updatePerson.MobileNo;
                existingPerson.Address = updatePerson.Address;
                existingPerson.Age = updatePerson.Age;
                existingPerson.Occupation = updatePerson.Occupation;
            }
            
            
        }


    }
}
