--CREATE DATABASE AirportInfo;

CREATE TABLE DepartureAirBoard (
    [FlightNumber] SMALLINT NOT NULL,
    [Сity​AndCountryOfDeparture] VARCHAR (50) NOT NULL,
    [DateAndTimeOfDepartureAndArrival] datetimeoffset NOT NULL,
    [FlightTime] TIME NOT NULL,
    [Airline] VARCHAR (50) NOT NULL,
    [AirplaneMdel] VARCHAR (50) NOT NULL
);

INSERT into DepartureAirBoard
VALUES 
(722, 'Moscow, Russian Federation', '2020-10-23 12:45:37.1237 +01:0', '12:10:05.1237', 'Azur', 'Boeing' ),
(268, 'London, Great Britain', '2020-08-20 10:12:30.1237 +04:0', '04:12:15.1237', 'Unaited Airlines Holdings', 'Boeing' );

select * from DepartureAirBoard;

--DROP DATABASE AirportInfo;