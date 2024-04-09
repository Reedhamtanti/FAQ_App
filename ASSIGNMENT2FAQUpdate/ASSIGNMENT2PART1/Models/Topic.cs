using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASSIGNMENT2PART1.Models
{
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Url { get; set; }

        public string? Name { get; set; }
    }
}
