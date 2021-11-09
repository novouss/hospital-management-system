/**********************************************
-- CREATING DATABASE
**********************************************/

/**********************************************
-- DROPPING CONSTRAINTS (FK, UQ, DF)
**********************************************/

-- DROP FOREGIN KEY CONSTRAINT
ALTER TABLE dbo.PatientDetails DROP CONSTRAINT [FK_PatientDetails_Address_ID]
ALTER TABLE dbo.EmployeeDetails DROP CONSTRAINT [FK_EmployeeDetails_Address_ID] 
ALTER TABLE dbo.EmployeeDetails DROP CONSTRAINT [FK_EmployeeDetails_Role_ID] 
ALTER TABLE dbo.PatientRegistration DROP CONSTRAINT [FK_PatientRegistration_Patient_ID]
--ALTER TABLE dbo.PatientRegistration DROP CONSTRAINT [FK_PatientRegistration_Employee_ID]
ALTER TABLE dbo.PatientRegistration DROP CONSTRAINT [FK_PatientRegistration_Room_ID]
ALTER TABLE dbo.PatientRegistration DROP CONSTRAINT [FK_PatientRegistration_Laboratory_ID]
ALTER TABLE dbo.EmployeeDepartment DROP CONSTRAINT [FK_EmployeeDepartment_Employee_ID]
ALTER TABLE dbo.EmployeeDepartment DROP CONSTRAINT [FK_EmployeeDepartment_Department_ID] 
ALTER TABLE dbo.LaboratoryDetails DROP CONSTRAINT [FK_LaboratoryDetails_Registration_ID] 
ALTER TABLE dbo.Billing DROP CONSTRAINT [FK_Billing_Registration_ID] 

-- DROP UNIQUE CONSTRAINT
ALTER TABLE dbo.PatientDetails DROP CONSTRAINT UQ_PatientDetails_PatientID 
ALTER TABLE dbo.EmployeeDetails DROP CONSTRAINT UQ_EmployeeDetails_EmployeeID 
ALTER TABLE dbo.Address DROP CONSTRAINT UQ_Address 
ALTER TABLE dbo.LaboratoryDetails DROP CONSTRAINT UQ_LaboratoryDetails 

-- DROP DEFAULT CONSTRAINTS
ALTER TABLE dbo.PatientDetails DROP CONSTRAINT DF_PatientDetails_CreatedOn
ALTER TABLE dbo.EmployeeDetails DROP CONSTRAINT DF_EmployeeDetails_CreatedOn
ALTER TABLE dbo.PatientRegistration DROP CONSTRAINT DF_PatientRegistration_CreatedOn

GO
/**********************************************
-- DROPPING USER STORED PROCEDURES (USP)
**********************************************/
DROP PROCEDURE dbo.USP_AddRegistration;
DROP PROCEDURE dbo.USP_ModifyRegistration;
DROP PROCEDURE dbo.USP_DeleteRegistration;

GO
/**********************************************
-- DROPPING VIEWS (V)
**********************************************/
DROP VIEW dbo.V_PatientInformation;
DROP VIEW dbo.V_EmployeeInformation;

GO
/**********************************************
-- CREATING FUNCTIONS
**********************************************/

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

/**********************************************
-- CREATING TABLES
**********************************************/

-----------------------------------------------
-- Tables [dbo.PatientDetails]
-----------------------------------------------
IF OBJECT_ID(N'dbo.PatientDetails', N'U') IS NOT NULL  
   DROP TABLE [dbo].[PatientDetails];  
GO

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
IF OBJECT_ID(N'dbo.EmployeeDetails', N'U') IS NOT NULL  
   DROP TABLE [dbo].[EmployeeDetails];  
GO

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
IF OBJECT_ID(N'dbo.PatientRegistration', N'U') IS NOT NULL  
   DROP TABLE [dbo].[PatientRegistration];  
GO

