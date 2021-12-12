using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Person : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        public string surname { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        public string department { get; set; }

        [Column(TypeName = "int")]
        public int salary { get; set; }

    }
}
