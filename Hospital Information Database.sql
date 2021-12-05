
/*
	TABLE OF CONTENTS:
	-1. PRELIMINARY DROP SCRIPTS
		-1.1 FOREIGN KEY CONSTRAINTS
			-1.1.1 DROP CONSTRAINT FK_Patients_Addresses_AddressID
			-1.1.2 DROP CONSTRAINT FK_Employees_Addresses_AddressID
			-1.1.3 DROP CONSTRAINT FK_Employees_Role_RoleID
			-1.1.4 DROP CONSTRAINT FK_Employees_Department_DepartmentID
			-1.1.5 DROP CONSTRAINT FK_Registrations_Patients_PatientID
			-1.1.6 DROP CONSTRAINT FK_Registrations_Rooms_RoomID
			-1.1.7 DROP CONSTRAINT FK_Reports_Registration_RegistrationID
			-1.1.8 DROP CONSTRAINT FK_Reports_Laboratories_LaboratoryID
			-1.1.9 DROP CONSTRAINT FK_Reports_Employees_EmployeeID
			-1.1.10 DROP CONSTRAINT FK_Billings_Registrations_RegistrationID
			
		-1.2 UNIQUE KEY CONSTAINTS
			-1.2.1 DROP CONSTRAINT UQ_Patients_PatientID
			-1.2.2 DROP CONSTRAINT UQ_Employees_EmployeeID
			-1.2.3 DROP CONSTRAINT UQ_Addresses_AddressID
			-1.2.4 DROP CONSTRAINT UQ_Registrations_RegistrationID
			-1.2.5 DROP CONSTRAINT UQ_Reports_ReportID
			-1.2.6 DROP CONSTRAINT UQ_Billings_BillID
	
		-1.3 DEFAULT CONSTRAINTS
			-1.3.1 DROP CONSTRAINT DF_Patients_CreatedOn
			-1.3.2 DROP CONSTRAINT DF_Employees_CreatedOn
			-1.3.3 DROP CONSTRAINT DF_Registrations_CreatedOn
			-1.3.4 DROP CONSTRAINT DF_Reports_CreatedOn
			-1.3.5 DROP CONSTRAINT DF_Billings_CreatedOn
			-1.3.6 DROP CONSTRAINT DF_Employees_Status
			-1.3.7 DROP CONSTRAINT DF_Registrations_Status
			-1.3.8 DROP CONSTRAINT DF_Laboratories_Status
			-1.3.9 DROP CONSTRAINT DF_Room_Status
			-1.3.10 DROP CONSTRAINT DF_Billings_Status
			
		-1.4 TABLES
			-1.4.1 DROP TABLE dbo.Addresses
			-1.4.2 DROP TABLE dbo.Patients
			-1.4.3 DROP TABLE dbo.Employees
			-1.4.4 DROP TABLE dbo.Roles
			-1.4.5 DROP TABLE dbo.Departments
			-1.4.6 DROP TABLE dbo.Registrations
			-1.4.7 DROP TABLE dbo.Laboratories
			-1.4.8 DROP TABLE dbo.Rooms
			-1.4.9 DROP TABLE dbo.Reports
			-1.4.10 DROP TABLE dbo.Billings
			
		-1.5 USER STORED PROCEDURES
			-1.5.1 DROP PROCEDURE dbo.USP_CreateAddress
			-1.5.2 DROP PROCEDURE dbo.USP_UpdateAddress
			-1.5.3 DROP PROCEDURE dbo.USP_DropAddress
			-1.5.4 DROP PROCEDURE dbo.USP_GetAddressInformation
			-1.5.5 DROP PROCEDURE dbo.USP_CreatePatient
			-1.5.6 DROP PROCEDURE dbo.USP_UpdatePatient
			-1.5.7 DROP PROCEDURE dbo.USP_DropPatient
			-1.5.8 DROP PROCEDURE dbo.USP_GetPaitentInformation
			-1.5.9 DROP PROCEDURE dbo.USP_CreateEmployee
			-1.5.10 DROP PROCEDURE dbo.USP_UpdateEmployee
			-1.5.11 DROP PROCEDURE dbo.USP_DropEmployee
			-1.5.12 DROP PROCEDURE dbo.USP_GetEmployeeInforamtion
			-1.5.13 DROP PROCEDURE dbo.USP_GetDepartmentEmployees
			-1.5.14 DROP PROCEDURE dbo.USP_GetEmployeeLogin
			-1.5.15 DROP PROCEDURE dbo.USP_CreateRegistration
			-1.5.16 DROP PROCEDURE dbo.USP_UpdateRegistration
			-1.5.17 DROP PROCEDURE dbo.USP_DropRegistration
			-1.5.18 DROP PROCEDURE dbo.USP_GetRegistrationInformation
			-1.5.19 DROP PROCEDURE dbo.USP_CreateReport
			-1.5.20 DROP PROCEDURE dbo.USP_UpdateReport
			-1.5.21 DROP PROCEDURE dbo.USP_DropReport
			-1.5.22 DROP PROCEDURE dbo.USP_GetReportInfomration
			-1.5.23 DROP PROCEDURE dbo.USP_GetRegistrationReport
			-1.5.24 DROP PROCEDURE dbo.USP_CreateBilling
			-1.5.25 DROP PROCEDURE dbo.USP_UpdateBilling
			-1.5.26 DROP PROCEDURE dbo.USP_DropBilling
			-1.5.27 DROP PROCEDURE dbo.USP_GetBillingInformation
			-1.5.28 DROP PROCEDURE dbo.USP_CreateLaboratory
			-1.5.29 DROP PROCEDURE dbo.USP_UpdateLaboratory
			-1.5.30 DROP PROCEDURE dbo.USP_DropLaboratory
			-1.5.31 DROP PROCEDURE dbo.USP_GetLaboratoryInformation
			-1.5.32 DROP PROCEDURE dbo.USP_OpenLaboratory
			-1.5.33 DROP PROCEDURE dbo.USP_CreateRoom
			-1.5.34 DROP PROCEDURE dbo.USP_UpdateRoom
			-1.5.35 DROP PROCEDURE dbo.USP_DropRoom
			-1.5.36 DROP PROCEDURE dbo.USP_GetRoomInformation
			-1.5.37 DROP PROCEDURE dbo.USP_OpenRoom
			
	0. CREATE FUNCTIONS (FN)
		0.1 CREATE FUNCTION dbo.FN_CalculateAge
	
	1. CREATE TABLES
		1.1 CREATE TABLE dbo.Addresses
		1.2 CREATE TABLE dbo.Patients
		1.3 CREATE TABLE dbo.Employees
		1.4 CREATE TABLE dbo.Roles
		1.5 CREATE TABLE dbo.Departments
		1.6 CREATE TABLE dbo.Registrations
		1.7 CREATE TABLE dbo.Laboratories
		1.8 CREATE TABLE dbo.Rooms
		1.9 CREATE TABLE dbo.Reports
		1.10 CREATE TABLE dbo.Billings
	
	2. CREATE CONSTRAINTS (FK, UQ, DF)
		2.1 FOREIGN KEY CONSTRAINTS 'FK_{FOREIGN Table}_{PRIMARY Table}_{Key}'
			2.1.1 ADD CONSTRAINT FK_Patients_Addresses_AddressID
			2.1.2 ADD CONSTRAINT FK_Employees_Addresses_AddressID
			2.1.3 ADD CONSTRAINT FK_Employees_Role_RoleID
			2.1.4 ADD CONSTRAINT FK_Employees_Department_DepartmentID
			2.1.5 ADD CONSTRAINT FK_Registrations_Patients_PatientID
			2.1.6 ADD CONSTRAINT FK_Registrations_Rooms_RoomID
			2.1.7 ADD CONSTRAINT FK_Reports_Registration_RegistrationID
			2.1.8 ADD CONSTRAINT FK_Reports_Laboratories_LaboratoryID
			2.1.9 ADD CONSTRAINT FK_Reports_Employees_EmployeeID
			2.1.10 ADD CONSTRAINT FK_Billings_Registrations_RegistrationID
		
		2.2 UNIQUE KEY CONSTRAINTS 'UQ_{PK Table}_{Key}'
			2.2.1 ADD CONSTRAINT UQ_Patients_PatientID
			2.2.2 ADD CONSTRAINT UQ_Employees_EmployeeID
			2.2.3 ADD CONSTRAINT UQ_Addresses_AddressID
			2.2.4 ADD CONSTRAINT UQ_Registrations_RegistrationID
			2.2.5 ADD CONSTRAINT UQ_Reports_ReportID
			2.2.6 ADD CONSTRAINT UQ_Billings_BillID
		
		2.3 DEFAULT CONSTRAINTS 'DF_{Table}_{Key}'
			2.3.1 ADD CONSTRAINT DF_Patients_CreatedOn
			2.3.2 ADD CONSTRAINT DF_Employees_CreatedOn
			2.3.3 ADD CONSTRAINT DF_Registrations_CreatedOn
			2.3.4 ADD CONSTRAINT DF_Reports_CreatedOn
			2.3.5 ADD CONSTRAINT DF_Billings_CreatedOn
			2.3.6 ADD CONSTRAINT DF_Employees_Status
			2.3.7 ADD CONSTRAINT DF_Registrations_Status
			2.3.8 ADD CONSTRAINT DF_Laboratories_Status
			2.3.9 ADD CONSTRAINT DF_Room_Status
			2.3.10 ADD CONSTRAINT DF_Billings_Status
			
	3. CREATE USER STORED PROCEDURES (USP)
		3.1 dbo.Addresses
			3.1.1 CREATE PROCEDURE dbo.USP_CreateAddress
			3.1.2 CREATE PROCEDURE dbo.USP_UpdateAddress
			3.1.3 CREATE PROCEDURE dbo.USP_DropAddress
			3.1.4 CREATE PROCEDURE dbo.USP_GetAddressInformation
		3.2 dbo.Patients
			3.2.1 CREATE PROCEDURE dbo.USP_CreatePatient
			3.2.2 CREATE PROCEDURE dbo.USP_UpdatePatient
			3.2.3 CREATE PROCEDURE dbo.USP_DropPatient
			3.2.4 CREATE PROCEDURE dbo.USP_GetPaitentInformation
			3.2.5 CREATE PROCEDURE dbo.USP_GetPatientRegistration
		3.3 dbo.Employees
			3.3.1 CREATE PROCEDURE dbo.USP_CreateEmployee
			3.3.2 CREATE PROCEDURE dbo.USP_UpdateEmployee
			3.3.3 CREATE PROCEDURE dbo.USP_DropEmployee
			3.3.4 CREATE PROCEDURE dbo.USP_GetEmployeeInforamtion
			3.3.5 CREATE PROCEDURE dbo.USP_GetDepartmentEmployees
			3.3.6 CREATE PROCEDURE dbo.USP_GetEmployeeLogin
		3.4 dbo.Registrations
			3.4.1 CREATE PROCEDURE dbo.USP_CreateRegistration
			3.4.2 CREATE PROCEDURE dbo.USP_UpdateRegistration
			3.4.3 CREATE PROCEDURE dbo.USP_DropRegistration
			3.4.4 CREATE PROCEDURE dbo.USP_GetRegistrationInformation
		3.5 dbo.Reports
			3.5.1 CREATE PROCEDURE dbo.USP_CreateReport
			3.5.2 CREATE PROCEDURE dbo.USP_UpdateReport
			3.5.3 CREATE PROCEDURE dbo.USP_DropReport
			3.5.4 CREATE PROCEDURE dbo.USP_GetReportInfomration
			3.5.5 CREATE PROCEDURE dbo.USP_GetRegistrationReport
		3.6 dbo.Billings
			3.6.1 CREATE PROCEDURE dbo.USP_CreateBilling
			3.6.2 CREATE PROCEDURE dbo.USP_UpdateBilling
			3.6.3 CREATE PROCEDURE dbo.USP_DropBilling
			3.6.4 CREATE PROCEDURE dbo.USP_GetBillingInformation
		3.7 dbo.Laboratories
			3.7.1 CREATE PROCEDURE dbo.USP_CreateLaboratory
			3.7.2 CREATE PROCEDURE dbo.USP_UpdateLaboratory
			3.7.3 CREATE PROCEDURE dbo.USP_DropLaboratory
			3.7.4 CREATE PROCEDURE dbo.USP_GetLaboratoryInformation
			3.7.4 CREATE PROCEDURE dbo.USP_OpenLaboratory
		3.8 dbo.Rooms
			3.8.1 CREATE PROCEDURE dbo.USP_CreateRoom
			3.8.2 CREATE PROCEDURE dbo.USP_UpdateRoom
			3.8.3 CREATE PROCEDURE dbo.USP_DropRoom
			3.8.4 CREATE PROCEDURE dbo.USP_GetRoomInformation
			3.8.4 CREATE PROCEDURE dbo.USP_OpenRoom
		3.9 dbo.Departments
			3.9.1 CREATE PROCEDURE dbo.USP_GetDepartmentInformation
		3.10 dbo.Roles
			3.10.1 CREATE PROCEDURE dbo.USP_GetRoleInformation
			
	4. CREATE VIEWS 
		4.1 CREATE VIEW V_Patients
		4.2 CREATE VIEW V_Employees
		4.3 CREATE VIEW V_Roles
		4.4 CREATE VIEW V_Departments
		4.5 CREATE VIEW V_Registrations
		4.6 CREATE VIEW V_Rooms
		4.7 CREATE VIEW V_Laboratories
		4.8 CREATE VIEW V_Reports
		4.9 CREATE VIEW V_Billings
	
	5. INSERT VALUES INTO TABLE
*/


