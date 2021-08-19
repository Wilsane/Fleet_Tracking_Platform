create table Vehicles (
	Vehicle_Number varchar(4) PRIMARY KEY NOT NULL,
	Registration_Number int NOT NULL,
	Vehicle_Type varchar(40) NOT NULL,
	Manufacturer varchar(40) NOT NULL,
	Engine_Size varchar(40) NOT NULL,
	Current_odometer int NOT NULL,
	Next_Service_Reading int NOT NULL
);

create table TimeSheet(
	User_ID int PRIMARY KEY NOT NULL,
	Vehicle_Number varchar(4) NOT NULL,
	Hours_Worked int NOT NULL
);

create table Planned_Trips(
	Vehicle_Number varchar(4) PRIMARY KEY NOT NULL,
	Date_of_Trip Datetime NOT NULL,
	Trip_Destination varchar(50) NOT NULL,
	Trip_Distance int NOT NULL
);

create table Service_Appointments (
	Vehicle_Number varchar(4) PRIMARY KEY NOT NULL,
	Service_Required varchar(45) NOT NULL,
	Date_of_Appointment Datetime NOT NULL,
	Procedure_Code varchar(10) NOT NULL,
	Procedure_Description varchar(75) NOT NULL
);

create table Completed_Trips (
	Vehicle_Number varchar(4) PRIMARY KEY NOT NULL,
	Trip_Destination varchar(50) NOT NULL,
	Total_Distance_Travelled int NOT NULL
);

create table ServiceS_Completed (
	Vehicle_Number varchar(4) PRIMARY KEY NOT NULL,
	Date_of_Service Datetime NOT NULL,
	Service_Description varchar(75) NOT NULL,
	Service_Cost int NOT NULL
);

create table Service_Report(
	Vehicle_Number varchar(4) PRIMARY KEY NOT NULL,
	Date_of_Service Datetime NOT NULL,
	Date_Serviced Datetime NOT NULL,
	Service_Description varchar(75) NOT NULL
);

create table Service_Requirement(	
	Vehicle_Number varchar(4) PRIMARY KEY NOT NULL,
	Service_Type varchar(10) NOT NULL,
	Date_of_Appointment Datetime NOT NULL,
	Required_Service varchar(55) NOT NULL
);