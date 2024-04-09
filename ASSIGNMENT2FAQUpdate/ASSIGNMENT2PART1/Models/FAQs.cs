using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASSIGNMENT2PART1.Models
{
    public class FAQs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public Category Category { get; set; }

        public Topic Topic { get; set; }

    }
}
