CREATE DATABASE PostOffice;
GO
USE PostOffice
GO
CREATE TABLE [dbo].[PostalSending](
	[SenderName] [varchar](100) NOT NULL,
	[ReceiverName] [varchar](100) NULL,
	[DocumentTitle] [varchar](255) NOT NULL,
	[NumberOfPages] [smallint] NOT NULL,
	[SendingDate] [DateTimeOffset] NOT NULL,
	[ExpectedReceivingDate] [DateTimeOffset] NOT NULL
);
GO

INSERT INTO [dbo].[PostalSending] (
	[SenderName],
	[ReceiverName],
	[DocumentTitle],
	[NumberOfPages],
	[SendingDate],
	[ExpectedReceivingDate])
VALUES(
	'Andrei A Golyakov',
	'Ivan I Ivanov',
	'The Ultimate Crossword Guide',
	30535,
	GETUTCDATE(),
	'2021-01-17 16:47')

INSERT INTO [dbo].[PostalSending] (
	[SenderName],
	[DocumentTitle],
	[NumberOfPages],
	[SendingDate],
	[ExpectedReceivingDate])
VALUES(
	'Ivan I Ivanov',
	'RE: The Ultimate Crossword Guide',
	100,
	GETUTCDATE() + 2,
	GETUTCDATE() + 4)

SELECT *
FROM dbo.PostalSending
WHERE NumberOfPages > 100
	AND ReceiverName IS NULL
ORDER BY SenderName

DROP TABLE dbo.PostalSending