using CalculatorWebAPI.Models.CalculatorWebAPI.Models;

namespace CalculatorWebAPI.DTO
{
    public class MonkeyDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFavorite { get; set; }
    }
    public class MonkeyListDto 
    {
     public List<MonkeyDto> Monkeys { get; set; }
    }
}
