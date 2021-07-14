CREATE TABLE [dbo].[COMPANY] (
    [Id]      INT           NOT NULL,
    [Name]    VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Address] VARCHAR (250) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

