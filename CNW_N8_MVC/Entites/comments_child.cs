namespace CNW_N8_MVC.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments_child
    {
        [Key]
        [Column("comments_child")]
        public int comments_child1 { get; set; }

        public int? comment_id { get; set; }

        public int? user_id { get; set; }

        [Column(TypeName = "text")]
        public string content { get; set; }

        public virtual comments comments { get; set; }

        public virtual users users { get; set; }
    }
}
