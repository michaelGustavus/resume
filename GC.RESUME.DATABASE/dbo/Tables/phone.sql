CREATE TABLE [dbo].[phone] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [profileId] UNIQUEIDENTIFIER NOT NULL,
    [phone]     NCHAR (10)       NOT NULL,
    CONSTRAINT [PK_phone_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_phone_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);


