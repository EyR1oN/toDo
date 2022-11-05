using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Data_Access_Layer.Repository.Entities
{
    [Table("ToDo")]
    public partial class ToDo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("category_id")]
        public int? CategoryId { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("is_done")]
        public bool? IsDone { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("ToDos")]
        public virtual Category Category { get; set; }
    }
}
