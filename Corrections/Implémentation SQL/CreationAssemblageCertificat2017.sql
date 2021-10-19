USE master;
GO
CREATE CERTIFICATE BostTestCert
FROM FILE = 'C:\Certificat\BostCert.cer';
GO
CREATE LOGIN login_BostTestCert 
FROM CERTIFICATE BostTestCert
GO

GRANT UNSAFE ASSEMBLY TO login_BostTestCert;

USE StagiaireDB
GO
ALTER DATABASE StagiaireDB
SET TRUSTWORTHY ON;
GO

CREATE ASSEMBLY [IntegrationSQL]
FROM 'C:\01 CDA\M3 - Dév Persistance Données\04 Implémenter la DB\Corrections\A002\ImplementationSQL\TypesSQL\bin\Release\TypesSQL.dll'
WITH PERMISSION_SET = UNSAFE;