/********************************
-- -1. PRELIMINARY DROP SCRIPTS
********************************/

-- -1.1 FOREIGN KEY CONSTRAINTS

-- -1.1.1 DROP CONSTRAINT FK_Patients_Addresses_AddressID
ALTER TABLE dbo.Patients DROP CONSTRAINT [FK_Patients_Addresses_AddressID]
-- -1.1.2 DROP CONSTRAINT FK_Employees_Addresses_AddressID
ALTER TABLE dbo.Employees DROP CONSTRAINT [FK_Employees_Addresses_AddressID]
-- -1.1.3 DROP CONSTRAINT FK_Employees_Role_RoleID
ALTER TABLE dbo.Employees DROP CONSTRAINT [FK_Employees_Role_RoleID]
-- -1.1.4 DROP CONSTRAINT FK_Employees_Department_DepartmentID
ALTER TABLE dbo.Employees DROP CONSTRAINT [FK_Employees_Department_DepartmentID]
-- -1.1.5 DROP CONSTRAINT FK_Registrations_Patients_PatientID
ALTER TABLE dbo.Registrations DROP CONSTRAINT [FK_Registrations_Patients_PatientID]
-- -1.1.6 DROP CONSTRAINT FK_Registrations_Rooms_RoomID
ALTER TABLE dbo.Registrations DROP CONSTRAINT [FK_Registrations_Rooms_RoomID]
-- -1.1.7 DROP CONSTRAINT FK_Reports_Registration_RegistrationID
ALTER TABLE dbo.Reports DROP CONSTRAINT [FK_Reports_Registration_RegistrationID]
-- -1.1.8 DROP CONSTRAINT FK_Reports_Laboratories_LaboratoryID
ALTER TABLE dbo.Reports DROP CONSTRAINT [FK_Reports_Laboratories_LaboratoryID]
-- -1.1.9 DROP CONSTRAINT FK_Reports_Employees_EmployeeID
ALTER TABLE dbo.Reports DROP CONSTRAINT [FK_Reports_Employees_EmployeeID]
-- -1.1.10 DROP CONSTRAINT FK_Billings_Registrations_RegistrationID
ALTER TABLE dbo.Billings DROP CONSTRAINT [FK_Billings_Registrations_RegistrationID]

