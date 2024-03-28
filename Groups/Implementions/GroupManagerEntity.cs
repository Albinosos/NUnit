using Students.Implementations;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    private object _groupLock = new object(); // Об'єкт блокування для груп
    private object _personLock = new object(); // Об'єкт блокування для осіб
    private object _subjectLock = new object(); // Об'єкт блокування для предметів
    private object _teacherLock = new object(); // Об'єкт блокування для вчителів

    public GroupEntity GetGroup(int id)
    {
        lock (_groupLock)
        {
            // Отримання групи з бази даних чи іншого джерела
            Console.WriteLine($"Group with id {id} is retrieved.");
            return new GroupEntity { Id = id, Name = "Sample Group" };
        }
    }

    public void UpdateGroup(GroupEntity group)
    {
        lock (_groupLock)
        {
            // Оновлення групи в базі даних чи іншого джерела
            Console.WriteLine($"Group with id {group.Id} is updated.");
        }
    }

    public PersonEntity GetPerson(int id)
    {
        lock (_personLock)
        {
            // Отримання особи з бази даних чи іншого джерела
            Console.WriteLine($"Person with id {id} is retrieved.");
            return new PersonEntity(id, "Sample Person"); // Додано аргумент id
        }
    }

    public TeacherEntity GetTeacher(int id)
    {
        lock (_teacherLock)
        {
            // Отримання вчителя з бази даних чи іншого джерела
            Console.WriteLine($"Teacher with id {id} is retrieved.");
            return new TeacherEntity(id, "Sample Teacher", "Sample Department");
        }
    }


    public void UpdateTeacher(TeacherEntity teacher)
    {
        lock (_teacherLock)
        {
            // Оновлення вчителя в базі даних чи іншого джерела
            Console.WriteLine($"Teacher with id {teacher.Id} is updated.");
        }
    }


    public SubjectEntity GetSubject(int id)
    {
        lock (_subjectLock)
        {
            // Отримання предмету з бази даних чи іншого джерела
            Console.WriteLine($"Subject with id {id} is retrieved.");
            return new SubjectEntity { Id = id, Name = "Sample Subject" };
        }
    }


}