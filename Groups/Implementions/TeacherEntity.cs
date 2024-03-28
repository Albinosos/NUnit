using Groups.Implementions;

namespace Students.Implementations;

public class TeacherEntity : PersonEntity
{
    public string Department { get; set; }

    public TeacherEntity(int id, string name, string department) : base(id, name)
    {
        Department = department ?? throw new ArgumentNullException(nameof(department));
    }
}