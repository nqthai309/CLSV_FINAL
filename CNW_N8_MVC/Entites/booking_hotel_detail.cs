namespace CNW_N8_MVC.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class booking_hotel_detail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int booking_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hotel_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hotel_rooms_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? from_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? to_date { get; set; }

        public int? total_price { get; set; }

        [StringLength(250)]
        public string service_list { get; set; }

        public int? total_services_price { get; set; }

        public virtual bookings bookings { get; set; }

        public virtual hotels hotels { get; set; }

        public virtual hotel_rooms hotel_rooms { get; set; }
    }
}
