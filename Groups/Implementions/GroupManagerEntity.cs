using Students.Implementations;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    private object _groupLock = new object(); // ��'��� ���������� ��� ����
    private object _personLock = new object(); // ��'��� ���������� ��� ���
    private object _subjectLock = new object(); // ��'��� ���������� ��� ��������
    private object _teacherLock = new object(); // ��'��� ���������� ��� �������

    public GroupEntity GetGroup(int id)
    {
        lock (_groupLock)
        {
            // ��������� ����� � ���� ����� �� ������ �������
            Console.WriteLine($"Group with id {id} is retrieved.");
            return new GroupEntity { Id = id, Name = "Sample Group" };
        }
    }

    public void UpdateGroup(GroupEntity group)
    {
        lock (_groupLock)
        {
            // ��������� ����� � ��� ����� �� ������ �������
            Console.WriteLine($"Group with id {group.Id} is updated.");
        }
    }

    public PersonEntity GetPerson(int id)
    {
        lock (_personLock)
        {
            // ��������� ����� � ���� ����� �� ������ �������
            Console.WriteLine($"Person with id {id} is retrieved.");
            return new PersonEntity(id, "Sample Person"); // ������ �������� id
        }
    }

    public TeacherEntity GetTeacher(int id)
    {
        lock (_teacherLock)
        {
            // ��������� ������� � ���� ����� �� ������ �������
            Console.WriteLine($"Teacher with id {id} is retrieved.");
            return new TeacherEntity(id, "Sample Teacher", "Sample Department");
        }
    }


    public void UpdateTeacher(TeacherEntity teacher)
    {
        lock (_teacherLock)
        {
            // ��������� ������� � ��� ����� �� ������ �������
            Console.WriteLine($"Teacher with id {teacher.Id} is updated.");
        }
    }


    public SubjectEntity GetSubject(int id)
    {
        lock (_subjectLock)
        {
            // ��������� �������� � ���� ����� �� ������ �������
            Console.WriteLine($"Subject with id {id} is retrieved.");
            return new SubjectEntity { Id = id, Name = "Sample Subject" };
        }
    }


}