-- -1.2 UNIQUE KEY CONSTAINTS

-- -1.2.1 DROP CONSTRAINT UQ_Patients_PatientID
ALTER TABLE dbo.Patients DROP CONSTRAINT [UQ_Patients_PatientID]
-- -1.2.2 DROP CONSTRAINT UQ_Employees_EmployeeID
ALTER TABLE dbo.Employees DROP CONSTRAINT [UQ_Employees_EmployeeID]
-- -1.2.3 DROP CONSTRAINT UQ_Addresses_AddressID
ALTER TABLE dbo.Addresses DROP CONSTRAINT [UQ_Addresses_AddressID]
-- -1.2.4 DROP CONSTRAINT UQ_Registrations_RegistrationID
ALTER TABLE dbo.Registrations DROP CONSTRAINT [UQ_Registrations_RegistrationID]
-- -1.2.5 DROP CONSTRAINT UQ_Reports_ReportID
ALTER TABLE dbo.Reports DROP CONSTRAINT [UQ_Reports_ReportID]
-- -1.2.6 DROP CONSTRAINT UQ_Billings_BillID
ALTER TABLE dbo.Billings DROP CONSTRAINT [UQ_Billings_BillID]

-- -1.3 DEFAULT CONSTRAINTS

-- -1.3.1 DROP CONSTRAINT DF_Patients_CreatedOn
ALTER TABLE dbo.Patients DROP CONSTRAINT [DF_Patients_CreatedOn]
-- -1.3.2 DROP CONSTRAINT DF_Employees_CreatedOn
ALTER TABLE dbo.Employees DROP CONSTRAINT [DF_Employees_CreatedOn]
-- -1.3.3 DROP CONSTRAINT DF_Registrations_CreatedOn
ALTER TABLE dbo.Registrations DROP CONSTRAINT [DF_Registrations_CreatedOn]
-- -1.3.4 DROP CONSTRAINT DF_Reports_CreatedOn
ALTER TABLE dbo.Reports DROP CONSTRAINT [DF_Reports_CreatedOn]
-- -1.3.5 DROP CONSTRAINT DF_Billings_CreatedOn
ALTER TABLE dbo.Billings DROP CONSTRAINT [DF_Billings_CreatedOn]
-- -1.3.6 DROP CONSTRAINT DF_Employees_Status
ALTER TABLE dbo.Emplyoees DROP CONSTRAINT [DF_Employees_Status]
-- -1.3.7 DROP CONSTRAINT DF_Registrations_Status
ALTER TABLE dbo.Registrations DROP CONSTRAINT [DF_Registrations_Status]
-- -1.3.8 DROP CONSTRAINT DF_Laboratories_Status
ALTER TABLE dbo.Laboratories DROP CONSTRAINT [DF_Laboratories_Status]
-- -1.3.9 DROP CONSTRAINT DF_Room_Status
ALTER TABLE dbo.Room DROP CONSTRAINT [DF_Room_Status]
-- -1.3.10 DROP CONSTRAINT DF_Billings_Status
ALTER TABLE dbo.Billings DROP CONSTRAINT [DF_Billings_Status]

-- -1.4 TABLES

-- -1.4.1 DROP TABLE dbo.Addresses
DROP TABLE dbo.Addresses
-- -1.4.2 DROP TABLE dbo.Patients
DROP TABLE dbo.Patients
-- -1.4.3 DROP TABLE dbo.Employees
DROP TABLE dbo.Employees
-- -1.4.4 DROP TABLE dbo.Roles
DROP TABLE dbo.Roles
-- -1.4.5 DROP TABLE dbo.Departments
DROP TABLE dbo.Departments
-- -1.4.6 DROP TABLE dbo.Registrations
DROP TABLE dbo.Registrations
-- -1.4.7 DROP TABLE dbo.Laboratories
DROP TABLE dbo.Laboratories
-- -1.4.8 DROP TABLE dbo.Rooms
DROP TABLE dbo.Rooms
-- -1.4.9 DROP TABLE dbo.Reports
DROP TABLE dbo.Reports
-- -1.4.10 DROP TABLE dbo.Billings
DROP TABLE dbo.Billings
GO

/********************************
-- 0. CREATE FUNCTIONS (FN)
********************************/

CREATE FUNCTION dbo.FN_CalculateAge (
	@Birthdate DATETIME
) 
RETURNS INT
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @Age INT;
	
	SELECT @Age = DATEDIFF(YY, @Birthdate, @Today) - 
	CASE WHEN(
		(MONTH(@Birthdate)*100 + DAY(@Birthdate)) >	(MONTH(@Today)*100 + DAY(@Today))
	) THEN 1 ELSE 0 END

	RETURN @Age
END
GO

/********************************
-- 1. CREATE TABLES
********************************/

-- 1.1 CREATE TABLE dbo.Addresses
CREATE TABLE [dbo].[Addresses](
	[AddressID] INT IDENTITY(1,1) NOT NULL,
	[Address1] VARCHAR(50) NULL,
	[Address2] VARCHAR(50) NULL,
	[City] VARCHAR(50) NULL,
	[Province] VARCHAR(50) NULL,
	[Zipcode] VARCHAR(50) NULL,
	[Country] VARCHAR(50) NULL
	PRIMARY KEY CLUSTERED ( [AddressID] ASC )
)
GO

-- 1.2 CREATE TABLE dbo.Patients
CREATE TABLE [dbo].[Patients](
	[PatientID] INT IDENTITY(1,1) NOT NULL,
	[AddressID] INT NULL,
	[FirstName] VARCHAR(50) NULL,
	[MiddleName] VARCHAR(50) NULL,
	[LastName] VARCHAR(50) NULL,
	[Birthdate] DATE NULL,
	[Age] INT NULL,
	[Gender] VARCHAR(50) NULL,
	[Religion] VARCHAR(50) NULL,
	[Email] VARCHAR(50) NULL,
	[PhoneNumber] VARCHAR(50) NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED ( [PatientID] ASC ) 
)
GO

