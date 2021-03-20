INSERT dbo.bookings
        ( user_id ,
          time_booking ,
          total_booking_price ,
          payment_status
        )
VALUES  ( 3,GETDATE() ,1000000, N'Đang xử lý'),
( 4,GETDATE() ,2500000, N'Đang xử lý'),
( 3,GETDATE() ,1450000, N'Đã hoàn thành'),
( 4,GETDATE() ,600000, N'Đang xử lý'),
( 3,GETDATE() ,750000, N'Đã hoàn thành'),
( 4,GETDATE() ,3450000, N'Đang xử lý'),
( 4,GETDATE() ,2500000, N'Đang xử lý'),
( 3,GETDATE() ,135000, N'Đang xử lý'),
( 2,GETDATE() ,2000000, N'Đang xử lý')

INSERT dbo.booking_hotel_detail
        ( booking_id,
          hotel_id,
          hotel_rooms_id ,
          from_date,
		  to_date,
		  total_price,
		  service_list,
		  total_services_price
        )
VALUES (1,1,1,GETDATE(),GETDATE(),250000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',250000),
(1,2,3,GETDATE(),GETDATE(),250000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',250000),
(2,3,4,GETDATE(),GETDATE(),1000000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',1500000),
(3,3,4,GETDATE(),GETDATE(),1000000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',1500000),
(3,3,4,GETDATE(),GETDATE(),1000000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',1500000),
(4,3,4,GETDATE(),GETDATE(),1000000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',1500000),
(4,3,4,GETDATE(),GETDATE(),1000000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',1500000),
(5,3,4,GETDATE(),GETDATE(),1000000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',1500000),
(5,3,4,GETDATE(),GETDATE(),1000000,N'Ăn sáng, Bể bơi, Người bón bữa tối, Tay vịn',1500000)