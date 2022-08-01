using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_8_View.DomainClass
{
    [Table("NSX")]
    public partial class Nsx
    {
        public Nsx()
        {
            ChiTietSp = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }

        [InverseProperty("IdNsxNavigation")]
        public virtual ICollection<ChiTietSp> ChiTietSp { get; set; }
    }
}
