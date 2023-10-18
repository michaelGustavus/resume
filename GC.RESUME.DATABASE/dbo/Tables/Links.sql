CREATE TABLE [dbo].[Links] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [profileId]   UNIQUEIDENTIFIER NOT NULL,
    [LinkedInURL] NVARCHAR (MAX)   NULL,
    [FacebookURL] NVARCHAR (MAX)   NULL,
    [GithubURL]   NVARCHAR (MAX)   NULL,
    [TwitterURL]  NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_Links] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Links_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);



