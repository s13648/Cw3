using System.Collections.Generic;
using Cw3.Models;

namespace Cw3.Dal
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