-- 1.3 CREATE TABLE dbo.Employees
CREATE TABLE [dbo].[Employees](
	[EmployeeID] INT IDENTITY(1,1) NOT NULL,
	[AddressID] INT NULL,
	[RoleID] INT NULL,
	[DepartmentID] INT NULL,
	[Status] BIT NULL,
	[Password] VARCHAR(50) NULL,
	[FirstName] VARCHAR(50) NULL,
	[MiddleName] VARCHAR(50) NULL,
	[LastName] VARCHAR(50) NULL,
	[Birthdate] DATE NULL,
	[Age] INT NULL,
	[Gender] VARCHAR(50) NULL,
	[Religion] VARCHAR(50) NULL,
	[Email] VARCHAR(50) NULL,
	[PhoneNumber] VARCHAR(50) NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED ( [EmployeeID] ASC )
)
GO

-- 1.4 CREATE TABLE dbo.Roles
CREATE TABLE [dbo].[Roles](
	[RoleID] INT NOT NULL,
	[Description] VARCHAR(50) NULL
	PRIMARY KEY CLUSTERED ( [RoleID] ASC )
)
GO

-- 1.5 CREATE TABLE dbo.Departments
CREATE TABLE [dbo].[Departments](
	[DepartmentID] INT IDENTITY(1,1) NOT NULL,
	[Description] VARCHAR(50) NULL,
	[Fee] INT NULL
	PRIMARY KEY CLUSTERED ( [DepartmentID] ASC )  
)
GO

-- 1.6 CREATE TABLE dbo.Registrations
CREATE TABLE [dbo].[Registrations](
	[RegistrationID] INT IDENTITY(1,1) NOT NULL,
	[PatientID] INT NOT NULL,
	[RoomID] INT NULL,
	[Status] BIT NULL,
	[AdmissionOn] DATETIME NULL,
	[DischargeOn] DATETIME NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED ( [RegistrationID] ASC )
)

-- 1.7 CREATE TABLE dbo.Laboratories
CREATE TABLE [dbo].[Laboratories](
	[LaboratoryID] INT IDENTITY(1,1) NOT NULL,
	[LaboratoryNumber] VARCHAR(50) NULL,
	[Status] BIT NULL,
	[Fee] INT NULL
	PRIMARY KEY CLUSTERED ( [LaboratoryID] ASC ) 
)
GO

-- 1.8 CREATE TABLE dbo.Rooms
CREATE TABLE [dbo].[Rooms](
	[RoomID] INT IDENTITY(1,1) NOT NULL,
	[RoomNumber] VARCHAR(50) NULL,
	[Status] BIT NULL,
	[Fee] INT NULL
	PRIMARY KEY CLUSTERED ( [RoomID] ASC ) 
)
GO

-- 1.9 CREATE TABLE dbo.Reports
CREATE TABLE [dbo].[Reports] (
	[ReportID] INT IDENTITY(1,1) NOT NULL,
	[RegistrationID] INT NULL,
	[DepartmentID] INT NOT NULL,
	[EmployeeID] INT NOT NULL,
	[LaboratoryID] INT NULL,
	[Report] VARCHAR(50) NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED ( [ReportID] ASC )
)
GO

-- 1.10 CREATE TABLE dbo.Billings
CREATE TABLE [dbo].[Billings](
	[BillingID] INT IDENTITY(1,1) NOT NULL,
	[RegistrationID] INT NOT NULL,
	[LaboratoryFee] INT NULL,
	[RoomFee] INT NULL,
	[DepartmentFee] INT NULL,
	[Status] BIT NULL,
	[Total] INT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED ([BillingID] ASC )
)
GO

/********************************
-- 2. CREATE CONSTRAINTS (FK, UQ, DF)
********************************/

-- 2.1 FOREIGN KEY CONSTRAINTS 'FK_{FOREIGN Table}_{PRIMARY Table}_{Key}'

-- 2.1.1 ADD CONSTRAINT FK_Patients_Addresses_AddressID
ALTER TABLE dbo.Patients WITH CHECK ADD CONSTRAINT [FK_Patients_Addresses_AddressID] FOREIGN KEY ([AddressID]) REFERENCES dbo.Addresses (AddressID)
-- 2.1.2 ADD CONSTRAINT FK_Employees_Addresses_AddressID
ALTER TABLE dbo.Employees WITH CHECK ADD CONSTRAINT [FK_Employees_Addresses_AddressID] FOREIGN KEY ([AddressID]) REFERENCES dbo.Addresses (AddressID)
-- 2.1.3 ADD CONSTRAINT FK_Employees_Role_RoleID
ALTER TABLE dbo.Employees WITH CHECK ADD CONSTRAINT [FK_Employees_Roles_RoleID] FOREIGN KEY ([RoleID]) REFERENCES dbo.Roles (RoleID)
-- 2.1.4 ADD CONSTRAINT FK_Employees_Departments_DepartmentID
ALTER TABLE dbo.Employees WITH CHECK ADD CONSTRAINT [FK_Employees_Departments_DepartmentID] FOREIGN KEY ([DepartmentID]) REFERENCES dbo.Departments (DepartmentID)
-- 2.1.5 ADD CONSTRAINT FK_Registrations_Patients_PatientID
ALTER TABLE dbo.Registrations WITH CHECK ADD CONSTRAINT [FK_Registrations_Patients_PatientID] FOREIGN KEY ([PatientID]) REFERENCES dbo.Patients (PatientID)
-- 2.1.6 ADD CONSTRAINT FK_Registrations_Rooms_RoomID
ALTER TABLE dbo.Registrations WITH CHECK ADD CONSTRAINT [FK_Registrations_Rooms_RoomID] FOREIGN KEY ([RoomID]) REFERENCES dbo.Rooms (RoomID)
-- 2.1.7 ADD CONSTRAINT FK_Reports_Registration_RegistrationID
ALTER TABLE dbo.Reports WITH CHECK ADD CONSTRAINT [FK_Reports_Registration_RegistrationID] FOREIGN KEY ([RegistrationID]) REFERENCES dbo.Registrations (RegistrationID)
-- 2.1.8 ADD CONSTRAINT FK_Reports_Laboratories_LaboratoryID
ALTER TABLE dbo.Reports WITH CHECK ADD CONSTRAINT [FK_Reports_Laboratories_LaboratoryID] FOREIGN KEY ([LaboratoryID]) REFERENCES dbo.Laboratories (LaboratoryID)
-- 2.1.9 ADD CONSTRAINT FK_Reports_Employees_EmployeeID
ALTER TABLE dbo.Reports WITH CHECK ADD CONSTRAINT [FK_Reports_Employees_EmployeeID] FOREIGN KEY (EmployeeID) REFERENCES dbo.Employees (EmployeeID)
-- 2.1.10 ADD CONSTRAINT FK_Billings_Registrations_RegistrationID
ALTER TABLE dbo.Billings WITH CHECK ADD CONSTRAINT [FK_Billings_Registrations_RegistrationID] FOREIGN KEY ([RegistrationID]) REFERENCES dbo.Registrations (RegistrationID)



