/**********************************************
-- CREATING DATABASE
**********************************************/
IF DB_ID('hospital-management-database') IS NULL
BEGIN
	CREATE DATABASE hospital-management-database
END

GO

/**********************************************
-- CREATING TABLES
**********************************************/

-----------------------------------------------
-- Tables [dbo.PatientDetails]
-----------------------------------------------

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.PatientDetails') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.PatientDetails
END

CREATE TABLE [dbo].[PatientDetails](
	[PatientID] INT IDENTITY(1,1) NOT NULL,
	[FirstName] VARCHAR(50) NULL,
	[LastName] VARCHAR(50) NULL,
	[MiddleName] VARCHAR(50) NULL,
	[Birthdate] DATE NULL,
	[Age] INT NULL,
	[Gender] VARCHAR(50) NULL,
	[Religion] VARCHAR(50) NULL,
	[Email] VARCHAR(50) NULL,
	[PhoneNumber] VARCHAR(50) NULL,
	[AddressID] INT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED 
	(
		[PatientID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[EmployeeDetails]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.EmployeeDetails') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.EmployeeDetails
END

CREATE TABLE [dbo].[EmployeeDetails](
	[EmployeeID] INT IDENTITY(1,1) NOT NULL,
	[FirstName] VARCHAR(50) NULL,
	[LastName] VARCHAR(50) NULL,
	[MiddleName] VARCHAR(50) NULL,
	[Birthdate] DATE NULL,
	[Age] INT NULL,
	[Gender] VARCHAR(50) NULL,
	[Religion] VARCHAR(50) NULL,
	[Email] VARCHAR(50) NULL,
	[PhoneNumber] VARCHAR(50) NULL,
	[AddressID] INT NULL,
	[RoleID] INT NULL,
	[Password] VARCHAR(50) NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED 
	(
		[EmployeeID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)
GO

-----------------------------------------------
-- Table [dbo].[PatientRegistration]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.PatientRegistration') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.PatientRegistration
END

CREATE TABLE [dbo].[PatientRegistration](
	[RegistrationID] INT IDENTITY(1,1) NOT NULL,
	[PatientID] INT NOT NULL,
	[AdmissionOn] DATETIME NULL,
	[DischargeOn] DATETIME NULL,
	[EmployeeID] INT NOT NULL,
	[RoomID] INT NULL,
	[LaboratoryID] INT NULL
	PRIMARY KEY CLUSTERED 
	(
		[RegistrationID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[EmployeeDepartment]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.EmployeeDepartment') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.EmployeeDepartment
END

CREATE TABLE [dbo].[EmployeeDepartment](
	[EmployeeID] INT IDENTITY(1,1) NOT NULL,
	[DepartmentID] INT NULL,
	[Status] BIT NULL
	PRIMARY KEY CLUSTERED 
	(
		[EmployeeID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[Address]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Address') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.Address
END

CREATE TABLE [dbo].[Address](
	[AddressID] INT IDENTITY(1,1) NOT NULL,
	[Address] VARCHAR(50) NULL,
	[City] VARCHAR(50) NULL,
	[Province] VARCHAR(50) NULL,
	[Zipcode] VARCHAR(50) NULL,
	[Country] VARCHAR(50) NULL
	PRIMARY KEY CLUSTERED 
	(
		[AddressID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[Role]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Role') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.Role
END

CREATE TABLE [dbo].[Role](
	[RoleID] INT IDENTITY(1,1) NOT NULL,
	[Description] VARCHAR(50) NULL
	PRIMARY KEY CLUSTERED 
	(
		[RoleID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[Department]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Department') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.Department
END

CREATE TABLE [dbo].[Department](
	[DepartmentID] INT IDENTITY(1,1) NOT NULL,
	[DepartmentName] VARCHAR(50) NULL,
	[DepCharge] INT NULL
	PRIMARY KEY CLUSTERED 
	(
		[DepartmentID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[Room]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Room') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.Room
END

CREATE TABLE [dbo].[Room](
	[RoomID] INT IDENTITY(1,1) NOT NULL,
	[Status] VARCHAR(50) NULL,
	[RoomCharge] INT NULL
	PRIMARY KEY CLUSTERED 
	(
		[RoomID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[Laboratory]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Laboratory') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.Laboratory
END

CREATE TABLE [dbo].[Laboratory](
	[LaboratoryID] INT IDENTITY(1,1) NOT NULL,
	[Status] VARCHAR(50) NULL,
	[LabCharge] INT NULL
	PRIMARY KEY CLUSTERED 
	(
		[LaboratoryID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[LaboratoryDetails]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.LaboratoryDetails') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.LaboratoryDetails
END

CREATE TABLE [dbo].[LaboratoryDetails](
	[ReportID] INT IDENTITY(1,1) NOT NULL,
	[RegistrationID] INT NOT NULL,
	[Results] VARCHAR(50) NULL
	PRIMARY KEY CLUSTERED 
	(
		[ReportID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[Billing]
-----------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Billing') AND OBJECTPROPERTY(id, N'isTable' = 1)
BEGIN
	DROP TABLE dbo.Billing
END

CREATE TABLE [dbo].[Billing](
	[BillingID] INT IDENTITY(1,1) NOT NULL,
	[RegistrationID] INT NOT NULL,
	[RoomCharge] INT NULL,
	[LabCharge] INT NULL,
	[DepCharge] INT NULL,
	[Status] BIT NULL
	PRIMARY KEY CLUSTERED 
	(
		[BillingID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

/**********************************************
-- CREATE CONSTRAINTS (FK, UNIQUE, DEFAULT)
**********************************************/

-- CREATE FOREGIN KEY CONSTRAINT

-- PatientDetails: AddressID >|-----|- Address: AddressID
ALTER TABLE dbo.PatientDetails WITH CHECK ADD CONSTRAINT [FK_PatientDetails_Address_ID] FOREIGN KEY ([AddressID]) REFERENCES dbo.Address (AddressID)

-- EmployeeDetails: AddressID >|-----|- Address: AddressID
ALTER TABLE dbo.EmployeeDetails WITH CHECK ADD CONSTRAINT [FK_EmployeeDetails_Address_ID] FOREIGN KEY ([AddressID]) REFERENCES dbo.Address (AddressID)

-- EmployeeDetails: RoleID >|-----|- Role: RoleID
ALTER TABLE dbo.EmployeeDetails WITH CHECK ADD CONSTRAINT [FK_EmployeeDetails_Role_ID] FOREIGN KEY ([RoleID]) REFERENCES dbo.Role (RoleID)

-- PatientRegistration: PatientID >|-----|- PatientDetails: PatientID
ALTER TABLE dbo.PatientRegistration WITH CHECK ADD CONSTRAINT [FK_PatientRegistration_Patient_ID] FOREIGN KEY ([PatientID]) REFERENCES dbo.PatientDetails (PatientID)

-- PatientRegistration: EmployeeID >|-----|- EmployeeDepartment: Employee
ALTER TABLE dbo.PatientRegistration WITH CHECK ADD CONSTRAINT [FK_PatientRegistration_Employee_ID] FOREIGN KEY ([EmployeeID]) REFERENCES dbo.EmployeeDepartment (EmployeeID)

-- PatientRegistration: RoomID >|-----|- Room: RoomID
ALTER TABLE dbo.PatientRegistration WITH CHECK ADD CONSTRAINT [FK_PatientRegistration_Room_ID] FOREIGN KEY ([RoomID]) REFERENCES dbo.Room (RoomID)

-- PatientRegistration: LaboratoryID >|-----|- Laboratory: LaboratoryID
ALTER TABLE dbo.PatientRegistration WITH CHECK ADD CONSTRAINT [FK_PatientRegistration_Laboratory_ID] FOREIGN KEY ([LaboratoryID]) REFERENCES dbo.Laboratory (LaboratoryID)

-- EmployeeDepartment: EmployeeID >|-----|- EmployeeDetails: EmployeeID
ALTER TABLE dbo.EmployeeDepartment WITH CHECK ADD CONSTRAINT [FK_EmployeeDepartment_Employee_ID] FOREIGN KEY ([EmployeeID]) REFERENCES dbo.EmployeeDetails (EmployeeID)

-- EmployeeDepartment: EmployeeDepartment >|-----|- Department: DepartmentID
ALTER TABLE dbo.EmployeeDepartment WITH CHECK ADD CONSTRAINT [FK_EmployeeDepartment_Department_ID] FOREIGN KEY ([DepartmentID]) REFERENCES dbo.Department (DepartmentID)

-- LaboratoryDetails: RegistrationID >|-----|- PatientRegistration: RegistrationID
ALTER TABLE dbo.LaboratoryDetails WITH CHECK ADD CONSTRAINT [FK_LaboratoryDetails_Registration_ID] FOREIGN KEY ([RegistrationID]) REFERENCES dbo.PatientRegistration (RegistrationID)

-- Billing: RegistrationID >|-----|- PatientRegistration: RegistrationID
ALTER TABLE dbo.Billing WITH CHECK ADD CONSTRAINT [FK_Billing_Registration_ID] FOREIGN KEY ([RegistrationID]) REFERENCES dbo.PatientRegistration (RegistrationID)

-- (Raymond) Unecessary Relationships
/*
-- Billing: RoomCharge >|-----|- Room: RoomCharge
ALTER TABLE dbo.Billing WITH CHECK ADD CONSTRAINT [FK_Billing_RoomCharge] FOREIGN KEY ([RoomCharge]) REFERENCES dbo.Room (RoomCharge)

-- Billing: LabCharge >|-----|- Laboratory: LabCharge
ALTER TABLE dbo.Billing WITH CHECK ADD CONSTRAINT [FK_Billing_LabCharge] FOREIGN KEY ([LabCharge]) REFERENCES dbo.Laboratory (LabCharge)

-- Billing: DepCharge >|-----|- Department: DepCharge
ALTER TABLE dbo.Billing WITH CHECK ADD CONSTRAINT [FK_Billing_DepCharge] FOREIGN KEY ([DepCharge]) REFERENCES dbo.Department (DepCharge)
*/

-- CREATE UNIQUE CONSTRAINT
ALTER TABLE dbo.PatientDetails ADD CONSTRAINT UQ_PatientDetails_PatientID UNIQUE NONCLUSTERED (PatientID)
ALTER TABLE dbo.EmployeeDetails ADD CONSTRAINT UQ_EmployeeDetails_EmployeeID UNIQUE NONCLUSTERED (EmployeeID)
ALTER TABLE dbo.Address ADD CONSTRAINT UQ_Address UNIQUE NONCLUSTERED([Address],[City],[Province],[Zipcode],[Country])
ALTER TABLE dbo.LaboratoryDetails ADD CONSTRAINT UQ_LaboratoryDetails UNIQUE NONCLUSTERED ([RegistrationID], [ReportID])

-- CREATE DEFAULT CONSTRAINTS
ALTER TABLE dbo.PatientDetails ADD CONSTRAINT DF_PatientDetails_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
ALTER TABLE dbo.EmployeeDetails ADD CONSTRAINT DF_EmployeeDetails_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
ALTER TABLE dbo.PatientRegistration ADD CONSTRAINT DF_PatientRegistration_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]

GO

/**********************************************
-- CREATE USER DEFINE TABLE TYPES
**********************************************/

CREATE TYPE [dbo].[UDT_Employee] AS TABLE (
	[Email] VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[Birthdate] DATE NOT NULL,
	[Gender] VARCHAR(50) NOT NULL,
	[PhoneNumber] VARCHAR(50) NOT NULL,
	[Role] VARCHAR(50) NULL,
	[DepartmentName] VARCHAR(50) NULL,
	[CreatedBy] INT
)

CREATE TYPE [dbo].[UDT_AddressInput] AS TABLE (
	[Address] VARCHAR(50) NOT NULL,
	[City] VARCHAR(50) NOT NULL,
	[Province] VARCHAR(50) NOT NULL,
	[Zipcode] VARCHAR(50) NOT NULL,
	[Country] VARCHAR(50) NOT NULL,
)

CREATE TYPE [dbo].[UDT_Patient] AS TABLE (
	[Email] VARCHAR(50) NULL,
	[FirstName] VARCHAR(50) NULL,
	[LastName] VARCHAR(50) NULL,
	[Birthdate] DATE NULL,
	[Gender] VARCHAR(50) NULL,
	[PhoneNumber] VARCHAR(50) NULL
)

CREATE TYPE [dbo].[UDT_LaboratoryResult] AS TABLE (
	[ReportID] VARCHAR(45) NULL,
	[Results] VARCHAR(45) NULL
)		
