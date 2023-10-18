CREATE TABLE [dbo].[education] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [profileId]   UNIQUEIDENTIFIER NOT NULL,
    [schoolName]  NVARCHAR (50)    NOT NULL,
    [degreeTitle] TEXT             NOT NULL,
    [degreePath]  TEXT             NULL,
    [fromDt]      DATE             NOT NULL,
    [toDt]        DATE             NOT NULL,
    [GPA]         DECIMAL (18)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_education_profile] FOREIGN KEY ([profileId]) REFERENCES [dbo].[profile] ([Id])
);


