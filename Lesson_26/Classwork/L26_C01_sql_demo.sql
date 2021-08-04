-- Создание базы данных с настройками "по умолчанию"
CREATE DATABASE Banking

-- Создание таблицы с пятью полями
CREATE TABLE [dbo].[CreditCard](
	[CardNumber] [char](20) NOT NULL,
	[HolderName] [char](50) NULL,
	[ExpirationMonth] [tinyint] NOT NULL,
	[ExpirationYear] [tinyint] NOT NULL,
	[SecurityCode] [smallint] NOT NULL
) ON [PRIMARY]
GO

-- Вставка единичной записи в таблицу
INSERT INTO [dbo].[CreditCard] (
	[CardNumber],
	[HolderName],
	[ExpirationMonth],
	[ExpirationYear],
	[SecurityCode])
VALUES ('01234567890123456789', 'ANDREY GOLYAKOV', 6, 23, 532)

-- Выборка всех полей (*) всех записей из таблицы
SELECT * FROM [dbo].[CreditCard]

-- Удаление таблицы
DROP TABLE [dbo].[CreditCard]

-- Удаление базы данных
DROP DATABASE Banking