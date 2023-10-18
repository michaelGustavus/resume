CREATE TABLE [dbo].[languages] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [profileId] UNIQUEIDENTIFIER NOT NULL,
    [langName]  NVARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_languages_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);


