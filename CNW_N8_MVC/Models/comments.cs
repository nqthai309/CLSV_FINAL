namespace CNW_N8_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments
    {
        [Key]
        public int comment_id { get; set; }

        public int? hotel_id { get; set; }

        public int? user_id { get; set; }

        public string content { get; set; }

        [Column(TypeName = "date")]
        public DateTime? time_comment { get; set; }

        public virtual hotels hotels { get; set; }

        public virtual users users { get; set; }
    }
}
