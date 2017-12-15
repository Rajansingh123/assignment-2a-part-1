namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_3
    {
        public int carid { get; set; }

        [Key]
        [StringLength(50)]
        public string cars { get; set; }

        public int price { get; set; }

        [Required]
        [StringLength(50)]
        public string company { get; set; }

        public virtual Table_1 Table_1 { get; set; }
    }
}
