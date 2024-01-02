using System.ComponentModel.DataAnnotations;

namespace Bouba_Store.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string? GenreName { get; set; }
    }

}
