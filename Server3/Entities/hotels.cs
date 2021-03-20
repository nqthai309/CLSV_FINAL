namespace Server3.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hotels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hotels()
        {
            booking_hotel_detail = new HashSet<booking_hotel_detail>();
            comments = new HashSet<comments>();
            hotel_convenient = new HashSet<hotel_convenient>();
            hotel_rooms = new HashSet<hotel_rooms>();
            hotel_service = new HashSet<hotel_service>();
        }

        [Key]
        public int hotel_id { get; set; }

        public int? location_id { get; set; }

        [StringLength(100)]
        public string hotel_name { get; set; }

        [StringLength(100)]
        public string image_url { get; set; }

        public int? star { get; set; }

        [Column(TypeName = "text")]
        public string detail_header_image_url { get; set; }

        public string description { get; set; }

        [StringLength(100)]
        public string hotel_hotline { get; set; }

        [StringLength(255)]
        public string location_details { get; set; }

        public int? booking_count { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking_hotel_detail> booking_hotel_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments> comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel_convenient> hotel_convenient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel_rooms> hotel_rooms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel_service> hotel_service { get; set; }

        public virtual locations locations { get; set; }
    }
}
