namespace WebApplication3.Model;

public class People
{
    public int Id {get; set;}
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

public class PeopleRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}