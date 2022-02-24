using ASM_Day10.Entities;
using ASM_Day10.DTO;

namespace ASM_Day10.Interface
{
    public interface IStudentService
    {
        Task AddStudent(StudentDTO dto);
        Task<Student> GetStudentById(int id);
        Task<List<Student>> GetAllStudent();
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}