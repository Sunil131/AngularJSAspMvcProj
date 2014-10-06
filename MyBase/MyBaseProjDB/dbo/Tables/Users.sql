CREATE TABLE [dbo].[Users] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [First]       NVARCHAR (50) NOT NULL,
    [Middle]      NVARCHAR (50) NULL,
    [Last]        NVARCHAR (50) NOT NULL,
    [DateofBirth] DATE          NOT NULL,
    [Phone]       NVARCHAR (15) NULL,
    [Mobile]      NVARCHAR (15) NULL,
    [CreatedBy]   INT           NULL,
    [CreatedOn]   DATETIME      NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Users_UserProfile1] FOREIGN KEY ([ID]) REFERENCES [dbo].[UserProfile] ([UserId])
);

