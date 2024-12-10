/* Only restore the database if it doesn't already exist */
IF NOT EXISTS (SELECT * FROM sys.databases WHERE [name] = 'AdventureWorks2022')
BEGIN
	RESTORE DATABASE [AdventureWorks2022] 
    FROM DISK = N'/var/opt/mssql/backup/AdventureWorks2022.bak' 
    WITH FILE = 1,
    MOVE N'AdventureWorks2022' TO N'/var/opt/mssql/data/AdventureWorks2022.mdf',
    MOVE N'AdventureWorks2022_log' TO N'/var/opt/mssql/data/AdventureWorks2022_log.ldf',
    NOUNLOAD,
    STATS = 5
END
GO
