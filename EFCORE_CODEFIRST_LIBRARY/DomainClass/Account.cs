using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCORE_CODEFIRST_LIBRARY.DomainClass
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Acc { get; set; }

        [StringLength(50)]
        public string Pass { get; set; }

        public int? Status { get; set; }

        [ForeignKey("IdRole")]//Tạo tên cột khóa phụ
        public Role Roles { get; set; }
    }
}