using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ToDoItemApp.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Column("Title", TypeName = "Varchar(100)")]
        public string? Title { get; set; }

        public string TodoDate { get; set; }

        public int IsComplete { get; set; }
    }
}
