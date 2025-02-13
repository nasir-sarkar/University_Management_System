CREATE TABLE [dbo].[Teacher] (
    [Teacher_ID]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (255) NULL,
    [Email]       VARCHAR (255) NULL,
    [Password]    VARCHAR (255) NULL,
    [DOB]         DATE          NULL,
    [Salary]      VARCHAR (255) NULL,
    [Department]  VARCHAR (255) NULL,
    [Blood]       VARCHAR (10)  NULL,
    [Gender]      VARCHAR (10)  NULL,
    [Father]      VARCHAR (255) NULL,
    [Mother]      VARCHAR (255) NULL,
    [Contact]     VARCHAR (20)  NULL,
    [Address]     VARCHAR (MAX) NULL,
    [Nationality] VARCHAR (100) NULL,
    [Status]      VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Teacher_ID] ASC)
);
