CREATE TABLE [dbo].[profile] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [userId]    UNIQUEIDENTIFIER NOT NULL,
    [firstName] NVARCHAR (50)    NOT NULL,
    [midName]   NVARCHAR (50)    NULL,
    [lastName]  NVARCHAR (50)    NOT NULL,
    [address]   NVARCHAR (50)    NOT NULL,
    [address2]  NVARCHAR (50)    NULL,
    [city]      NVARCHAR (50)    NOT NULL,
    [state]     NCHAR (2)        NOT NULL,
    [zip]       NCHAR (5)        NOT NULL,
    [about]     NVARCHAR (MAX)   NULL,
    [interests] NVARCHAR (MAX)   NULL,
    [picURL]    NVARCHAR (200)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_profile_user] FOREIGN KEY ([userId]) REFERENCES [dbo].[users] ([Id])
);


