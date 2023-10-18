CREATE TABLE [dbo].[users] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [userName] NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED ([Id] ASC)
);


