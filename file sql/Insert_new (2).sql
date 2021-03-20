USE CLSVBTL_16
GO

INSERT dbo.locations
        ( location_name, image_url )
VALUES  ( N'Hà Nội', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Ha_Noi.jpeg'  -- image_url - nvarchar(100)
          ),
		( N'Hồ Chí Minh', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\HCM.jpg'  -- image_url - nvarchar(100)
          ),
		( N'Đà Nẵng', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Da_Nang.jpg'  -- image_url - nvarchar(100)
          ),
		( N'Đà Lạt', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Da_Lat.jpg'  -- image_url - nvarchar(100)
          ),
		( N'SaPa', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\sapa.jpg'  -- image_url - nvarchar(100)
          ),
		( N'Phú Quốc', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Phu_Quoc.jpg'  -- image_url - nvarchar(100)
          ),
		( N'Nha Trang', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Nha_Trang.jpg'  -- image_url - nvarchar(100)
          ),
		( N'Huế', -- location_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Hue.jpg'  -- image_url - nvarchar(100)
          )
GO



INSERT dbo.services
        ( service_name, service_image )
VALUES  ( N'Nhà Hàng',  -- service_name - nvarchar(50)
          N'D:\Ki 2 nam 4\Anh_DTB\restaurant.png'  -- service_image - nvarchar(250)
          ),
		( N'Quầy Bar',  -- service_name - nvarchar(50)
          N'D:\Ki 2 nam 4\Anh_DTB\barman.png'  -- service_image - nvarchar(250)
          ),
		( N'Massage',  -- service_name - nvarchar(50)
          N'D:\Ki 2 nam 4\Anh_DTB\massage.png'  -- service_image - nvarchar(250)
          ),
		( N'Cafe',  -- service_name - nvarchar(50)
          N'D:\Ki 2 nam 4\Anh_DTB\caffe.png'  -- service_image - nvarchar(250)
          ),
		( N'Hồ Bơi',  -- service_name - nvarchar(50)
          N'D:\Ki 2 nam 4\Anh_DTB\swimming-pool.png'  -- service_image - nvarchar(250)
          ),
		( N'Hồ Bơi',  -- service_name - nvarchar(50)
          N'D:\Ki 2 nam 4\Anh_DTB\gym.png'  -- service_image - nvarchar(250)
          )
GO





INSERT dbo.hotels
        ( location_id ,
          hotel_name ,
          image_url ,
          star ,
          detail_header_image_url ,
          description ,
          hotel_hotline ,
          location_details ,
          booking_count
        )
