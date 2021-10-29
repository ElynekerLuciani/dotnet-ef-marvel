using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_marvel.src.Entities
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80)]
        [MinLength(3)]
        public string Name { get; set; }

        [MaxLength(80)]
        [MinLength(3)]
        [Required]
        public string RealName { get; set; }
        public DateTime CreateAt { get; set; }
        public int? GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }

    }
}