namespace CNW_N8_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public services()
        {
            hotel_service = new HashSet<hotel_service>();
        }

        [Key]
        public int service_id { get; set; }

        [Required]
        [StringLength(50)]
        public string service_name { get; set; }

        [StringLength(250)]
        public string service_image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel_service> hotel_service { get; set; }
    }
}
