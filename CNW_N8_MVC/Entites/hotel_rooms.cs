namespace CNW_N8_MVC.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hotel_rooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hotel_rooms()
        {
            booking_hotel_detail = new HashSet<booking_hotel_detail>();
            hotel_convenient = new HashSet<hotel_convenient>();
        }

        [Key]
        public int hotel_rooms_id { get; set; }

        public int? hotel_id { get; set; }

        [StringLength(100)]
        public string detail_header_image_url_1 { get; set; }

        [StringLength(100)]
        public string detail_header_image_url_2 { get; set; }

        [StringLength(100)]
        public string detail_header_image_url_3 { get; set; }

        [StringLength(100)]
        public string detail_header_image_url_4 { get; set; }

        public double? acreage { get; set; }

        public int? floors { get; set; }

        public int? limit_people { get; set; }

        public int? bed_count { get; set; }

        public double? price { get; set; }

        public double? sell_price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking_hotel_detail> booking_hotel_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel_convenient> hotel_convenient { get; set; }

        public virtual hotels hotels { get; set; }
    }
}