VALUES  ( 1 , -- location_id - int
          N'The Oriental Jade Ha Noi' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi.jpeg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0988666888' , -- hotel_hotline - varchar(100)
          N'Thanh Xuân Hà Nội' , -- location_details - nvarchar(255)
          150  -- booking_count - int
        ),
		( 1 , -- location_id - int
          N'Novotel Ha Noi' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Hotel_HN2.jpg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn.jpg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0988666888' , -- hotel_hotline - varchar(100)
          N'Thanh Xuân Hà Nội' , -- location_details - nvarchar(255)
          200  -- booking_count - int
        ),
		( 1 , -- location_id - int
          N'Marriott Ha Noi' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Hotel_Hn4.jpg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\View_HN3.jpg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0988666888' , -- hotel_hotline - varchar(100)
          N'Thanh Xuân Hà Nội' , -- location_details - nvarchar(255)
          300  -- booking_count - int
        ),
		( 2 , -- location_id - int
          N'Marriott Ho Chi Minh' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Hotel_HCM1.jpg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM1.jpg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999666888' , -- hotel_hotline - varchar(100)
          N'Quận 1 Thành Phố Hồ Chí Minh' , -- location_details - nvarchar(255)
          300  -- booking_count - int
        ),
		( 2 , -- location_id - int
          N'Novotel Ho Chi Minh' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Hotel_HCM3.jpg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\View_HCM3.jpg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999666888' , -- hotel_hotline - varchar(100)
          N'Quận 1 Thành Phố Hồ Chí Minh' , -- location_details - nvarchar(255)
          200  -- booking_count - int
        ),
		( 2 , -- location_id - int
          N'Muong Thanh Ho Chi Minh' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999666888' , -- hotel_hotline - varchar(100)
          N'Quận 1 Thành Phố Hồ Chí Minh' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 3 , -- location_id - int
          N'Stella Maris Beach Da Nang' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang.jpeg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_View1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Quận Hải Châu Thành Phố Hồ Chí Minh' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 3 , -- location_id - int
          N'Sala Beach Da Nang ' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach.jpg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Quận Hải Châu Thành Phố Hồ Chí Minh' , -- location_details - nvarchar(255)
          200  -- booking_count - int
        ),
		( 4 , -- location_id - int
          N'Colline Da lat ' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\CollineDalat.jpeg' , -- image_url - nvarchar(100)
          4 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Quận 1 Thành Phố Đà Lạt' , -- location_details - nvarchar(255)
          200  -- booking_count - int
        ),
		( 4 , -- location_id - int
          N'Kings Da Lat' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat.jpeg' , -- image_url - nvarchar(100)
          4 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Quận 1 Thành Phố Đà Lạt' , -- location_details - nvarchar(255)
          200  -- booking_count - int
        ),
		( 5 , -- location_id - int
          N'KK SaPa' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\KKSapa.jpeg' , -- image_url - nvarchar(100)
          4 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Quận 1 Thành Phố SaPa' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 5 , -- location_id - int
          N'Bamboo SaPa' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\BambooSapa.jpeg' , -- image_url - nvarchar(100)
          4 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Quận 1 Thành Phố SaPa' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 6 , -- location_id - int
          N'Sunset Beach PhuQuoc' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc.jpeg' , -- image_url - nvarchar(100)
          4 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Xã Phú Quốc Huyện Đảo Phú Quốc' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 6 , -- location_id - int
          N'The Shells PhuQuoc' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc.jpeg' , -- image_url - nvarchar(100)
          4 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Xã Phú Quốc Huyện Đảo Phú Quốc' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 7 , -- location_id - int
          N'Muong Thanh Nha Trang' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang.jpeg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Phường 1 Thành Phố Nha Trang' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 7 , -- location_id - int
          N'Xavia Nha Trang' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang.jpeg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Phường 1 Thành Phố Nha Trang' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 8 , -- location_id - int
          N'Vinpearl Hotel Hue' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue.jpeg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Phường 1 Thành Phố Huế' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        ),
		( 8 , -- location_id - int
          N'Muong Thanh Hue' , -- hotel_name - nvarchar(100)
          N'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue.jpeg' , -- image_url - nvarchar(100)
          5 , -- star - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view1.jpeg' , -- detail_header_image_url - text
          N'Khách sạn tuyệt vời' , -- description - text
          '0999888888' , -- hotel_hotline - varchar(100)
          N'Phường 1 Thành Phố Huế' , -- location_details - nvarchar(255)
          250  -- booking_count - int
        )
GO


INSERT dbo.hotel_service
        ( hotel_id, service_id, unit_price )
VALUES  ( 1, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 1, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 1, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 1, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 1, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 1, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
	    ( 2, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 2, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 2, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 2, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 2, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 2, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 3, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 3, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 3, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 3, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 3, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 3, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 4, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 4, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 4, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 4, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 4, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 4, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 5, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 5, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 5, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 5, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 5, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 5, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 6, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 6, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 6, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 6, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 6, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 6, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 7, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 7, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 7, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 7, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 7, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 7, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 8, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 8, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 8, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 8, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 8, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 8, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 9, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 9, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 9, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 9, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 9, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 9, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 10, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 10, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 10, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 10, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 10, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 10, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 11, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 11, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 11, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 11, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 11, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 11, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 12, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 12, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 12, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 12, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 12, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 12, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 13, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 13, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 13, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 13, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 13, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 13, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 14, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 14, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 14, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 14, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 14, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 14, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 15, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 15, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 15, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 15, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 15, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 15, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 16, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 16, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 16, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 16, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 16, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 16, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 17, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 17, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 17, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 17, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 17, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 17, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          ),
		( 18, -- hotel_id - int
          1, -- service_id - int
          300000  -- unit_price - int
          ),
		( 18, -- hotel_id - int
          2, -- service_id - int
          500000  -- unit_price - int
          ),
	    ( 18, -- hotel_id - int
          3, -- service_id - int
          200000  -- unit_price - int
          ),
		( 18, -- hotel_id - int
          4, -- service_id - int
          50000  -- unit_price - int
          ),
		( 18, -- hotel_id - int
          5, -- service_id - int
          80000  -- unit_price - int
          ),
		( 18, -- hotel_id - int
          6, -- service_id - int
          120000  -- unit_price - int
          )
GO




INSERT dbo.roles
        ( role_name )
VALUES  ( N'Khách Hàng'  -- role_name - nvarchar(50)
          ),
		( N'Admin'  -- role_name - nvarchar(50)
          )
GO 


INSERT dbo.discount
        ( discount_id, discount_value )
VALUES  ( '1', -- discount_id - varchar(50)
          1.0  -- discount_value - float
          ),
		( '2', -- discount_id - varchar(50)
          1.5  -- discount_value - float
          ),
		( '3', -- discount_id - varchar(50)
          2.0  -- discount_value - float
          ),
		( '4', -- discount_id - varchar(50)
          2.5  -- discount_value - float
          ),
		( '5', -- discount_id - varchar(50)
          3.0  -- discount_value - float
          ),
		( '6', -- discount_id - varchar(50)
          3.5  -- discount_value - float
          ),
		( '7', -- discount_id - varchar(50)
          4.0  -- discount_value - float
          ),
		( '8', -- discount_id - varchar(50)
          4.5  -- discount_value - float
          ),
		( '9', -- discount_id - varchar(50)
          5.0  -- discount_value - float
          ),
		( '10', -- discount_id - varchar(50)
          5.5  -- discount_value - float
          ),
		( '11', -- discount_id - varchar(50)
          6.0  -- discount_value - float
          )
GO


INSERT dbo.users
        ( username ,
          password ,
          role_id ,
          full_name ,
          email ,
          phone ,
          address ,
          point ,
          discount_id
        )
VALUES  ( 'admin' , -- username - varchar(50)
          '698d51a19d8a121ce581499d7b701668' , -- password - text
          2 , -- role_id - int
          N'Hồ Đắc Thắng' , -- full_name - nvarchar(255)
          N'thang@gmail.com' , -- email - nvarchar(255)
          N'0999999999' , -- phone - nvarchar(255)
          N'Quỳnh Phụ, Thái Bình' , -- address - nvarchar(255)
		  11.0 , -- point - float
          '11'  -- discount_id - varchar(50)
        ),
		( 'admin1' , -- username - varchar(50)
          'admin1' , -- password - text
          2 , -- role_id - int
          N'Nguyễn Quý Thái' , -- full_name - nvarchar(255)
          N'thai@gmail.com' , -- email - nvarchar(255)
          N'088888888' , -- phone - nvarchar(255)
          N'Đại Mỗ, Hà Nội' , -- address - nvarchar(255)
		  8.0 , -- point - float
          '8'  -- discount_id - varchar(50)
        ),
		( 'test1' , -- username - varchar(50)
          'test1' , -- password - text
          1 , -- role_id - int
          N'Nguyễn Sơn Tùng' , -- full_name - nvarchar(255)
          N'tung@gmail.com' , -- email - nvarchar(255)
          N'088888888' , -- phone - nvarchar(255)
          N'Bắc Ninh' , -- address - nvarchar(255)
		  5.0 , -- point - float
          '5'  -- discount_id - varchar(50)
        ),
		( 'test2' , -- username - varchar(50)
          'test2' , -- password - text
          2 , -- role_id - int
          N'Trần Hùng Phong' , -- full_name - nvarchar(255)
          N'Phong@gmail.com' , -- email - nvarchar(255)
          N'088888888' , -- phone - nvarchar(255)
          N'Đống Đa, Hà Nội' , -- address - nvarchar(255)
		  6.0 , -- point - float
          '6'  -- discount_id - varchar(50)
        )

GO




INSERT dbo.comments
        ( hotel_id ,
          user_id ,
          content ,
          time_comment
        )
VALUES  ( 1 , -- hotel_id - int
          1 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 2 , -- hotel_id - int
          2 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 3 , -- hotel_id - int
          3 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 4 , -- hotel_id - int
          4 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 5 , -- hotel_id - int
          3 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 6 , -- hotel_id - int
          3 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 7 , -- hotel_id - int
          3 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 8 , -- hotel_id - int
          4 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 9 , -- hotel_id - int
          4 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        ),
		( 10 , -- hotel_id - int
          4 , -- user_id - int
          N'Khách sạn tuyệt vời' , -- content - text
          GETDATE()  -- time_comment - date
        )
GO






INSERT dbo.convenient
        ( convenient_name ,
          convenient_image
        )
VALUES  ( N'Bar' , -- convenient_name - nvarchar(255)
          'D:\Ki 2 nam 4\Anh_DTB\Bar.png'  -- convenient_image - text
        ),
		( N'Tivi' , -- convenient_name - nvarchar(255)
          'D:\Ki 2 nam 4\Anh_DTB\television.png'  -- convenient_image - text
        ),
		( N'Bồn Tắm' , -- convenient_name - nvarchar(255)
          'D:\Ki 2 nam 4\Anh_DTB\bath.png'  -- convenient_image - text
        ),
		( N'Giường Đôi' , -- convenient_name - nvarchar(255)
          'D:\Ki 2 nam 4\Anh_DTB\bed.png'  -- convenient_image - text
        ),
		( N'Hồ Bơi' , -- convenient_name - nvarchar(255)
          'D:\Ki 2 nam 4\Anh_DTB\swimming-pool.png'  -- convenient_image - text
        ),
		( N'Bàn Ăn' , -- convenient_name - nvarchar(255)
          'D:\Ki 2 nam 4\Anh_DTB\Table_dinner.png'  -- convenient_image - text
        )
GO


INSERT dbo.hotel_rooms
        ( hotel_id ,
          detail_header_image_url_1 ,
          detail_header_image_url_2 ,
          detail_header_image_url_3 ,
          detail_header_image_url_4 ,
          acreage ,
          floors ,
          limit_people ,
          bed_count ,
          price ,
          sell_price 
        )
VALUES  ( 1 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn2.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn3.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn4.jpg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1200000.0 , -- price - float
          1000000.0  -- sell_price - float
        ),
		( 1 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn2.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn3.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn4.jpg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          10 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1000000.0 , -- price - float
          800000.0  -- sell_price - float
        ),
		( 2 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn5.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn6.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn3.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn4.jpg' , -- detail_header_image_url_4 - varchar(100)
          100.0 , -- acreage - float
          3 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1000000.0 , -- price - float
          800000.0  -- sell_price - float
        ),
		( 2 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn5.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn6.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn3.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\View_Hn4.jpg' , -- detail_header_image_url_4 - varchar(100)
          100.0 , -- acreage - float
          10 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          650000.0  -- sell_price - float
        ),
		( 3 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          650000.0  -- sell_price - float
        ),
		( 3 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheOrientalJade_HaNoi_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          650000.0 , -- price - float
          500000.0  -- sell_price - float
        ),
		( 4 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          650000.0 , -- price - float
          500000.0  -- sell_price - float
        ),
		( 4 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_HoChiMinh.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          650000.0  -- sell_price - float
        ),
		( 5 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM1.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM2.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM3.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM4.jpg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          650000.0 , -- price - float
          500000.0  -- sell_price - float
        ),
		( 5 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM1.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM2.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM3.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM4.jpg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          2 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          650000.0  -- sell_price - float
        ),
		( 6 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM8.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM7.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM6.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM5.jpg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          12 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          600000.0 , -- price - float
          450000.0  -- sell_price - float
        ),
		( 6 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM8.jpg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM7.jpg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM6.jpg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\view_HCM5.jpg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          15 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          500000.0 , -- price - float
          350000.0  -- sell_price - float
        ),
		( 7 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          650000.0 , -- price - float
          500000.0  -- sell_price - float
        ),
		( 7 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\StellaMarisBeach_Danang_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          650000.0  -- sell_price - float
        ),
		( 8 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1000000.0 , -- price - float
          800000.0  -- sell_price - float
        ),
		( 8 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SalaDanang_Beach_View4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          3 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1200000.0 , -- price - float
          1000000.0  -- sell_price - float
        ),
		( 9 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view4.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view3.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view2.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          6 , -- floors - int
          12 , -- limit_people - int
          2 , -- bed_count - int
          1000000.0 , -- price - float
          800000.0  -- sell_price - float
        ),
		( 9 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view4.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view3.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view2.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\CollineDalat_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          8 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1400000.0 , -- price - float
          1000000.0  -- sell_price - float
        ),
		( 10 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view3.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view2.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          16 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          600000.0 , -- price - float
          400000.0  -- sell_price - float
        ),
		( 10 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view4.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Kings_DaLat_view2.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          750000.0 , -- price - float
          500000.0  -- sell_price - float
        ),
		( 11 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          60.0 , -- acreage - float
          6 , -- floors - int
          12 , -- limit_people - int
          2 , -- bed_count - int
          600000.0 , -- price - float
          400000.0  -- sell_price - float
        ),
		( 11 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\KKSapa_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          60.0 , -- acreage - float
          18 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          750000.0 , -- price - float
          500000.0  -- sell_price - float
        ),
		( 12 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          12 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          600000.0  -- sell_price - float
        ),
		( 12 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\BambooSapa_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          850000.0 , -- price - float
          650000.0  -- sell_price - float
        ),
		( 13 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view3.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view4.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view2.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          6 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          900000.0 , -- price - float
          600000.0  -- sell_price - float
        ),
		( 13 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view3.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view4.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\SunsetBeach_PhuQuoc_view2.jpeg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          6 , -- floors - int
          6 , -- limit_people - int
          2 , -- bed_count - int
          1300000.0 , -- price - float
          900000.0  -- sell_price - float
        ),
		( 14 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          8 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          900000.0 , -- price - float
          600000.0  -- sell_price - float
        ),
		( 14 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\TheShells_PhuQuoc_view1.jpeg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          2 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1300000.0 , -- price - float
          900000.0  -- sell_price - float
        ),
		( 8 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          40.0 , -- acreage - float
          8 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          500000.0 , -- price - float
          300000.0  -- sell_price - float
        ),
		( 8 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\AnioBoutique_HoiAn_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          2 , -- floors - int
          6 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          600000.0  -- sell_price - float
        ),
		( 15 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          8 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1200000.0 , -- price - float
          800000.0  -- sell_price - float
        ),
		( 15 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanh_NhaTrang_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          120.0 , -- acreage - float
          2 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1500000.0 , -- price - float
          900000.0  -- sell_price - float
        ),
		( 16 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          60.0 , -- acreage - float
          8 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          600000.0 , -- price - float
          400000.0  -- sell_price - float
        ),
		( 16 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\Xavia_NhaTrang_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          2 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          600000.0  -- sell_price - float
        ),
		( 17 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          8 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1600000.0 , -- price - float
          1000000.0  -- sell_price - float
        ),
		( 17 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view1.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view2.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view3.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\VinpearlHotelHue_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          100.0 , -- acreage - float
          2 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          1800000.0 , -- price - float
          1200000.0  -- sell_price - float
        ),
		( 18 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view2.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view4.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view3.jpeg' , -- detail_header_image_url_4 - varchar(100)
          60.0 , -- acreage - float
          8 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          600000.0 , -- price - float
          400000.0  -- sell_price - float
        ),
		( 18 , -- hotel_id - int
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view2.jpeg' , -- detail_header_image_url_1 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view3.jpeg' , -- detail_header_image_url_2 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view1.jpeg' , -- detail_header_image_url_3 - varchar(100)
          'D:\Ki 2 nam 4\Anh_DTB\MuongThanhHue_view4.jpeg' , -- detail_header_image_url_4 - varchar(100)
          80.0 , -- acreage - float
          2 , -- floors - int
          4 , -- limit_people - int
          2 , -- bed_count - int
          800000.0 , -- price - float
          600000.0  -- sell_price - float
        )
GO





INSERT dbo.hotel_convenient
        ( hotel_id ,
          hotel_rooms_id ,
          convenient_id
        )
VALUES  ( 1 , -- hotel_id - int
          1 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          1 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          1 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          1 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          1 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          1 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          2 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          2 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          2 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          2 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          2 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 1 , -- hotel_id - int
          2 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          3 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          3 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          3 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          3 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          3 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          3 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          4 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          4 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          4 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          4 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          4 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 2 , -- hotel_id - int
          4 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          5 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          5 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          5 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          5 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          5 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          6 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          6 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          6 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          6 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 3 , -- hotel_id - int
          6 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 4 , -- hotel_id - int
          7 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 4 , -- hotel_id - int
          7 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 4 , -- hotel_id - int
          7 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 4 , -- hotel_id - int
          8 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 4 , -- hotel_id - int
          8 , -- hotel_rooms_id - int
          5  -- convenient_id - int
        ),
		( 4 , -- hotel_id - int
          8 , -- hotel_rooms_id - int
          6  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          9 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          9 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          9 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          9 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          10 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          10 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          10 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 5 , -- hotel_id - int
          10 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          11 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          11 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          11 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          11 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          12 , -- hotel_rooms_id - int
          1  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          12 , -- hotel_rooms_id - int
          2  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          12 , -- hotel_rooms_id - int
          3  -- convenient_id - int
        ),
		( 6 , -- hotel_id - int
          12 , -- hotel_rooms_id - int
          4  -- convenient_id - int
        )
GO


INSERT dbo.banner
        ( banner_image )
VALUES  ( 'D:\Ki 2 nam 4\Anh_DTB\banner_11.jpg'  -- banner_image - varchar(255)
          ),
		( 'D:\Ki 2 nam 4\Anh_DTB\banner_12.jpg'  -- banner_image - varchar(255)
          ),
		( 'D:\Ki 2 nam 4\Anh_DTB\banner_13.jpg'  -- banner_image - varchar(255)
          )
GO