-- 2.2 UNIQUE KEY CONSTRAINTS 'UQ_{PK Table}_{Key}'

-- 2.2.1 ADD CONSTRAINT UQ_Patients_PatientID
ALTER TABLE dbo.Patients ADD CONSTRAINT UQ_Patients_PatientID UNIQUE NONCLUSTERED (PatientID)
-- 2.2.2 ADD CONSTRAINT UQ_Employees_EmployeeID
ALTER TABLE dbo.Employees ADD CONSTRAINT UQ_Employees_EmployeeID UNIQUE NONCLUSTERED (EmployeeID)
-- 2.2.3 ADD CONSTRAINT UQ_Addresses_AddressID
ALTER TABLE dbo.Addresses ADD CONSTRAINT UQ_Addresses_AddressID UNIQUE NONCLUSTERED (AddressID)
-- 2.2.4 ADD CONSTRAINT UQ_Registrations_RegistrationID
ALTER TABLE dbo.Registrations ADD CONSTRAINT UQ_Registrations_RegistrationID UNIQUE NONCLUSTERED (RegistrationID)
-- 2.2.5 ADD CONSTRAINT UQ_Reports_ReportID
ALTER TABLE dbo.Reports ADD CONSTRAINT UQ_Reports_ReportID UNIQUE NONCLUSTERED (ReportID)
-- 2.2.6 ADD CONSTRAINT UQ_Billings_BillID
ALTER TABLE dbo.Billings ADD CONSTRAINT UQ_Billings_BillID UNIQUE NONCLUSTERED (BillingID)



-- 2.3 DEFAULT CONSTRAINTS 'DF_{Table}_{Key}'

-- 2.3.1 ADD CONSTRAINT DF_Patients_CreatedOn
ALTER TABLE dbo.Patients ADD CONSTRAINT DF_Patients_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
-- 2.3.2 ADD CONSTRAINT DF_Employees_CreatedOn
ALTER TABLE dbo.Employees ADD CONSTRAINT DF_Employees_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
-- 2.3.3 ADD CONSTRAINT DF_Registrations_CreatedOn
ALTER TABLE dbo.Registrations ADD CONSTRAINT DF_Registrations_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
-- 2.3.4 ADD CONSTRAINT DF_Reports_CreatedOn
ALTER TABLE dbo.Reports ADD CONSTRAINT DF_Reports_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
-- 2.3.5 ADD CONSTRAINT DF_Billings_CreatedOn
ALTER TABLE dbo.Billings ADD CONSTRAINT DF_Billings_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
-- 2.3.6 ADD CONSTRAINT DF_Employees_Status
ALTER TABLE dbo.Employees ADD CONSTRAINT DF_Employees_Status DEFAULT 0 FOR [Status]
-- 2.3.7 ADD CONSTRAINT DF_Registrations_Status
ALTER TABLE dbo.Registrations ADD CONSTRAINT DF_Registrations_Status DEFAULT 0 FOR [Status]
-- 2.3.8 ADD CONSTRAINT DF_Laboratories_Status
ALTER TABLE dbo.Laboratories ADD CONSTRAINT DF_Laboratories_Status DEFAULT 0 FOR [Status]
-- 2.3.9 ADD CONSTRAINT DF_Room_Status
ALTER TABLE dbo.Rooms ADD CONSTRAINT DF_Room_Status DEFAULT 0 FOR [Status]
-- 2.3.10 ADD CONSTRAINT DF_Billings_Status
ALTER TABLE dbo.Billings ADD CONSTRAINT DF_Billings_Status DEFAULT 0 FOR [Status]

