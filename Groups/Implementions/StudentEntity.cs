namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public string School { get; set; }

    public StudentEntity(int id, string name, string school) : base(id, name)
    {
        School = school ?? throw new ArgumentNullException(nameof(school));
    }
}