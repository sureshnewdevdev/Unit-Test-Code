using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMaths
{
    public class StudentOperation : IStudent
    {
        private readonly IDataService dataService1 = new DataService();
        public StudentOperation()
        {
        }

        public StudentOperation( IDataService dataService)
        {
            this.dataService1 = dataService;
        }

        public List<Student> GetStudents()
        {
             

            var result = dataService1.GetStudentData();
            return result;

        }

    }
}
