using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;
namespace WebApplication3.Controllers;

[ApiController]
[Route("api/estekhdam")]
public class TestControllers : ControllerBase
{
    public static List<People> Persons = new List<People>();

    [HttpGet]
    public async Task<ActionResult<IEnumerable<People>>> GetAll()
    {
        return await Task.FromResult(Ok(Persons));
    }

    [HttpPost]
    public async Task<ActionResult<People>> Post([FromBody] PeopleRequest people)
    {

        Persons.Add(new People()
        {

            FirstName = people.FirstName,
            LastName = people.LastName,
            Id = 1
        });
        return await Task.FromResult(Ok());
    }


    [HttpPut("{id}")]
      public async Task<ActionResult<People>> Put([FromRoute] int id, [FromBody] PeopleRequest people)
      {
          var up = Persons.SingleOrDefault(p => p.Id == id);
    
          up.FirstName = people.FirstName;
          up.LastName = people.LastName;
          return await Task.FromResult(Ok(up));
      }
          [HttpDelete("{id}")]
      public async Task<ActionResult<People>> Delete([FromRoute] int id)
     {
        var speceficPerson= Persons.SingleOrDefault(p => p.Id ==id);
        
        Persons.Remove(speceficPerson);
        
         // var del= People.Where(id => id.Id == people.Id).ToList();
         //  foreach (var p in del)
         //  {
         //      People.Remove(p);
         //  }
         return await Task.FromResult(Ok(Persons));
     }
// }
}


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