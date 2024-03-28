using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Groups.Implementions;
using NUnit.Framework;
using Students.Implementations;

namespace Groups.Tests
{
    [TestFixture]
    public class GroupManagerEntityTests
    {
        private readonly GroupManagerEntity _groupManager = new GroupManagerEntity();



        [Test]
        public void GetGroup_Returns_Group()
        {
            // Arrange
            int groupId = 1;

            // Act
            var group = _groupManager.GetGroup(groupId);

            // Assert
            Assert.That(group, Is.Not.Null);
            Assert.That(group.Id, Is.EqualTo(groupId));
        }

        [Test]
        public void UpdateGroup_Updates_Group()
        {
            // Arrange
            var group = new GroupEntity { Id = 1, Name = "Test Group" };

            // Act
            _groupManager.UpdateGroup(group);

            // Assert
            GroupEntity updatedGroup = _groupManager.GetGroup(group.Id);
            Assert.That(updatedGroup, Is.Not.Null); 
            Assert.That(updatedGroup.Id, Is.EqualTo(group.Id)); 
            Assert.That(updatedGroup.Name, Is.EqualTo(group.Name));
        }

        [Test]
        public void GetPerson_Returns_Person()
        {
            // Arrange
            int personId = 1;

            // Act
            var person = _groupManager.GetPerson(personId);

            // Assert
            Assert.That(person, Is.Not.Null);
            Assert.That(person.Id, Is.EqualTo(personId));
        }

        [Test]
        public void UpdateTeacher_Updates_Teacher()
        {
            // Arrange
            int teacherId = 1; // Опціонально, встановлюємо id для вчителя
            string teacherName = "John Doe";
            string teacherDepartment = "Math";

            // Act
            TeacherEntity teacher = new TeacherEntity(teacherId, teacherName, teacherDepartment);

            // Assert
            // Перевіряємо, чи вчитель дійсно оновився
            TeacherEntity updatedTeacher = _groupManager.GetTeacher(teacherId);
            Assert.That(updatedTeacher, Is.Not.Null); // Перевірка, чи вчитель не є null
            Assert.That(updatedTeacher.Id, Is.EqualTo(teacherId)); // Перевірка, чи id вчителя відповідає очікуваному
            Assert.That(updatedTeacher.Name, Is.EqualTo(teacherName)); // Перевірка, чи ім'я вчителя відповідає очікуваному
            Assert.That(updatedTeacher.Department, Is.EqualTo(teacherDepartment)); // Перевірка, чи відділ вчителя відповідає очікуваному
        }
    }
}
