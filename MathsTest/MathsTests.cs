using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleMaths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace ConsoleMaths.Tests
{
    [TestClass()]
    public class MathsTests
    {
        Mock<IStudent> mockStudent = new Mock<IStudent>();

        /// <summary>
        ///This test is for successful scenario the data is list of students
        /// </summary>
        [TestMethod()]
        
        public void GetStudent_Test_Success_Result()
        {
            mockStudent.Setup(S => S.GetStudents()).Returns(GetTestData);
            List<Student> students = mockStudent.Object.GetStudents();
            var expectedOutput = GetExpectedStudents();
            Assert.AreEqual(expectedOutput.Count, students.Count);
        }

        [TestMethod]
        public void GetStudent_Test_Success_Result2()
        {
            Mock<IDataService> mockService = new Mock<IDataService>();

            Mock<StudentOperation> mockStudent = new Mock<StudentOperation>(mockService.Object);

            mockService.Setup(s => s.GetStudentData()).Returns(GetTestData);
           
            List<Student> students = mockStudent.Object.GetStudents();
            var expectedOutput = GetExpectedStudents();
            Assert.AreEqual(expectedOutput.Count, students.Count);
        }

        private List<Student> GetExpectedStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Rno = 1, Name = "AAA" });
            students.Add(new Student() { Rno = 2, Name = "BBB" });
            students.Add(new Student() { Rno = 3, Name = "CCC" }); 
            students.Add(new Student() { Rno = 4, Name = "DDD" });
            return students;
        }

        private List<Student> GetTestData()
        {
           List<Student> students = new List<Student>();
            students.Add(new Student() { Rno=1, Name="AAA" });
            students.Add(new Student() { Rno=2, Name="BBB" });
            students.Add(new Student() { Rno=3, Name="CCC" });
            students.Add(new Student() { Rno=3, Name="CCC" });
            return students;
        }
    }
}