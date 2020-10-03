-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Propenster
-- Create date: October 3rd, 2020.
-- Description:	Stored Procedures for an Health Monitoring and Management Startup..
-- =============================================
CREATE PROCEDURE [GetAllCardixPatients]

AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM [dbo].[CardixPatientTbl]
END

-- Get Patient by Primary Key - Id
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GetCardixPatientById]
@Id int

AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM [dbo].[CardixPatientTbl] WHERE Id=@Id
END

-- Get Patient by PatientId
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [GetCardixPatientByPatientId]
@PatientId int

AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM [dbo].[CardixPatientTbl] WHERE PatientId=@PatientId
END

-- Create a New Cardix Patient SP
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [AddNewCardixPatient]
@PatientId	nvarchar(20),
@Name nvarchar(50),
@Age	int,
@Sex	char(1),
@HealthCondition nvarchar(50),
@CurrentTemperature numeric(18, 2),
@CurrentBP int,
@CurrentHPR int,
@SleepRestHours int,
@ExcerciseHours int,
@MonitorName nvarchar(50),
@MonitorPhone nvarchar(15),
@MonitorEmail nvarchar(50),
@RegistrationHospital nvarchar(50),
@PatientLocationLat	numeric(6, 2),
@PatientLocationLong numeric(6, 2),
@PatientRegistrationDate datetime,
@LastCheckUpDate datetime,
@LastIncidentDate datetime

AS
BEGIN
SET NOCUNT ON;
INSERT INTO [dbo].[CardixPatientTbl]
(PatientId,
Name,
Age,
Sex,
HealthCondition,
CurrentTemperature,
CurrentBP,
CurrentHPR,
SleepRestHours,
ExcerciseHours,
MonitorName,
MonitorPhone,
MonitorEmail,
RegistrationHospital,
PatientLocationLat,
PatientLocationLong,
PatientRegistrationDate,
LastCheckUpDate,
LastIncidentDate)
VALUES
(@PatientId,
@Name,
@Age,
@Sex,
@HealthCondition,
@CurrentTemperature,
@CurrentBP,
@CurrentHPR,
@SleepRestHours,
@ExcerciseHours,
@MonitorName,
@MonitorPhone,
@MonitorEmail,
@RegistrationHospital,
@PatientLocationLat,
@PatientLocationLong,
@PatientRegistrationDate,
@LastCheckUpDate,
@LastIncidentDate)
END

-- Delete a CardixPatient Record
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DeleteCardixPatient]
@Id int

AS
BEGIN
SET NOCOUNT ON;
DELETE FROM [dbo].[CardixPatientTbl] WHERE Id=@Id
END

-- Update a CardixPatient Record...
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [UpdateCardixPatient]
@Id int,
@PatientId	nvarchar(20),
@Name nvarchar(50),
@Age	int,
@Sex	char(1),
@HealthCondition nvarchar(50),
@CurrentTemperature numeric(18, 2),
@CurrentBP int,
@CurrentHPR int,
@SleepRestHours int,
@ExcerciseHours int,
@MonitorName nvarchar(50),
@MonitorPhone nvarchar(15),
@MonitorEmail nvarchar(50),
@RegistrationHospital nvarchar(50),
@PatientLocationLat	numeric(6, 2),
@PatientLocationLong numeric(6, 2),
@PatientRegistrationDate datetime,
@LastCheckUpDate datetime,
@LastIncidentDate datetime

AS
BEGIN
SET NOCOUNT ON;
UPDATE [dbo].[CardixPatientTbl] SET
Id=@Id,
PatientId=@PatientId,
Name=@Name,
Age=@Age,
Sex=@Sex,
HealthCondition=@HealthCondition,
CurrentTemperature=@CurrentTemperature,
CurrentBP=@CurrentBP,
CurrentHPR=@CurrentHPR,
SleepRestHours=@SleepRestHours,
ExcerciseHours=@ExcerciseHours,
MonitorName=@MonitorName,
MonitorEmail=@MonitorEmail,
MonitorPhone=@MonitorPhone,
RegistrationHospital=@RegistrationHospital,
PatientLocationLat=@PatientLocationLat,
PatientLocationLong=@PatientLocationLong,
PatientRegistrationDate=@PatientRegistrationDate,
LastCheckUpDate=@LastCheckUpDate,
LastIncidentDate=@LastIncidentDate

END



