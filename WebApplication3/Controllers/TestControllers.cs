using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;
namespace WebApplication3.Controllers;

[ApiController]
[Route("api/estekhdam")]
public class TestControllers(IPeople People) : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<People>>> GetAll()
    {
        return await Task.FromResult(Ok(People.GetAll()));
    }

    [HttpPost]
    public async Task<ActionResult<People>> Post([FromBody] People people)
    {
        return await Task.FromResult(Ok(People.Add(people)));
    }



    [HttpPut("{id}")]
    public async Task<ActionResult> Put([FromRoute] int id, [FromBody] People people)
    {
        People.Update(id, people);
        return await Task.FromResult(Ok());
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete([FromRoute] int id, [FromBody] People people)
    {
        People.Delete(id);
        return await Task.FromResult(Ok(people));
    }
}
//     
    //      // var del= People.Where(id => id.Id == people.Id).ToList();
    //      //  foreach (var p in del)
    //      //  {
    //      //      People.Remove(p);
    //      //  }
    //      return await Task.FromResult(Ok(Persons));
    //  }
// }
// }









// using Microsoft.AspNetCore.Mvc;
// using WebApplication3.Model;
// //
// namespace WebApplication3.Controllers;
// [ApiController]
// [Route("api/estekhdam")]
// public class TestControllers : ControllerBase
// {
//     public static List<People> People = new List<People>();
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<People>>> GetAll()
//     {
//         return await Task.FromResult(Ok(People));
//     }
//
//     [HttpPost]
//     public async Task<ActionResult<People>> Post(People people)
//     {
//         People.Add(people);
//         return await Task.FromResult(Ok(People));
//     }
//
//     [HttpPut]
//     public async Task<ActionResult<People>> Put(People people)
//     {
//         var up = People.SingleOrDefault(id=>id.Id==people.Id);
//         up.Id=people.Id;
//         up.FirstName=people.FirstName;
//         up.LastName=people.LastName;
//         return await Task.FromResult(Ok(People));
//     }
//
//     [HttpDelete]
//     public async Task<ActionResult<People>> Delete(People people)
//     {
//         People.FindAll(id=>id.Id==people.Id);
//         People.RemoveAll(id=>id.Id==people.Id);
//         // var del= People.Where(id => id.Id == people.Id).ToList();
//         //  foreach (var p in del)
//         //  {
//         //      People.Remove(p);
//         //  }
//         return await Task.FromResult(Ok(People));
//     }
// }