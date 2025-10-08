using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;

namespace WebApplication3.Controllers;
[ApiController]
[Route("api/estekhdam")]
public class TestControllers : ControllerBase
{
    public static List<People> People = new List<People>();
    [HttpGet]
    public async Task<ActionResult<IEnumerable<People>>> GetAll()
    {
        return await Task.FromResult(Ok(People));
    }

    [HttpPost]
    public async Task<ActionResult<People>> Post(People people)
    {
        People.Add(people);
        return await Task.FromResult(Ok(People));
    }

    [HttpPut]
    public async Task<ActionResult<People>> Put(People people)
    {
        var up = People.Where(id=>id.Id==people.Id).ToList();
        foreach (var item in up)
        {
            item.Id=people.Id;
            item.FirstName=people.FirstName;
            item.LastName=people.LastName;
        }
        return await Task.FromResult(Ok(People));
    }

    [HttpDelete]
    public async Task<ActionResult<People>> Delete(People people)
    {
        var del= People.Where(id => id.Id == people.Id).ToList();
        foreach (var p in del)
        {
            People.Remove(p);
        }
        return await Task.FromResult(Ok(People));
    }
}