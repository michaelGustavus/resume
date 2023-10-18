CREATE TABLE [dbo].[certification] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [profileId]    UNIQUEIDENTIFIER NOT NULL,
    [recievedFrom] NVARCHAR (50)    NOT NULL,
    [certTitle]    NVARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_certification_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);


