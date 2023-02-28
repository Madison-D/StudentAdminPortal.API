using System;
using System.Collections.Generic;
using System.Linq;
using StudentAdminPortal.API.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    //inherent from Istudentrepo
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            // to access the student table
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await context.Student
                .Include(nameof(Gender)).Include(nameof(Address))
                .FirstOrDefaultAsync(x => x.Id == studentId);
        }
    }
}
