using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Data_Access_Layer.Repository.Entities
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            ToDos = new HashSet<ToDo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(ToDo.Category))]
        public virtual ICollection<ToDo> ToDos { get; set; }
    }
}
