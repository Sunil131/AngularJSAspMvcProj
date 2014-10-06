CREATE TABLE [dbo].[ThreadPosts] (
    [Id]       INT NOT NULL,
    [ThreadId] INT NOT NULL,
    [PostId]   INT NOT NULL,
    CONSTRAINT [PK_ThreadPosts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ThreadPosts_Posts] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([ID]),
    CONSTRAINT [FK_ThreadPosts_Threads] FOREIGN KEY ([ThreadId]) REFERENCES [dbo].[Threads] ([ID])
);

