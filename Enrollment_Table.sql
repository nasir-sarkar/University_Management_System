CREATE TABLE [dbo].[Enrollment] (
    [Course_ID]     VARCHAR (255) NOT NULL,
    [Title]         VARCHAR (255) NULL,
    [Section]       VARCHAR (255) NULL,
    [Credit]        VARCHAR (255) NULL,
    [Semester]      VARCHAR (255) NULL,
    [Student_ID]    INT           NULL,
    [Teacher_ID]    INT           NULL,
    [Grade]         VARCHAR (255) NULL,
    [Starting_Time] TIME (7)      NOT NULL,
    [Ending_Time]   TIME (7)      NOT NULL,
    [Days]          VARCHAR (255) NULL
);