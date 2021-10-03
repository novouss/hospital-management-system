DROP TABLE dbo.PatientRegistration;
DROP TABLE dbo.Laboratory;
DROP TABLE dbo.Room;
DROP TABLE dbo.PatientDetails;

--
-- 1. Patient Details
--
CREATE TABLE PatientDetails (
	PatientID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Firstname VARCHAR(45) NULL,
	Lastname VARCHAR(45) NULL,
	Gender VARCHAR(45) NULL,
	Age INT NULL,
	Birthdate DATE NULL,
	Height DECIMAL(10, 2) NULL,
	Weight DECIMAL(10, 2) NULL,
	EmailID VARCHAR(45) NULL,
	PhoneNumber VARCHAR(45) NULL,
	CreatedOn DATE NULL,
	ModifiedOn DATE NULL
);

--
-- 2. Room
--
CREATE TABLE Room (
	RoomNumber INT NOT NULL PRIMARY KEY,
	Status VARCHAR(45) NULL,
	RoomCharge INT
);

--
-- 3. Laboratory
--
CREATE TABLE Laboratory (
	LabNumber INT NOT NULL PRIMARY KEY,
	Status VARCHAR(45) NULL
);

--
-- 4. Patient Registration
--
CREATE TABLE PatientRegistration (
	RegistrationID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	PatientID INT FOREIGN KEY REFERENCES PatientDetails(PatientID) NOT NULL,
	AdmissionOn DATE NULL,
	DischargeOn DATE NULL,
	Status VARCHAR(10) NULL,
	RoomNumber INT FOREIGN KEY REFERENCES Room(RoomNumber),
	LabNumber INT FOREIGN KEY REFERENCES Laboratory(LabNumber)
);

INSERT INTO dbo.PatientDetails (Firstname, Lastname, Gender, Age, Birthdate, Height, Weight, EmailID, PhoneNumber, CreatedOn) VALUES
('Raymond', 'Gorospe', 'Male', 20, '2000-11-13', 5.5, 22.0, 'raymondgorospe@gmail.com', '09162711323', GETDATE()),
('John', 'John', 'Male', 25, '1995-12-25', 6.4, 32.0, 'johnjohn@business.com', '09772681369', GETDATE());

SELECT * FROM dbo.Laboratory;
SELECT * FROM dbo.PatientDetails;
SELECT * FROM dbo.PatientRegistration;
SELECT * FROM dbo.Room;