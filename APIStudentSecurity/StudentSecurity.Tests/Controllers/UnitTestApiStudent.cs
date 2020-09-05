using System;
using APIStudentSecurity.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentSecurity.Tests.Controllers
{
    [TestClass]
    public class UnitTestApiStudent
    {
        [TestMethod]
        public void TestGetStudent()
        {
            //Arrange
            StudentsController studentsController = new StudentsController();
            //Act
            var listaEstudiantes = studentsController.GetStudents(); // con s porque es una lista
            //Assert
            Assert.IsNotNull(listaEstudiantes);
        }
    }
}
