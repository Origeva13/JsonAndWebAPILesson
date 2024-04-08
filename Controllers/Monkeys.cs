using CalculatorWebAPI.DTO;
using CalculatorWebAPI.Models.CalculatorWebAPI.Models;
using CalculatorWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebAPI.Controllers
{
    [Route("monkey")]
    [ApiController]
    public class Monkeys : ControllerBase
    {
        [HttpGet("ReadAllMonkeys")]
        public IActionResult ReadAllMonkeys()
        {
           MonkeyListDto mon=new MonkeyListDto();
           MonkeyList list=new MonkeyList();
           mon.Monkeys=new List<MonkeyDto>();
            foreach(Monkey m in list.Monkeys)
            {
                mon.Monkeys.Add(new MonkeyDto()
                {
                    Name = m.Name,
                    Location = m.Location,
                    Details = m.Details,
                    ImageUrl = m.ImageUrl,
                    IsFavorite = m.IsFavorite,
                }
                );
            }
            return Ok(mon);
        }
        [HttpGet("ReadMonkey")]

        public IActionResult ReadMonkey([FromQuery] string monkeyName)
        {
            try
            {
                MonkeyList List = new MonkeyList();
                foreach(Monkey m in List.Monkeys)
                {
                    if(m.Name == monkeyName)
                    {
                        MonkeyDto monkeyDto = new MonkeyDto() 
                        { 
                            Name=m.Name,
                            Location = m.Location,
                            Details = m.Details,0
                            ImageUrl = m.ImageUrl,
                            IsFavorite = m.IsFavorite,
                        };
                        return Ok(monkeyDto);
                    }
                }
                NotFoundResult result = new NotFoundResult();
                return result;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}
