USE master
GO
CREATE DATABASE CLSVBTL_16
GO 

USE CLSVBTL_16
GO




CREATE TABLE roles (
	role_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	role_name NVARCHAR(50) NOT NULL
)
go

create table discount(
	discount_id varchar(50) primary key,
	discount_value float
)
go

CREATE TABLE users (
	user_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(50) NOT NULL,
	password varchar(255) NOT NULL,
	role_id INT FOREIGN KEY REFERENCES dbo.roles(role_id),
	full_name NVARCHAR(255),
	email NVARCHAR(255),
	phone NVARCHAR(255),
	address NVARCHAR(max),
	point FLOAT, 
	discount_id varchar(50) foreign key references dbo.discount(discount_id)
)
go


CREATE TABLE locations (
	location_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	location_name NVARCHAR(100) NOT NULL,
	image_url NVARCHAR(100)
)
go

CREATE TABLE hotels(
	hotel_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	location_id INT FOREIGN KEY REFERENCES dbo.locations(location_id),
	hotel_name NVARCHAR(100),
	image_url NVARCHAR(100),
	star int,
	detail_header_image_url TEXT,
	description nvarchar(max),
	hotel_hotline varchar(100),
	location_details nvarchar(255),
	booking_count INT
)
go



CREATE TABLE hotel_rooms(
	hotel_rooms_id INT IDENTITY(1,1) PRIMARY KEY,
	hotel_id INT FOREIGN KEY REFERENCES dbo.hotels(hotel_id),
	detail_header_image_url_1 VARCHAR(100),
	detail_header_image_url_2 VARCHAR(100),
	detail_header_image_url_3 VARCHAR(100),
	detail_header_image_url_4 VARCHAR(100),
	acreage float,  --dien tich
	floors INT,     --tang
	limit_people INT,
	bed_count INT,
	price float,
	sell_price float,
)
go

CREATE TABLE convenient(
	convenient_id INT IDENTITY(1,1) PRIMARY KEY,
	convenient_name nvarchar(255),
	convenient_image TEXT
)
Go

CREATE TABLE hotel_convenient(
	hotel_id int FOREIGN KEY REFERENCES dbo.hotels(hotel_id),
	hotel_rooms_id int FOREIGN KEY REFERENCES dbo.hotel_rooms(hotel_rooms_id),
	convenient_id INT FOREIGN KEY REFERENCES dbo.convenient(convenient_id),
	CONSTRAINT hotel_convenient_pk PRIMARY KEY(hotel_id, hotel_rooms_id, convenient_id)
)
Go


CREATE TABLE services(
	service_id INT IDENTITY(1,1) PRIMARY KEY,
	service_name NVARCHAR(50) NOT NULL,
	service_image NVARCHAR(250)
)
go

CREATE TABLE hotel_service (
	hotel_id int FOREIGN KEY REFERENCES dbo.hotels(hotel_id),
	service_id int FOREIGN KEY REFERENCES dbo.services(service_id),
	unit_price float,
	CONSTRAINT sevices_hotels_pk PRIMARY KEY(hotel_id, service_id)
)
go


CREATE TABLE bookings ( 
	booking_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	user_id INT FOREIGN KEY REFERENCES dbo.users(user_id),
	time_booking DATE,
	total_booking_price float,
	payment_status nvarchar(250)
)
go

CREATE TABLE booking_hotel_detail(
	booking_detail_id INT PRIMARY KEY IDENTITY(1,1),
	booking_id INT FOREIGN KEY REFERENCES dbo.bookings(booking_id),
	hotel_id INT FOREIGN KEY REFERENCES dbo.hotels(hotel_id),
	hotel_rooms_id INT FOREIGN KEY REFERENCES dbo.hotel_rooms(hotel_rooms_id),
	from_date DATE,
	to_date DATE,
	total_price float,
	service_list nvarchar(250),
	total_services_price float
)
go

CREATE TABLE comments(
	comment_id int identity(1,1) PRIMARY KEY,
	hotel_id INT FOREIGN KEY REFERENCES dbo.hotels(hotel_id),
	user_id INT FOREIGN KEY REFERENCES dbo.users(user_id),
	content nvarchar(max),
	time_comment date,
)
go

create table banner(
	banner_id int identity(1,1) primary key,
	banner_image varchar(255)
)
go
