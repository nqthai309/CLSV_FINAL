namespace CNW_N8_MVC.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class locations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public locations()
        {
            hotels = new HashSet<hotels>();
        }

        [Key]
        public int location_id { get; set; }

        [Required]
        [StringLength(100)]
        public string location_name { get; set; }

        [StringLength(100)]
        public string image_url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotels> hotels { get; set; }
    }
}
