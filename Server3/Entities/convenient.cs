namespace Server3.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("convenient")]
    public partial class convenient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public convenient()
        {
            hotel_convenient = new HashSet<hotel_convenient>();
        }

        [Key]
        public int convenient_id { get; set; }

        [StringLength(255)]
        public string convenient_name { get; set; }

        [Column(TypeName = "text")]
        public string convenient_image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel_convenient> hotel_convenient { get; set; }
    }
}
