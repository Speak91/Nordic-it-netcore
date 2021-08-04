CREATE DATABASE AirportInfo
go
USE [AirportInfo]
GO
CREATE TABLE DepartureBoard
(
FlightNumber char(40) NOT NULL,
Departure�ountry VARCHAR(60) NOT NULL,
Departure�ity char(60) NOT NULL,
DepartureDate date NOT NULL,
DepartureTime time NOT NULL,
Arrival�ountry VARCHAR(60) NOT NULL,
Arriva�ity char(60) NOT NULL,
ArrivalDate date NULL,	
ArrivalTime time NULL,	
FlightTime time NULL,
CompanyName nvarchar(50) NOT NULL,
PlaneModel nvarchar(50) NOT NULL
)
GO
INSERT INTO [dbo].DepartureBoard
(FlightNumber,
Departure�ountry,
Departure�ity,
DepartureDate,
DepartureTime,
Arrival�ountry,
Arriva�ity,
ArrivalDate,
ArrivalTime,
FlightTime,
CompanyName,
PlaneModel) 
VALUES
(
'SU-1704',
'������',
'������',
'2021-07-26',
'18:25',
'������',
'�����������',
'2021-07-27',
'12:05',
'08:20',
'A�������',
'Boeing 777-300ER'
),
(
'SU-0104',
'������',
'������',
'2021-08-04',
'10:25',
'����������� ����� �������',
'���������',
'2021-08-04',
'04:05',
'10:25',
'A�������',
'Airbus A330-300'
)
GO
SELECT *FROM [dbo].DepartureBoard;
DROP DATABASE AirportInfo	 