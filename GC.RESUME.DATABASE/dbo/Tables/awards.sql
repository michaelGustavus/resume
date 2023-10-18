CREATE TABLE [dbo].[awards] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [profileId] UNIQUEIDENTIFIER NOT NULL,
    [place]     NCHAR (3)        NOT NULL,
    [location]  NVARCHAR (50)    NULL,
    [compName]  NVARCHAR (50)    NOT NULL,
    [yearRec]   INT              NOT NULL,
    CONSTRAINT [PK__awards__3214EC0717553816] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_awards_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);


