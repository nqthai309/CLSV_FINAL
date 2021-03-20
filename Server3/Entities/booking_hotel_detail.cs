namespace Server3.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class booking_hotel_detail
    {
        [Key]
        public int booking_detail_id { get; set; }

        public int? booking_id { get; set; }

        public int? hotel_id { get; set; }

        public int? hotel_rooms_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? from_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? to_date { get; set; }

        public double? total_price { get; set; }

        [StringLength(250)]
        public string service_list { get; set; }

        public double? total_services_price { get; set; }

        public virtual bookings bookings { get; set; }

        public virtual hotels hotels { get; set; }

        public virtual hotel_rooms hotel_rooms { get; set; }
    }
}
