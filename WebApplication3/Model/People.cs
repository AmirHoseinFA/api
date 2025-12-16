namespace WebApplication3.Model;

public interface IPeople
{
    List<People> GetAll();
    People GetById(int id);
    List<People> Add(People person);
    void Update(int id,People person);
    void Delete(int id);
}
public class People
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

public class PeopleRequest : IPeople
{
    public static List<People> Persons = new List<People>();
    
    public List<People> GetAll()
    {
        return (Persons);
    }

    public People GetById(int id)
    {
            var up = Persons.SingleOrDefault(p => p.Id == id);
            return (up);
    }


    public List<People> Add(People person)
    {
        Persons.Add(new People()
        {
            FirstName = person.FirstName,
            LastName = person.LastName,
        });
        return Persons;    }

    public void Update(int id, People person)
    {
        var up = Persons.SingleOrDefault(p => p.Id == id);
        
        up.FirstName = person.FirstName;
        up.LastName = person.LastName;
        return ; ;
    }

    public void Delete(int id)
    {
        var speceficPerson= Persons.SingleOrDefault(p => p.Id ==id);
        
        Persons.Remove(speceficPerson);    }
}