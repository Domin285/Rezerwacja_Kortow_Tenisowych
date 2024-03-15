# Rezerwacja_Kortow_Tenisowych

Poniżej opisane zostaną postępowania, które należy wykonać, aby projekt działał poprawnie.

1. Na samym początku należy zainstalować program SQL Server Management Studio (SSMS). 
Link do tutorialu: https://www.youtube.com/watch?v=iaUXjTL_F9U

2. Po zainstalowaniu programu SSMS wybieramy serwer 'DESKTOP-P0CU9U3\SQLEXPRESS'. 
Następnie tworzymy bazę o nazwie 'BazaProjektNowy' i tworzymy w nim tabele używając poniższych zapytań SQL.

Tabela #1:

USE [BazaProjektNowy]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EventAdd](
	[Data] [date] NOT NULL,
	[Event] [varchar](50) NOT NULL,
	[Godzina] [varchar](50) NOT NULL,
	[Kto] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

Tabela #2:

USE [BazaProjektNowy]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LoginPage](
	[Login] [varchar](50) NOT NULL,
	[Haslo] [varchar](50) NOT NULL,
	[CzyAdmin] [bit] NOT NULL
) ON [PRIMARY]
GO

3. Kolejnym krokiem jest utworzenie naszego administratora. Użyjemy do tego poniższego zapytania SQL.

INSERT INTO LoginPage VALUES ('admin', 'admin', 'True');

4. Ostatnim krokiem będzie połączenie naszej bazy danych z projektem. W polu wyboru serwera należy wpisać podaną wyżej nazwę serwera oraz wybrac naszą bazę.
Link do tutorialu: https://www.youtube.com/watch?v=HeGNMgdQ79M
