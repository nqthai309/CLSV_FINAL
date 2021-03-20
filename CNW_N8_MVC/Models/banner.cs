namespace CNW_N8_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("banner")]
    public partial class banner
    {
        [Key]
        public int banner_id { get; set; }

        [StringLength(255)]
        public string banner_image { get; set; }
    }
}
