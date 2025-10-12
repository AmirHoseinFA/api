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
    public async Task<ActionResult<People>> Post([FromRoute] int id, [FromBody] PeopleRequest people)
    {

        Persons.Add(new People()
        {

            FirstName = people.FirstName,
            LastName = people.LastName,
            Id = id
        });
        return await Task.FromResult(Ok(Persons));
    }


    [HttpPut("{id}")]
      public async Task<ActionResult<People>> Put([FromRoute] int id, [FromBody] PeopleRequest people)
      {
          var up = persons.SingleOrDefault(p => p.Id == id);
    
          up.Id = people.id;//TODO:do by amir
          up.FirstName = people.FirstName;
          up.LastName = people.LastName;
          return await Task.FromResult(Ok(persons));
      }
          [HttpDelete]
      public async Task<ActionResult<People>> Delete(PeopleRequest people)
     {
         persons.FindAll(id => id.Id == people.Id);//TODO:do by amir
         persons.RemoveAll(id => id.Id == people.Id);//TODO:do by amir
         // var del= People.Where(id => id.Id == people.Id).ToList();
         //  foreach (var p in del)
         //  {
         //      People.Remove(p);
         //  }
         return await Task.FromResult(Ok(persons));
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