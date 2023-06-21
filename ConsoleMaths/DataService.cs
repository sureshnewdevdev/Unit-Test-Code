namespace ConsoleMaths
{
    public class DataService : IDataService
    {
        public DataService()
        {
        }

        public List<Student> GetStudentData()
        {

            // db operation
            List<Student> data = new List<Student>();
            data.Add(new Student() { Rno = 1, Name = "Anu" });
            data.Add(new Student() { Rno = 2, Name = "Balu" });
            data.Add(new Student() { Rno = 3, Name = "Citra" });
            data.Add(new Student() { Rno = 4, Name = "Devi" });
            return data;
        }

    }
}