namespace CNW_N8_MVC.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comments()
        {
            comments_child = new HashSet<comments_child>();
        }

        [Key]
        public int comment_id { get; set; }

        public int? hotel_id { get; set; }

        public int? user_id { get; set; }

        [Column(TypeName = "text")]
        public string content { get; set; }

        [Column(TypeName = "date")]
        public DateTime? time_comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments_child> comments_child { get; set; }

        public virtual hotels hotels { get; set; }

        public virtual users users { get; set; }
    }
}
