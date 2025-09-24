using lab11_3.Data;
using lab11_3.Models.StudentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace lab11_3.DAO
{
    public class StudentDAO
    {
        private readonly StudentDbContext _context;

        public StudentDAO(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student?> UpdateStudentAsync(Student student)
        {
            var existing = await _context.Students.FindAsync(student.StudentId);
            if (existing == null) return null;

            existing.Name = student.Name;
            existing.Age = student.Age;
            existing.Email = student.Email;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return false;

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
