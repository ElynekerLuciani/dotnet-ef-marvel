using System.ComponentModel.DataAnnotations;

namespace dotnet_ef_marvel.src.Entities
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80)]
        [MinLength(3)]
        [Required]
        public string Name { get; set; }
    }
}