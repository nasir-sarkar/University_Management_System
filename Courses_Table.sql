CREATE TABLE [dbo].[Courses] (
    [Title]         VARCHAR (255) NULL,
    [Section]       VARCHAR (255) NULL,
    [Credit]        VARCHAR (255) NULL,
    [Starting_Time] TIME (7)      NOT NULL,
    [Ending_Time]   TIME (7)      NOT NULL,
    [Semester]      VARCHAR (255) NULL,
    [Course_ID]     VARCHAR (255) NOT NULL,
    [Days]          VARCHAR (255) NULL,
    [Count]         INT           NULL
);