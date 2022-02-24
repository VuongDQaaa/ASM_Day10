using ASM_Day10.DTO;
using ASM_Day10.Interface;
using ASM_Day10.DB;
using ASM_Day10.Extensions;
using ASM_Day10.Entities;

namespace ASM_Day10.Services
{
    public class StudentService : IStudentService
    {
        private StudentContext _context;
        public StudentService(StudentContext context)
        {
            _context = context;
        }
        public async Task AddStudent(StudentDTO dto)
        {
            await _context.AddAsync(dto.DTOToEntity());
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudent(int id)
        {
            var item = GetStudentById(id);
            if (item != null)
            {
                _context.Remove(item);
                _context.SaveChangesAsync();
            }
        }

        public async Task<List<Student>> GetAllStudent()
        {
            return _context.Student.ToList();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Student.FindAsync(id);
        }

        public async Task UpdateStudent(Student student)
        {
            var item = _context.Student.FirstOrDefault(m => m.StudentId == student.StudentId);
            if (item != null)
            {
                item.FirstName = student.FirstName;
                item.LastName = student.LastName;
                item.City = student.City;
                item.State = student.State;
                _context.Update(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}