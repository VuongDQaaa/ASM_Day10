using ASM_Day10.Entities;
using ASM_Day10.DTO;

namespace ASM_Day10.Extensions
{
    public static class StudentExtension
    {
        public static StudentDTO EntityToDTO(this Student entity)
        {
            return new StudentDTO()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                City = entity.City,
                State = entity.State
            };
        }

        public static Student DTOToEntity(this StudentDTO dto)
        {
            return new Student()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                City = dto.City,
                State = dto.State
            };
        }
    }
}