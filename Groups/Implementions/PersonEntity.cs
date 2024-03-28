namespace Groups.Implementions;

public class PersonEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public PersonEntity(int id, string name)
    {
        Id = id;
        Name = name;
    }
}