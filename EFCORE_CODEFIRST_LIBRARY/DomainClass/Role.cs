using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCORE_CODEFIRST_LIBRARY.DomainClass
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }
    }
}