CREATE TABLE [dbo].[PatientRegistration](
	[RegistrationID] INT IDENTITY(1,1) NOT NULL,
	[PatientID] INT NOT NULL,
	[AdmissionOn] DATETIME NULL,
	[DischargeOn] DATETIME NULL,
	[EmployeeID] INT NOT NULL,
	[RoomID] INT NULL,
	[LaboratoryID] INT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
	PRIMARY KEY CLUSTERED 
	(
		[RegistrationID] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
)
GO

-----------------------------------------------
-- Table [dbo].[EmployeeDepartment]
-----------------------------------------------
IF OBJECT_ID(N'dbo.EmployeeDepartment', N'U') IS NOT NULL  
   DROP TABLE [dbo].[EmployeeDepartment];  
GO

CREATE TABLE [dbo].[EmployeeDepartment] (
    [EmployeeID] INT NOT NULL,
    [DepartmentID] INT NULL,
    [Status] BIT NULL,
)
GO

-----------------------------------------------
-- Table [dbo].[Address]
-----------------------------------------------
IF OBJECT_ID(N'dbo.Address', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Address];  
GO

CREATE TABLE [dbo].[Address](
	[AddressID] INT IDENTITY(1,1) NOT NULL,
	[Address1] VARCHAR(50) NULL,
	[Address2] VARCHAR(50) NULL,
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
IF OBJECT_ID(N'dbo.Role', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Role];  
GO

CREATE TABLE [dbo].[Role](
	[RoleID] INT NOT NULL,
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
IF OBJECT_ID(N'dbo.Department', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Department];  
GO

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
IF OBJECT_ID(N'dbo.Room', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Room];  
GO


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
IF OBJECT_ID(N'dbo.Laboratory', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Laboratory];  
GO

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
IF OBJECT_ID(N'dbo.LaboratoryDetails', N'U') IS NOT NULL  
   DROP TABLE [dbo].[LaboratoryDetails];  
GO

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
IF OBJECT_ID(N'dbo.Billing', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Billing];  
GO

CREATE TABLE [dbo].[Billing](
	[BillingID] INT IDENTITY(1,1) NOT NULL,
	[RegistrationID] INT NOT NULL,
	[RoomCharge] INT NULL,
	[LabCharge] INT NULL,
	[DepCharge] INT NULL,
	[Total] INT NULL,
	[Status] BIT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedOn] DATETIME NULL
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
-- ALTER TABLE dbo.PatientRegistration WITH CHECK ADD CONSTRAINT [FK_PatientRegistration_Employee_ID] FOREIGN KEY ([EmployeeID]) REFERENCES dbo.EmployeeDepartment (EmployeeID)

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

-- (Raymond) Unnecessary Relationships
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
ALTER TABLE dbo.Address ADD CONSTRAINT UQ_Address UNIQUE NONCLUSTERED([Address1], [Address2], [City],[Province],[Zipcode],[Country])
ALTER TABLE dbo.LaboratoryDetails ADD CONSTRAINT UQ_LaboratoryDetails UNIQUE NONCLUSTERED ([RegistrationID], [ReportID])

-- CREATE DEFAULT CONSTRAINTS
ALTER TABLE dbo.PatientDetails ADD CONSTRAINT DF_PatientDetails_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
ALTER TABLE dbo.EmployeeDetails ADD CONSTRAINT DF_EmployeeDetails_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]
ALTER TABLE dbo.PatientRegistration ADD CONSTRAINT DF_PatientRegistration_CreatedOn DEFAULT GETDATE() FOR [CreatedOn]

GO
/**********************************************
-- CREATE USER DEFINE TABLE (UDT)
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
	[Address1] VARCHAR(50) NOT NULL,
	[Address2] VARCHAR(50) NOT NULL,
	[City] VARCHAR(50) NOT NULL,
	[Province] VARCHAR(50) NOT NULL,
	[Zipcode] VARCHAR(50) NOT NULL,
	[Country] VARCHAR(50) NOT NULL
)

CREATE TYPE [dbo].[UDT_Patient] AS TABLE (
	[FirstName] VARCHAR(50) NULL,
	[LastName] VARCHAR(50) NULL,
	[Birthdate] DATE NULL,
	[Gender] VARCHAR(50) NULL,
	[PhoneNumber] VARCHAR(50) NULL,
	[Email] VARCHAR(50) NULL
)

CREATE TYPE [dbo].[UDT_LaboratoryResult] AS TABLE (
	[ReportID] VARCHAR(45) NULL,
	[Results] VARCHAR(45) NULL
)

/**********************************************
-- CREATE USER STORED PROCEDURE (USP)
**********************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.Address 
-----------------------------------------------

CREATE PROCEDURE dbo.USP_AddAddress
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Address (Address1, Address2, City, Province, Zipcode, Country)
	VALUES (@Address1, @Address2, @City, @Province, @Zipcode, @Country)
END
GO

CREATE PROCEDURE dbo.USP_ModifyAddress
	@AddressID INT,
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	UPDATE dbo.Address 
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

CREATE PROCEDURE dbo.USP_DeleteAddress
	@AddressID INT
AS
BEGIN
	DELETE FROM dbo.Address WHERE AddressID = @AddressID
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.PatientDetails
-----------------------------------------------

CREATE PROCEDURE dbo.USP_AddPatient 
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@Birthdate DATE,
	@Gender VARCHAR(50),
	@Religion VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@DepartmentID INT,
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
	
	EXEC dbo.USP_AddAddress @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
	
	SET @AddressNumber = (SELECT COUNT(AddressID) FROM dbo.Address)
	
	INSERT INTO dbo.PatientDetails (FirstName, LastName, MiddleName, Birthdate, Age, Gender, Religion, Email, PhoneNumber, AddressID, CreatedOn) 
	VALUES (@FirstName,	@LastName, @MiddleName, @Birthdate, dbo.FN_CalculateAge(@Birthdate) ,@Gender, @Religion, @Email, @PhoneNumber, @AddressNumber, @Today)
		
END
GO

CREATE PROCEDURE dbo.USP_ModifyPatient
	@PatientID INT,
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@MiddleName VARCHAR(50),
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
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.PatientDetails WHERE @PatientNumber = PatientID);
		
	UPDATE dbo.PatientDetails
	SET 
		FirstName = @FirstName, 
		LastName = @LastName, 
		MiddleName = @MiddleName, 
		Birthdate = @Birthdate, 
		Age = dbo.FN_CalculateAge(@Birthdate),
		Gender = @Gender, 
		Religion = @Religion, 
		Email = @Email, 
		PhoneNumber = @PhoneNumber, 
		ModifiedOn = @Today
	WHERE PatientID = @PatientID

	EXEC dbo.USP_ModifyAddress @AddressID = @AddressNumber, @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
END
GO

CREATE PROCEDURE dbo.USP_DeletePatient
	@PatientID INT
AS
BEGIN
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.PatientDetails WHERE @PatientID = PatientID);
	
	DELETE FROM dbo.PatientDetails WHERE PatientID = @PatientID
	
	EXEC dbo.USP_DeleteAddress @AddressID = @AddressNumber
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.EmployeeDetails
-----------------------------------------------

CREATE PROCEDURE dbo.USP_AddEmployee
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@Birthdate DATE,
	@Gender VARCHAR(50),
	@Religion VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@Password VARCHAR(50),
	@RoleID INT,
	@DepartmentID INT,
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
	DECLARE @DepartmentNumber INT;
	DECLARE @EmployeeNumber INT;

	SET @DepartmentNumber = (SELECT DepartmentID FROM dbo.Department WHERE @DepartmentID = DepartmentID)

	EXEC dbo.USP_AddAddress @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
	
	SET @AddressNumber = (SELECT COUNT(AddressID) FROM dbo.Address)
	
	INSERT INTO dbo.EmployeeDetails (FirstName, LastName, MiddleName, Birthdate, Age, Gender, Religion, Email, PhoneNumber, Password, RoleID, AddressID, CreatedOn) 
	VALUES (@FirstName,	@LastName, @MiddleName, @Birthdate, dbo.FN_CalculateAge(@Birthdate), @Gender, @Religion, @Email, @PhoneNumber, @Password, @RoleID, @AddressNumber, @Today)

	SET @EmployeeNumber = (SELECT COUNT(EmployeeID) FROM dbo.EmployeeDetails)

	INSERT INTO dbo.EmployeeDepartment (EmployeeID, DepartmentID)
	VALUES (@EmployeeNumber, @DepartmentNumber)
	
	INSERT INTO dbo.EmployeeDepartment (EmployeeID, DepartmentID, Status)
	VALUES (@EmployeeNumber, @DepartmentNumber, 0)
END
GO

CREATE PROCEDURE dbo.USP_ModifyEmployee
	@EmployeeNumber INT,
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@Birthdate DATE,
	@Gender VARCHAR(50),
	@Religion VARCHAR(50),
	@Email VARCHAR(50),
	@PhoneNumber VARCHAR(50),
	@Password VARCHAR(50),
	@RoleID INT,
	@DepartmentID INT,
	@Address1 VARCHAR(50),
	@Address2 VARCHAR(50),
	@City VARCHAR(50),
	@Province VARCHAR(50),
	@Zipcode VARCHAR(50),
	@Country VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.EmployeeDetails WHERE @EmployeeNumber = EmployeeID);
	
	UPDATE dbo.EmployeeDetails
	SET 
		FirstName = @FirstName, 
		LastName = @LastName, 
		MiddleName = @MiddleName, 
		Birthdate = @Birthdate, 
		Age = dbo.FN_CalculateAge(@Birthdate),
		Gender = @Gender, 
		Religion = @Religion, 
		Email = @Email, 
		PhoneNumber = @PhoneNumber, 
		Password = @Password,
		RoleID = @RoleID,
		ModifiedOn = @Today
	WHERE EmployeeID = @EmployeeNumber
		
	UPDATE dbo.EmployeeDepartment
	SET
		EmployeeID = @EmployeeNumber,
		DepartmentID = @DepartmentID
	WHERE EmployeeID = @EmployeeNumber

	EXEC dbo.USP_ModifyAddress @AddressID = @AddressNumber, @Address1 = @Address1, @Address2 = @Address2, @City = @City, @Province = @Province, @Zipcode = @Zipcode, @Country = @Country
END
GO

CREATE PROCEDURE dbo.USP_DeleteEmployee
	@EmployeeNumber INT
AS
BEGIN
	DECLARE @AddressNumber INT = (SELECT AddressID FROM dbo.EmployeeDetails WHERE @EmployeeNumber = EmployeeID);
	
	DELETE FROM dbo.EmployeeDepartment WHERE EmployeeID = @EmployeeNumber
	DELETE FROM dbo.EmployeeDetails WHERE EmployeeID = @EmployeeNumber
	
	EXEC dbo.USP_DeleteAddress @AddressID = @AddressNumber
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.PatientRegistration
-----------------------------------------------

CREATE PROCEDURE dbo.USP_AddRegistration
	@PatientID INT,
	@AdmissionOn DATETIME,
	@DischargeOn DATETIME,
	@EmployeeID INT,
	@RoomID INT,
	@LaboratoryID INT,
	@Results VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	DECLARE @RegistrationNumber INT;
		
	UPDATE dbo.Room
	SET
		Status = 1
	WHERE RoomID = @RoomID
	
	UPDATE dbo.Laboratory
	SET
		Status = 1
	WHERE LaboratoryID = @LaboratoryID
	
	UPDATE dbo.EmployeeDepartment
	SET
		Status = 1
	WHERE EmployeeID = @EmployeeID
	
	INSERT INTO dbo.PatientRegistration (PatientID, AdmissionOn, DischargeOn, EmployeeID, RoomID, LaboratoryID, CreatedOn)
	VALUES (@PatientID, @AdmissionOn, @DischargeOn, @EmployeeID, @RoomID, @LaboratoryID, @Today)
	
	SET @RegistrationNumber = (SELECT COUNT(RegistrationID) FROM dbo.PatientRegistration)
	
	INSERT INTO dbo.LaboratoryDetails (RegistrationID, Results)
	VALUES (@RegistrationNumber, @Results)
END
GO

CREATE PROCEDURE dbo.USP_ModifyRegistration
	@RegistrationID INT,
	@PatientID INT,
	@AdmissionOn DATETIME,
	@DischargeOn DATETIME,
	@EmployeeID INT,
	@RoomID INT,
	@LaboratoryID INT,
	@Results VARCHAR(50)
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	
	UPDATE dbo.PatientRegistration
	SET
		PatientID = @PatientID,
		AdmissionOn = @AdmissionOn,
		DischargeOn = @DischargeOn,
		EmployeeID = @EmployeeId,
		RoomID = @RoomID,
		LaboratoryID = @LaboratoryID,
		ModifiedOn = @Today
	WHERE RegistrationID = @RegistrationID
	
	UPDATE dbo.LaboratoryDetails
	SET
		Results = @Results
	WHERE RegistrationID = @RegistrationID
END
GO	

CREATE PROCEDURE dbo.USP_DeleteRegistration
	@RegistrationID INT
AS 
BEGIN
	DECLARE @RoomID INT;
	DECLARE @LaboratoryID INT;

	SET @RoomID = (SELECT RoomID FROM dbo.PatientRegistration WHERE RegistrationID = @RegistrationID)
	SET @LaboratoryID = (SELECT LaboratoryID FROM dbo.PatientRegistration WHERE RegistrationID = @RegistrationID)

	UPDATE dbo.Room
	SET
		Status = 0
	WHERE RoomID = @RoomID
	
	UPDATE dbo.Laboratory
	SET
		Status = 0
	WHERE LaboratoryID = @LaboratoryID

	DELETE FROM dbo.PatientRegistration WHERE RegistrationID = @RegistrationID
	DELETE FROM dbo.LaboratoryDetails WHERE RegistrationID = @RegistrationID
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.Billing
-----------------------------------------------

CREATE PROCEDURE dbo.USP_AddBilling
	@RegistrationID INT
AS
BEGIN
	DECLARE @DepCharge INT;
	DECLARE @RoomCharge INT;
	DECLARE @LabCharge INT;
	DECLARE @Total INT;
	
	DECLARE @Today DATETIME = GETDATE();
	
	SET @DepCharge = (
		SELECT DepCharge
		FROM dbo.Department AS DEPARTMENT
		JOIN dbo.EmployeeDepartment AS EMPLOYEE
		ON DEPARTMENT.DepartmentID = EMPLOYEE.DepartmentID
		JOIN dbo.PatientRegistration AS REGISTRATION
		ON REGISTRATION.RegistrationID = @RegistrationID
	)
	
	SET @RoomCharge = (
		SELECT RoomCharge 
		FROM dbo.Room AS ROOM 
		JOIN dbo.PatientRegistration AS REGISTRATION
		ON ROOM.RoomID = REGISTRATION.RoomID AND REGISTRATION.RegistrationID = @RegistrationID
	)
	
	SET @LabCharge = (
		SELECT LabCharge
		FROM dbo.Laboratory AS LABORATORY
		JOIN dbo.PatientRegistration AS REGISTRATION
		ON LABORATORY.LaboratoryID = REGISTRATION.LaboratoryID AND REGISTRATION.RegistrationID = @RegistrationID
	)
	
	SET @Total = @DepCharge + @RoomCharge + @LabCharge;
	
	INSERT INTO dbo.Billing (RegistrationID, RoomCharge, LabCharge, DepCharge, Total, Status, CreatedOn)
	VALUES (@RegistrationID, @RoomCharge, @LabCharge, @DepCharge, @Total, 0, @Today)
END
GO

CREATE PROCEDURE dbo.USP_ModifyBilling
	@BillingID INT,
	@RoomCharge	INT,
	@LabCharge INT,
	@DepCharge INT,
	@Total INT,
	@Status BIT,
	@ModifiedON DATETIME
AS
BEGIN
	DECLARE @Today DATETIME = GETDATE();
	
	UPDATE dbo.Billing
	SET
		RoomCharge = @RoomCharge,
		LabCharge = @LabCharge,
		DepCharge = @DepCharge,
		Total = @Total,
		Status = @Status,
		ModifiedOn = @Today
	WHERE BillingID = @BillingID
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.FindAccount
-----------------------------------------------

CREATE PROCEDURE dbo.USP_FindAccount
	@Email VARCHAR(50),
	@Password VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.EmployeeDetails WHERE Email = @Email AND Password = @Password
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.Search{Functions}
-----------------------------------------------

CREATE PROCEDURE dbo.USP_SearchPatient
	@stringSearch VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.PatientDetails 
	WHERE 
		PatientID LIKE '%' + @stringSearch + '%' OR
		FirstName LIKE '%' + @stringSearch + '%' OR
		LastName LIKE '%' + @stringSearch + '%' OR
		MiddleName LIKE '%' + @stringSearch + '%' OR
		Birthdate LIKE '%' + @stringSearch + '%' OR
		Age LIKE '%' + @stringSearch + '%' OR
		Gender LIKE '%' + @stringSearch + '%' OR
		Religion LIKE '%' + @stringSearch + '%' OR
		Email LIKE '%' + @stringSearch + '%' OR
		PhoneNumber LIKE '%' + @stringSearch + '%'
END
GO

CREATE PROCEDURE dbo.USP_SearchEmployee
	@stringSearch VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.EmployeeDetails 
	WHERE 
		EmployeeID LIKE '%' + @stringSearch + '%' OR
		FirstName LIKE '%' + @stringSearch + '%' OR
		LastName LIKE '%' + @stringSearch + '%' OR
		MiddleName LIKE '%' + @stringSearch + '%' OR
		Birthdate LIKE '%' + @stringSearch + '%' OR
		Age LIKE '%' + @stringSearch + '%' OR
		Gender LIKE '%' + @stringSearch + '%' OR
		Religion LIKE '%' + @stringSearch + '%' OR
		Email LIKE '%' + @stringSearch + '%' OR
		PhoneNumber LIKE '%' + @stringSearch + '%'
END
GO

CREATE PROCEDURE dbo.USP_SearchRegistration
	@stringSearch VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.PatientRegistration 
	WHERE 
		RegistrationID LIKE '%' + @stringSearch + '%' OR
		PatientID LIKE '%' + @stringSearch + '%'
END
GO

CREATE PROCEDURE dbo.USP_SearchBilling
	@stringSearch VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.Billing 
	WHERE BIllingID LIKE '%' + @stringSearch + '%' 
END
GO

CREATE PROCEDURE dbo.USP_SearchRoom
	@stringSearch VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.Room 
	WHERE RoomID LIKE '%' + @stringSearch + '%' 
END
GO

CREATE PROCEDURE dbo.USP_SearchLaboratory
	@stringSearch VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.Laboratory 
	WHERE LaboratoryID LIKE '%' + @stringSearch + '%' 
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.FindDepartmentEmployees
-----------------------------------------------

CREATE PROCEDURE dbo.USP_FindDepartmentEmployees
	@DepartmentID INT
AS
BEGIN
	SELECT
		DEPARTMENT.DepartmentID,
		DEPARTMENT.DepartmentName,
		EMPLOYEE.EmployeeID, 
		EMPLOYEE.FirstName, 
		EMPLOYEE.LastName, 
		EMPLOYEE.MiddleName, 
		EMP_DEP.Status
	FROM EmployeeDepartment AS EMP_DEP
	JOIN EmployeeDetails AS EMPLOYEE
	ON EMP_DEP.DepartmentID = @DepartmentID AND EMP_DEP.EmployeeID = EMPLOYEE.EmployeeID
	JOIN Department AS DEPARTMENT
	ON DEPARTMENT.DepartmentID = @DepartmentID
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.FindRole and dbo.FindDepartment
-----------------------------------------------

CREATE PROCEDURE dbo.USP_FindRole
	@RoleID INT
AS
BEGIN
	SELECT * 
	FROM dbo.Role 
	WHERE RoleID = @RoleID
END
GO

CREATE PROCEDURE dbo.USP_FindDepartment
	@DepartmentID INT
AS
BEGIN
	SELECT * 
	FROM dbo.Department 
	WHERE DepartmentID = @DepartmentID
END
GO

-----------------------------------------------
-- CREATE PROCEDURE FOR dbo.FindAvailable(Functions)
-----------------------------------------------

CREATE PROCEDURE dbo.USP_FindAvailableEmployees
	@DepartmentID INT,
	@Status INT
AS
BEGIN
	SELECT *
	FROM dbo.EmployeeDetails AS EMPLOYEE
	JOIN dbo.EmployeeDepartment AS EMP_DEP
	ON EMPLOYEE.EmployeeID = EMP_DEP.EmployeeID AND EMP_DEP.Status = @Status
	JOIN dbo.Department AS DEPARTMENT
	ON DEPARTMENT.DepartmentID = @DepartmentID AND EMP_DEP.DepartmentID = @DepartmentID
END
GO

CREATE PROCEDURE dbo.USP_FindAvailableRooms
	@Status BIT
AS
BEGIN
	SELECT *
	FROM dbo.Rooms
	WHERE @Status = Status
END
GO

CREATE PROCEDURE dbo.USP_FindAvailableLaboratories
	@Status BIT
AS
BEGIN
	SELECT *
	FROM dbo.Laboratory
	WHERE @Status = Status
END
GO

/**********************************************
-- CREATE VIEWS (V)
**********************************************/

CREATE VIEW dbo.V_PatientInformation 
AS
	-- Each Column Needed to be Unique
	SELECT 
		PATIENT.PatientID, 
		PATIENT.FirstName, 
		PATIENT.LastName, 
		PATIENT.MiddleName, 
		PATIENT.Birthdate, 
		PATIENT.Age, 
		PATIENT.Gender, 
		PATIENT.Religion, 
		PATIENT.Email, 
		PATIENT.PhoneNumber, 
		PATIENT.AddressID, 
		ADDRESS.Address1, 
		ADDRESS.Address2, 
		ADDRESS.City, 
		ADDRESS.Province, 
		ADDRESS.Zipcode, 
		ADDRESS.Country
	FROM dbo.PatientDetails AS PATIENT
	FULL JOIN dbo.Address AS ADDRESS
	ON PATIENT.AddressID = ADDRESS.AddressID
GO

CREATE VIEW dbo.V_EmployeeInformation
AS
	SELECT 
		EMPLOYEE.EmployeeID, 
		EMPLOYEE.FirstName, 
		EMPLOYEE.LastName, 
		EMPLOYEE.MiddleName, 
		EMPLOYEE.Birthdate, 
		EMPLOYEE.Age, 
		EMPLOYEE.Gender, 
		EMPLOYEE.Religion, 
		EMPLOYEE.Email, 
		EMPLOYEE.PhoneNumber, 
		EMPLOYEE.RoleID,
		EMPLOYEE.Password,
		EMP_DEP.DepartmentID,
		EMPLOYEE.AddressID, 
		ADDRESS.Address1, 
		ADDRESS.Address2, 
		ADDRESS.City, 
		ADDRESS.Province, 
		ADDRESS.Zipcode, 
		ADDRESS.Country
	FROM dbo.EmployeeDetails AS EMPLOYEE
	JOIN dbo.Address AS ADDRESS
	ON EMPLOYEE.AddressID = ADDRESS.AddressID
	JOIN EmployeeDepartment AS EMP_DEP
	ON EMPLOYEE.EmployeeID = EMP_DEP.EmployeeID
GO

CREATE VIEW dbo.V_RegisterInformation
AS
	SELECT 
		REGISTRATION.PatientID,
		REGISTRATION.RegistrationID,
		REGISTRATION.EmployeeID,
		REGISTRATION.RoomID,
		REGISTRATION.LaboratoryID,
		REGISTRATION.AdmissionOn,
		REGISTRATION.DischargeOn,
		LAB_DETAILS.ReportID,
		LAB_DETAILS.Results
	FROM dbo.PatientRegistration AS REGISTRATION
	JOIN dbo.LaboratoryDetails AS LAB_DETAILS
	ON REGISTRATION.RegistrationID = LAB_DETAILS.RegistrationID
GO

CREATE VIEW dbo.V_RoleInformation
AS
	SELECT *
	FROM dbo.Role
GO

CREATE VIEW dbo.V_DepartmentInformation
AS
	SELECT *
	FROM dbo.DEPARTMENT
GO

CREATE VIEW dbo.V_RoomInformation
AS
	SELECT *
	FROM dbo.Room
GO

CREATE VIEW dbo.V_LaboratoryInformation
AS
	SELECT *
	FROM dbo.Laboratory
GO
/**********************************************
-- INSERT INTO TABLE VALUES
**********************************************/

INSERT INTO dbo.Room (Status, RoomCharge)
VALUES 
(0, 250),
(0, 250),
(0, 300),
(0, 350),
(0, 350),
(0, 450)

INSERT INTO dbo.Laboratory (Status, LabCharge)
VALUES
(0, 400),
(0, 400),
(0, 400),
(0, 600),
(0, 600),
(0, 600)

INSERT INTO dbo.Role (RoleID, Description)
VALUES
(0, 'Administrator'),
(1, 'Doctor'),
(2, 'Staff')

INSERT INTO dbo.Department (DepartmentName, DepCharge)
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