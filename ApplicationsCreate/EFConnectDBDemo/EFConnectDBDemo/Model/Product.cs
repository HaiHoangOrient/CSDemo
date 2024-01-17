using Lombok.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConnectDBDemo.Model
{
    [Table(name: "product")]
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Product(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Product()
        {
        }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