/********************************
-- 3. CREATE USER STORED PROCEDURES (USP)
********************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 3.1 dbo.Addresses

-- 3.1.1 CREATE PROCEDURE dbo.USP_CreateAddress
CREATE PROCEDURE dbo.USP_CreateAddress 
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Addresses (Address1, Address2, City, Province, Zipcode, Country)
	VALUES (@Address1, @Address2, @City, @Province, @Zipcode, @Country)
END
GO

-- 3.1.2 CREATE PROCEDURE dbo.USP_UpdateAddress
CREATE PROCEDURE dbo.USP_UpdateAddress
	@AddressID INT,
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	UPDATE dbo.Addresses
	SET 
		Address1 = @Address1, 
		Address2 = @Address2, 
		City = @City, 
		Province = @Province, 
		Zipcode = @Zipcode, 
		Country = @Country
	WHERE AddressID = @AddressID
END
GO

-- 3.1.3 CREATE PROCEDURE dbo.USP_DropAddress
CREATE PROCEDURE dbo.USP_DropAddress
	@AddressID INT
AS
BEGIN
	DELETE FROM dbo.Addresses WHERE AddressID = @AddressID
END
GO

-- 3.1.4 CREATE PROCEDURE dbo.USP_GetAddressInformation
CREATE PROCEDURE dbo.USP_GetAddressInformation
	@AddressID INT
AS
BEGIN
	SELECT *
	FROM dbo.Addresses
	WHERE AddressID = @AddressID
END
GO



-- 3.2 dbo.Patients

-- 3.2.1 CREATE PROCEDURE dbo.USP_CreatePatient
CREATE PROCEDURE dbo.USP_CreatePatient 
	@FirstName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@LastName VARCHAR(50),
	@Birthdate DATE,
	@Gender VARCHAR(50),
	@Religion VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @AddressNumber INT;
	
	EXEC dbo.USP_CreateAddress @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
	
	SET @AddressNumber = (SELECT MAX(AddressID) FROM dbo.Addresses)
	
	
	INSERT INTO dbo.Patients (AddressID, FirstName, MiddleName, LastName, Birthdate, Age, Gender, Religion, Email, PhoneNumber, CreatedOn)
	VALUES (@AddressNumber, @FirstName, @MiddleName, @LastName, @Birthdate, dbo.FN_CalculateAge(@Birthdate), @Gender, @Religion, @Email, @PhoneNumber, @Today)
END
GO

-- 3.2.2 CREATE PROCEDURE dbo.USP_UpdatePatient
CREATE PROCEDURE dbo.USP_UpdatePatient 
	@PatientID INT,
	@FirstName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@LastName VARCHAR(50),
	@Birthdate DATE,
	@Gender VARCHAR(50),
	@Religion VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.PatientDetails WHERE @PatientID = PatientID);
		
	UPDATE dbo.Patients
	SET 
		FirstName = @FirstName, 
		MiddleName = @MiddleName, 
		LastName = @LastName, 
		Birthdate = @Birthdate, 
		Age = dbo.FN_CalculateAge(@Birthdate),
		Gender = @Gender, 
		Religion = @Religion, 
		Email = @Email, 
		PhoneNumber = @PhoneNumber, 
		ModifiedOn = @Today
	WHERE PatientID = @PatientID

	EXEC dbo.USP_UpdateAddress @AddressID = @AddressNumber, @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
END
GO

-- 3.2.3 CREATE PROCEDURE dbo.USP_DropPatient
CREATE PROCEDURE dbo.USP_DropPatient
	@PatientID INT
AS
BEGIN
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.Patients WHERE PatientID = @PatientID);
	
	DELETE FROM dbo.Patients WHERE PatientID = @PatientID
	
	EXEC dbo.USP_DropAddress @AddressID = @AddressNumber
END
GO

-- 3.2.4 CREATE PROCEDURE dbo.USP_GetPaitentInformation
CREATE PROCEDURE dbo.USP_GetPaitentInformation
	@PatientID INT
AS
BEGIN
	SELECT *
	FROM dbo.Patients
	WHERE PatientID = @PatientID
END
GO

-- 3.2.5 CREATE PROCEDURE dbo.USP_GetPatientRegistration
CREATE PROCEDURE dbo.USP_GetPatientRegistration
	@PatientID INT
AS
BEGIN
	SELECT *
	FROM dbo.Registrations
	WHERE PatientID = @PatientID
END
GO



-- 3.3 dbo.Employees

-- 3.3.1 CREATE PROCEDURE dbo.USP_CreateEmployee



-- 3.3 dbo.Employees

-- 3.3.1 CREATE PROCEDURE dbo.USP_CreateEmployee
CREATE PROCEDURE dbo.USP_CreateEmployee
	@RoleID INT,
	@DepartmentID INT,
	@Password VARCHAR(50),
	@FirstName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@LastName VARCHAR(50),
	@Birthdate DATE,
	@Gender VARCHAR(50),
	@Religion VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @AddressNumber INT;

	-- Create ID
	EXEC dbo.USP_CreateAddress @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
	
	-- Retrieve ID
	SET @AddressNumber = (SELECT MAX(AddressID) FROM dbo.Addresses)
	
	-- Create ID
	INSERT INTO dbo.Employees (AddressID, RoleID, DepartmentID, Password, FirstName, MiddleName, LastName, Birthdate, Age, Gender, Religion, Email, PhoneNumber, CreatedOn) 
	VALUES (@AddressNumber, @RoleID, @DepartmentID, @Password, @FirstName, @MiddleName, @LastName, @Birthdate, dbo.FN_CalculateAge(@Birthdate), @Gender, @Religion, @Email, @PhoneNumber, @Today)
	
END
GO

-- 3.3.2 CREATE PROCEDURE dbo.USP_UpdateEmployee
CREATE PROCEDURE dbo.USP_UpdateEmployee
	@EmployeeID INT,
	@RoleID INT,
	@DepartmentID INT,
	@Status BIT,
	@Password VARCHAR(50),
	@FirstName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@LastName VARCHAR(50),
	@Birthdate DATE,
	@Gender VARCHAR(50),
	@Religion VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.Employees WHERE EmployeeID = @EmployeeID);
	
	UPDATE dbo.Employees
	SET 
		RoleID = @RoleID,
		DepartmentID = @DepartmentID,
		Status = @Status,
		Password = @Password, 
		FirstName = @FirstName, 
		MiddleName = @MiddleName, 
		LastName = @LastName, 
		Birthdate = @Birthdate, 
		Age = dbo.FN_CalculateAge(@Birthdate),
		Gender = @Gender, 
		Religion = @Religion, 
		Email = @Email, 
		PhoneNumber = @PhoneNumber, 
		ModifiedOn = @Today
	WHERE EmployeeID = @EmployeeID

	EXEC dbo.USP_UpdateAddress @AddressID = @AddressNumber, @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
END
GO
-- 3.3.3 CREATE PROCEDURE dbo.USP_DropEmployee
CREATE PROCEDURE dbo.USP_DropEmployee 
	@EmployeeID INT
AS
BEGIN
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.Employees WHERE EmployeeID = @EmployeeID);
	
	DELETE FROM dbo.Employees WHERE EmployeeID = @EmployeeID
	
	EXEC dbo.USP_DropAddress @AddressID = @AddressNumber
END
GO

-- 3.3.4 CREATE PROCEDURE dbo.USP_GetEmployeeInforamtion
CREATE PROCEDURE dbo.USP_GetEmployeeInforamtion
	@EmployeeID INT
AS
BEGIN
	SELECT *
	FROM dbo.Employees
	WHERE EmployeeID = @EmployeeID
END
GO

-- 3.3.5 CREATE PROCEDURE dbo.USP_GetDepartmentEmployees
CREATE PROCEDURE dbo.USP_GetDepartmentEmployees
	@EmployeeID INT,
	@DepartmentID INT
AS
BEGIN
	SELECT *
	FROM dbo.Employees
	WHERE EmployeeID = @EmployeeID AND DepartmentID = @DepartmentID
END
GO

-- 3.3.6 CREATE PROCEDURE dbo.USP_GetEmployeeLogin
CREATE PROCEDURE dbo.USP_GetEmployeeLogin
	@Email VARCHAR(50),
	@Password VARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.Employees
	WHERE Email = @Email AND Password = @Password
END
GO

-- 3.4 dbo.Registrations

-- 3.4.1 CREATE PROCEDURE dbo.USP_CreateRegistration
CREATE PROCEDURE dbo.USP_CreateRegistration
	@PatientID INT,
	@RoomID INT,
	@AdmissionOn DATETIME,
	@DischargeOn DATETIME
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
		
	UPDATE dbo.Rooms
	SET
		Status = 1
	WHERE RoomID = @RoomID
	
	INSERT INTO dbo.Registrations (PatientID, RoomID, AdmissionOn, DischargeOn, CreatedOn)
	VALUES (@PatientID, @RoomID, @AdmissionOn, @DischargeOn, @Today)
END
GO

-- 3.4.2 CREATE PROCEDURE dbo.USP_UpdateRegistration
CREATE PROCEDURE dbo.USP_UpdateRegistration
	@RegistrationID INT,
	@PatientID INT,
	@RoomID INT,
	@Status INT,
	@AdmissionOn DATETIME,
	@DischargeOn DATETIME
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	
	UPDATE dbo.Registrations
	SET
		PatientID = @PatientID,
		RoomID = @RoomID,
		Status = @Status,
		AdmissionOn = @AdmissionOn,
		DischargeOn = @DischargeOn,
		ModifiedOn = @Today
	WHERE RegistrationID = @RegistrationID
END
GO

-- 3.4.3 CREATE PROCEDURE dbo.USP_DropRegistration
CREATE PROCEDURE dbo.USP_DropRegistration
	@RegistrationID INT
AS
BEGIN
	DECLARE @RoomID INT;
	DECLARE @LaboratoryID INT;

	SET @RoomID = (SELECT RoomID FROM dbo.Registrations WHERE RegistrationID = @RegistrationID)

	UPDATE dbo.Rooms
	SET
		Status = 0
	WHERE RoomID = @RoomID

	DELETE FROM dbo.Billings WHERE RegistrationID = @RegistrationID
	DELETE FROM dbo.Reports WHERE RegistrationID = @RegistrationID
	DELETE FROM dbo.Registrations WHERE RegistrationID = @RegistrationID
END
GO

-- 3.4.4 CREATE PROCEDURE dbo.USP_GetRegistrationInformation
CREATE PROCEDURE dbo.USP_GetRegistrationInformation
	@RegistrationID INT
AS
BEGIN
	SELECT *
	FROM dbo.Registrations
	WHERE RegistrationID = @RegistrationID
END
GO



-- 3.5 dbo.Reports

-- 3.5.1 CREATE PROCEDURE dbo.USP_CreateReport
CREATE PROCEDURE dbo.USP_CreateReport
	@RegistrationID INT,
	@DepartmentID INT,
	@EmployeeID INT,
	@LaboratoryID INT,
	@Report VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	
	UPDATE dbo.Laboratories
	SET
		Status = 1
	WHERE LaboratoryID = @LaboratoryID
	
	INSERT INTO dbo.Reports (RegistrationID, DepartmentID, EmployeeID, LaboratoryID, Report, CreatedOn)
	VALUES (@RegistrationID, @DepartmentID, @EmployeeID, @LaboratoryID, @Report, @Today)
END
GO

-- 3.5.2 CREATE PROCEDURE dbo.USP_UpdateReport
CREATE PROCEDURE dbo.USP_UpdateReport
	@ReportID INT,
	@RegistrationID INT,
	@DepartmentID INT,
	@EmployeeID INT,
	@LaboratoryID INT,
	@Report VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @LaboratoryNumber DATETIME;
	DECLARE @EmployeeNumber INT;
	
	SET @LaboratoryNumber = (SELECT LaboratoryID FROM dbo.Reports WHERE ReportID = @ReportID)
	
	SET @EmployeeNumber = (SELECT EmployeeID FROM dbo.Reports WHERE ReportID = @ReportID)
	
	-- Set old status to off
	UPDATE dbo.Laboratories
	SET
		Status = 0
	WHERE LaboratoryID = @LaboratoryNumber
	
	UPDATE dbo.Employees
	SET
		Status = 0
	WHERE EmployeeID = @EmployeeNumber
	
	-- Update new status to on
	UPDATE dbo.Laboratories
	SET
		Status = 1
	WHERE LaboratoryID = @LaboratoryID
	
	UPDATE dbo.Employees
	SET
		Status = 1
	WHERE EmployeeID = @EmployeeID
	-- This segment only serves to solve a problem when the user decides to change the employee or laboratory before finishing the result.
	
	UPDATE dbo.Reports
	SET
		RegistrationID = @RegistrationID,
		DepartmentID = @DepartmentID,
		EmployeeID = @EmployeeID,
		LaboratoryID = @LaboratoryID,
		Report = @Report,
		ModifiedOn = @Today
	WHERE ReportID = @ReportID
END
GO

-- 3.5.3 CREATE PROCEDURE dbo.USP_DropReport
CREATE PROCEDURE dbo.USP_DropReport
	@ReportID INT
AS
BEGIN
	DECLARE @LaboratoryNumber DATETIME;
	DECLARE @EmployeeNumber INT;
	
	SET @LaboratoryNumber = (SELECT LaboratoryID FROM dbo.Reports WHERE ReportID = @ReportID)	
	
	SET @EmployeeNumber = (SELECT EmployeeID FROM dbo.Reports WHERE ReportID = @ReportID)
	
	UPDATE dbo.Laboratories
	SET
		Status = 0
	WHERE LaboratoryID = @LaboratoryNumber
	
	UPDATE dbo.Employees
	SET
		Status = 0
	WHERE EmployeeID = @EmployeeNumber
	
	DELETE FROM dbo.Reports WHERE ReportID = @ReportID
END
GO

-- 3.5.4 CREATE PROCEDURE dbo.USP_GetReportInfomration
CREATE PROCEDURE dbo.USP_GetReportInfomration
	@ReportID INT
AS
BEGIN
	SELECT *
	FROM dbo.Reports
	WHERE ReportID = @ReportID
END
GO

-- 3.5.5 CREATE PROCEDURE dbo.USP_GetRegistrationReport
CREATE PROCEDURE dbo.USP_GetRegistrationReport
	@RegistrationID INT
AS
BEGIN
	SELECT *
	FROM dbo.Reports
	WHERE RegistrationID = @RegistrationID
END
GO

-- 3.6 dbo.Billings

-- 3.6.1 CREATE PROCEDURE dbo.USP_CreateBilling
CREATE PROCEDURE dbo.USP_CreateBilling
	@RegistrationID INT
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @DepartmentTotal INT;
	DECLARE @LaboratoryTotal INT;
	DECLARE @AdmissionOn DATETIME;
	DECLARE @DischargeOn DATETIME;
	DECLARE @RoomFee INT;
	DECLARE @RoomTotal INT;
	DECLARE @Total INT;
	
	SET @DepartmentTotal = (
	
		SELECT SUM(DEP.Fee)
		FROM Departments AS DEP
		INNER JOIN (
			-- Retrieve List of Departments that had participated in Registrations
			SELECT DepartmentID
			FROM dbo.Reports
			WHERE RegistrationID = @RegistrationID
		) AS DEP_REP
		ON DEP.DepartmentID = DEP_REP.DepartmentID
	)
	
	SET @LaboratoryTotal = (
		SELECT SUM(LAB.Fee)
		FROM dbo.Laboratories AS LAB
		INNER JOIN (	
			-- Retrieve LaboratoryID used in Reports
			SELECT LaboratoryID	
			FROM dbo.Reports
			WHERE RegistrationID = @RegistrationID
		) AS LAB_REP
		ON LAB.LaboratoryID = LAB_REP.LaboratoryID
	)
	
	SET @AdmissionOn = (SELECT AdmissionOn FROM dbo.Registrations WHERE RegistrationID = @RegistrationID)	
	SET @DischargeOn = (SELECT DischargeOn FROM dbo.Registrations WHERE RegistrationID = @RegistrationID)
	
	SET @RoomFee = (SELECT RoomID FROM dbo.Registrations WHERE RegistrationID = @RegistrationID)
	
	SET @RoomTotal = ((MONTH(@DischargeOn) - MONTH(@AdmissionOn)) * 31) + ((DAY(@DischargeOn) - DAY(@AdmissionOn)) * @RoomFee)
	
	SET @Total = @DepartmentTotal + @LaboratoryTotal + @RoomTotal
	
	INSERT INTO dbo.Billings (RegistrationID, LaboratoryFee, RoomFee, DepartmentFee, Total, CreatedOn)
	VALUES (@RegistrationID, @LaboratoryTotal, @RoomTotal, @DepartmentTotal, @Total, @Today)
END
GO

-- 3.6.2 CREATE PROCEDURE dbo.USP_UpdateBilling

/* 
(Raymond) - Unecessary USP, since there's not much you can update on Billings. 
			Every variable in Billing is reliant on Registrations and Reports. 
			To solve updating issue, drop the bill that was created and create a new one instead. 
*/

