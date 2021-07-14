CREATE TABLE [dbo].[Vacancies] (
    [Id]          INT           NOT NULL,
    [CompanyId]   INT           DEFAULT ((0)) NULL,
    [Title]       VARCHAR (50)  DEFAULT ('') NOT NULL,
    [Description] VARCHAR (250) DEFAULT ('') NOT NULL,
    [Active]      BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

