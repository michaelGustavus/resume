CREATE TABLE [dbo].[email] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [profileId] UNIQUEIDENTIFIER NOT NULL,
    [email]     NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_email_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_email_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);


