using System.ComponentModel.DataAnnotations.Schema;

namespace RestAspNet5.Model
{
    [Table("books")]
    public class Entity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}