-- 3.6.3 CREATE PROCEDURE dbo.USP_DropBilling
CREATE PROCEDURE dbo.USP_DropBilling
	@BillingID INT
AS
BEGIN
	DELETE FROM dbo.Billings WHERE BillingID = @BillingID
END
GO

-- 3.6.4 CREATE PROCEDURE dbo.USP_GetBillingInformation
CREATE PROCEDURE dbo.USP_GetBillingInformation
	@BillingID INT
AS
BEGIN
	SELECT *
	FROM dbo.Billings
	WHERE BillingID = @BillingID
END
GO



-- 3.7 dbo.Laboratories

-- 3.7.1 CREATE PROCEDURE dbo.USP_CreateLaboratory
CREATE PROCEDURE dbo.USP_CreateLaboratory
	@LaboratoryNumber VARCHAR(50),
	@Fee INT
AS
BEGIN
	INSERT INTO dbo.Laboratories (LaboratoryNumber, Fee)
	VALUES (@LaboratoryNumber, @Fee)
END
GO

-- 3.7.2 CREATE PROCEDURE dbo.USP_UpdateLaboratory
CREATE PROCEDURE dbo.USP_UpdateLaboratory
	@LaboratoryID INT,
	@LaboratoryNumber INT,
	@Status BIT,
	@Fee INT
