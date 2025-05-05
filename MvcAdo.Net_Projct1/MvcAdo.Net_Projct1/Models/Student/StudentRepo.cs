using Microsoft.Data.SqlClient;

namespace MvcAdo.Net_Projct1.Models.Student
{
    public class StudentRepo
    {
        private readonly string _connectionString;
        public StudentRepo(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Student> GetStudents()
        {
            List<Student> students_List = new();
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("select * from Students", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    students_List.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Age = (int)reader["Age"],
                        Course = reader["Course"].ToString(),
                        Fees = (int)reader["Fees"],
                        Address = reader["Address"].ToString()
                    });
                }
            }

            return students_List;
        }

        public string AddStudent(Student data)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Students (FirstName,LastName, Email, Age,Course,Fees,Address) VALUES (@FirstName,@LastName,@Email,@Age,@Course,@Fees,@Address)", conn);
                cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                cmd.Parameters.AddWithValue("@LastName", data.LastName);
                cmd.Parameters.AddWithValue("@Email", data.Email);
                cmd.Parameters.AddWithValue("@Age", data.Age);
                cmd.Parameters.AddWithValue("@Course", data.Course);
                cmd.Parameters.AddWithValue("@Fees", data.Fees);
                cmd.Parameters.AddWithValue("@Address", data.Address);
               
                cmd.ExecuteNonQuery();

            }

            return "Student Adedd Successfully..!";
        }

        public String UpdateStudent(Student data)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("UPDATE Students SET  FirstName = @FirstName, LastName = @LastName, Course = @Course,Fees = @Fees, Address = @Address, Email = @Email, Age = @Age WHERE Id = @Id",conn);
                cmd.Parameters.AddWithValue("@Id", data.Id);
                cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                cmd.Parameters.AddWithValue("@LastName", data.LastName);
                cmd.Parameters.AddWithValue("@Course", data.Course);
                cmd.Parameters.AddWithValue("@Fees", data.Fees);
                cmd.Parameters.AddWithValue("@Age", data.Age);
                cmd.Parameters.AddWithValue("@Address", data.Address);
                cmd.Parameters.AddWithValue("@Email", data.Email);
                cmd.ExecuteNonQuery();
;            }
            return "Student updated Successfully..!";
        }

        public string DeleteStudent(int id)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var query = new SqlCommand("Delete From Students Where Id = @id", conn);
                query.Parameters.AddWithValue("@Id", id);
                query.ExecuteNonQuery();

                return "Student deleted Successfully!";
            }
        }


    }

 
}
