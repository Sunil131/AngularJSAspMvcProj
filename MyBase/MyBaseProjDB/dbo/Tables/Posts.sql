CREATE TABLE [dbo].[Posts] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [Header]      NVARCHAR (300)  NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [IsActive]    BIT             CONSTRAINT [DF_Posts_IsActive] DEFAULT ((1)) NOT NULL,
    [MetaTags]    NVARCHAR (1000) NOT NULL,
    [CreatedBy]   INT             NOT NULL,
    [CreatedOn]   DATETIME        NOT NULL,
    CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED ([ID] ASC)
);