AS
BEGIN
	UPDATE dbo.Laboratories
	SET
		LaboratoryNumber = @LaboratoryNumber,
		Status = @Status,
		Fee = @Fee
	WHERE LaboratoryID = @LaboratoryID
END
GO

-- 3.7.3 CREATE PROCEDURE dbo.USP_DropLaboratory
CREATE PROCEDURE dbo.USP_DropLaboratory
	@LaboratoryID INT
AS
BEGIN 
	DELETE FROM dbo.Laboratories WHERE LaboratoryID = @LaboratoryID
END
GO

-- 3.7.4 CREATE PROCEDURE dbo.USP_GetLaboratoryInformation
CREATE PROCEDURE dbo.USP_GetLaboratoryInformation
	@LaboraotyID INT
AS
BEGIN
	SELECT *
	FROM dbo.Laboratories
	WHERE LaboratoryID = @LaboraotyID
END
GO

-- 3.7.4 CREATE PROCEDURE dbo.USP_OpenLaboratory
CREATE PROCEDURE dbo.USP_OpenLaboratory
	@Status BIT
AS
BEGIN
	SELECT *
	FROM dbo.Laboratories
	WHERE Status = @Status
END
GO


-- 3.8 dbo.Rooms

-- 3.8.1 CREATE PROCEDURE dbo.USP_CreateRoom
CREATE PROCEDURE dbo.USP_CreateRoom
	@RoomNumber INT,
	@Fee INT
AS
BEGIN
	INSERT INTO dbo.Rooms (RoomNumber, Fee)
	VALUES (@RoomNumber, @Fee)
END
GO

-- 3.8.2 CREATE PROCEDURE dbo.USP_UpdateRoom
CREATE PROCEDURE dbo.USP_UpdateRoom
	@RoomID INT,
	@RoomNumber INT,
	@Status BIT,
	@Fee INT
AS
BEGIN
	UPDATE dbo.Rooms
	SET
		RoomNumber = @RoomNumber,
		Status = @Status,
		Fee = @Fee
	WHERE RoomID = @RoomID
END
GO
-- 3.8.3 CREATE PROCEDURE dbo.USP_DropRoom
CREATE PROCEDURE dbo.USP_DropRoom
	@RoomID INT
AS
BEGIN 
	DELETE FROM dbo.Rooms WHERE RoomID = @RoomID
END
GO

-- 3.8.4 CREATE PROCEDURE dbo.USP_GetRoomInformation
CREATE PROCEDURE dbo.USP_GetRoomInformation
	@RoomID INT
AS
BEGIN
	SELECT *
	FROM dbo.Rooms
	WHERE RoomID = @RoomID
END
GO

-- 3.8.4 CREATE PROCEDURE dbo.USP_OpenRoom
CREATE PROCEDURE dbo.USP_OpenRoom
	@Status BIT
AS
BEGIN
	SELECT *
	FROM dbo.Rooms
	WHERE Status = @Status
END
GO

-- 3.9 dbo.Departments

-- 3.9.1 CREATE PROCEDURE dbo.USP_GetDepartmentInformation
CREATE PROCEDURE dbo.USP_GetDepartmentInformation
	@DepartmentID INT
AS
BEGIN
	SELECT *
	FROM dbo.Departments
	WHERE DepartmentID = @DepartmentID
END
GO


-- 3.10 dbo.Roles

-- 3.10.1 CREATE PROCEDURE dbo.USP_GetRoleInformation
CREATE PROCEDURE dbo.USP_GetRoleInformation
	@RoleID INT
AS
BEGIN
	SELECT *
	FROM dbo.Roles
	WHERE RoleID = @RoleID
END
GO


/********************************
-- 4. CREATE VIEWS 
********************************/

-- 4.1 CREATE VIEW V_Patients
CREATE VIEW dbo.V_Patients
AS
	SELECT *
	FROM dbo.Patients
GO
	
-- 4.2 CREATE VIEW V_Employees
CREATE VIEW dbo.V_Employees
AS
	SELECT *
	FROM dbo.Employees
GO
	
-- 4.3 CREATE VIEW V_Departments
CREATE VIEW dbo.V_Departments
AS
	SELECT *
	FROM dbo.Departments
GO

-- 4.3 CREATE VIEW V_Roles
CREATE VIEW V_Roles
AS
	SELECT *
	FROM dbo.Roles
GO

-- 4.5 CREATE VIEW V_Registrations
CREATE VIEW dbo.V_Registrations
AS
	SELECT *
	FROM dbo.Registrations
GO

-- 4.6 CREATE VIEW V_Rooms
CREATE VIEW dbo.V_Rooms
AS
	SELECT *
	FROM dbo.Rooms
GO

-- 4.7 CREATE VIEW V_Laboratories
CREATE VIEW dbo.V_Laboratories
AS
	SELECT *
	FROM dbo.Laboratories
GO

-- 4.8 CREATE VIEW V_Reports
CREATE VIEW dbo.V_Reports
AS
	SELECT *
	FROM dbo.Reports
GO

-- 4.8 CREATE VIEW V_Billings
CREATE VIEW dbo.V_Billings
AS
	SELECT *
	FROM dbo.Billings
GO

/********************************
5. INSERT VALUES INTO TABLE
********************************/

INSERT INTO dbo.Rooms (RoomNumber, Status, Fee)
VALUES 
('Room 1', 0, 250),
('Room 2', 0, 250),
('Room 3', 0, 300),
('Room 4', 0, 350),
('Room 5', 0, 350),
('Room 6', 0, 450)

INSERT INTO dbo.Laboratories (LaboratoryNumber, Status, Fee)
VALUES
('Laboratory 1', 0, 400),
('Laboratory 2', 0, 400),
('Laboratory 3', 0, 400),
('Laboratory 4', 0, 600),
('Laboratory 5', 0, 600),
('Laboratory 6', 0, 600)

INSERT INTO dbo.Roles (RoleID, Description)
VALUES
(0, 'Administrator'),
(1, 'Doctor'),
(2, 'Staff')

INSERT INTO dbo.Departments (Description, Fee)
VALUES
('Cardiac radiology', 1000),
('Dentistry', 2500),
('Dermatology & Cosmetology', 1500),
('Diabetes & Endocrinology', 1000),
('Emergency Medicine', 500),
('General Surgery', 5000),
('General Oncology', 3000),
('Internal Medicine', 1000),
('Nutrition & Dietetics', 500),
('Obstetrics & Gynaecology', 7000),
('Paediatrics & Neonatology', 7000),
('Physical Therapy & Rehabilitation', 4000),
('Plastic & Reconstructive Surgery', 9000),
('Psychiatry & Psychology', 2000),
('Respiratory Medicine', 1000),
('Rheumatology', 1000)