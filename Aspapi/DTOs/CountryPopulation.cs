using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aspapi.DTOs
{
    public class CountryPopulation
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Population { get; set; }
    }
}
