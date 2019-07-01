using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Pie : IPieRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }

        public IEnumerable<Pie> GetAllPies()
        {
            throw new NotImplementedException();
        }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
