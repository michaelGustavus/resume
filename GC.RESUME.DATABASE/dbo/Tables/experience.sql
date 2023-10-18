CREATE TABLE [dbo].[experience] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [profileId]   UNIQUEIDENTIFIER NOT NULL,
    [title]       NVARCHAR (MAX)   NOT NULL,
    [employer]    NVARCHAR (MAX)   NOT NULL,
    [fromDt]      DATETIME         NULL,
    [toDt]        DATETIME         NULL,
    [description] NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_experience_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_experience_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);


