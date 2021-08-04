CREATE DATABASE AirportInfo
go
USE [AirportInfo]
GO
CREATE TABLE DepartureBoard
(
FlightNumber char(40) NOT NULL,
DepartureСountry VARCHAR(60) NOT NULL,
DepartureСity char(60) NOT NULL,
DepartureDate date NOT NULL,
DepartureTime time NOT NULL,
ArrivalСountry VARCHAR(60) NOT NULL,
ArrivaСity char(60) NOT NULL,
ArrivalDate date NULL,	
ArrivalTime time NULL,	
FlightTime time NULL,
CompanyName nvarchar(50) NOT NULL,
PlaneModel nvarchar(50) NOT NULL
)
GO
INSERT INTO [dbo].DepartureBoard
(FlightNumber,
DepartureСountry,
DepartureСity,
DepartureDate,
DepartureTime,
ArrivalСountry,
ArrivaСity,
ArrivalDate,
ArrivalTime,
FlightTime,
CompanyName,
PlaneModel) 
VALUES
(
'SU-1704',
'Россия',
'Москва',
'2021-07-26',
'18:25',
'Россия',
'Владивосток',
'2021-07-27',
'12:05',
'08:20',
'Aэрофлот',
'Boeing 777-300ER'
),
(
'SU-0104',
'Россия',
'Москва',
'2021-08-04',
'10:25',
'Соединенные Штаты Америки',
'Вашингтон',
'2021-08-04',
'04:05',
'10:25',
'Aэрофлот',
'Airbus A330-300'
)
GO
SELECT *FROM [dbo].DepartureBoard;
DROP DATABASE AirportInfo	 