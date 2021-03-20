namespace Server3.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bookings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bookings()
        {
            booking_hotel_detail = new HashSet<booking_hotel_detail>();
        }

        [Key]
        public int booking_id { get; set; }

        public int? user_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? time_booking { get; set; }

        public double? total_booking_price { get; set; }

        [StringLength(250)]
        public string payment_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking_hotel_detail> booking_hotel_detail { get; set; }

        public virtual users users { get; set; }
    }
}
