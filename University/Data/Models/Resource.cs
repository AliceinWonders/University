using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Data.Models
{

    public enum ResourceType
    {
        Video = 1,
        Presentation = 2,
        Document = 3,
        Other =4
    }
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        
        [Required, MaxLength(64)]
        public int Name { get; set; }
        
        [Column(TypeName = "varchar(max)")]
        public string Url { get; set; }
        
        public ResourceType ResourceType { get; set; }
        
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}