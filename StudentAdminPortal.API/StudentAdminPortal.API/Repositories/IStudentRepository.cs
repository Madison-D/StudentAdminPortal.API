using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    //change class to interface
    public interface IStudentRepository
    {
        Task <List<Student>> GetStudentsAsync();
    }
}
