using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;

namespace WebApplication3.Controllers;
[ApiController]
[Route("api/estekhdam")]
public class TestControllers : ControllerBase
{
    private object _context;
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
        People.Add(people);
        return await Task.FromResult(Ok(People));
    }

    [HttpDelete]
    public async Task<ActionResult<People>> Delete(People people)
    {
        People.Remove(people);
        return await Task.FromResult(Ok(People));
        
    }
}