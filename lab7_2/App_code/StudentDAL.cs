using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class StudentDAL
{
    string cs = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

    // Select All
    public DataTable GetAllStudents()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    // Insert
    public void InsertStudent(string name, int age, string course)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Students(Name, Age, Course) VALUES(@Name, @Age, @Course)", con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Course", course);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Update
    public void UpdateStudent(int studentID, string name, int age, string course)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("UPDATE Students SET Name=@Name, Age=@Age, Course=@Course WHERE StudentID=@StudentID", con);
            cmd.Parameters.AddWithValue("@StudentID", studentID);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Course", course);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Delete
    public void DeleteStudent(int studentID)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentID=@StudentID", con);
            cmd.Parameters.AddWithValue("@StudentID", studentID);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
