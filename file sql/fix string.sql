use CLSVBTL_16
go


  update banner set banner_image = substring(banner_image, 14, 1000)
  go

  update convenient set convenient_image = substring(convenient_image, 14, 1000)
  go

  update hotels set image_url = substring(image_url, 14, 1000), detail_header_image_url = substring(detail_header_image_url, 14, 1000)
  go


  update hotel_rooms set detail_header_image_url_1 = substring(detail_header_image_url_1, 14, 1000),
  detail_header_image_url_2 = substring(detail_header_image_url_2, 14, 1000),
  detail_header_image_url_3 = substring(detail_header_image_url_3, 14, 1000),
  detail_header_image_url_4 = substring(detail_header_image_url_4, 14, 1000)
  go

  update locations set image_url = substring(image_url, 14, 1000)
  go

  update services set service_image = substring(service_image, 14, 1000)
  go


