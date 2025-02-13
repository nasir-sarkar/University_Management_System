CREATE TABLE [dbo].[Admin] (
    [Admin_ID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (255) NULL,
    [Email]    VARCHAR (255) NULL,
    [Password] VARCHAR (255) NULL,
    [DOB]      DATE          NULL,
    [Gender]   VARCHAR (10)  NULL,
    [Status]   VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Admin_ID] ASC)
);
