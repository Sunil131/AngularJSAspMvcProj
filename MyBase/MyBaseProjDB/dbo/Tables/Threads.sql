CREATE TABLE [dbo].[Threads] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Header]      NVARCHAR (300) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [FirstPostId] NCHAR (10)     NOT NULL,
    [IsActive]    BIT            CONSTRAINT [DF_Threads_IsActive] DEFAULT ((1)) NOT NULL,
    [CreatedOn]   DATETIME       NOT NULL,
    [CreatedBy]   INT            NOT NULL,
    CONSTRAINT [PK_Threads] PRIMARY KEY CLUSTERED ([ID] ASC)
);

