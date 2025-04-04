CREATE TABLE [dbo].[Personal] (
    [Number]        INT            NOT NULL,
    [FIO]           NVARCHAR (50)  NULL,
    [Podrazdelenie] NVARCHAR (50)  NULL,
    [Dolznost]      NVARCHAR (50)  NULL,
    [INN]           INT            NULL,
    [Adres]         NVARCHAR (250) NULL,
    [Data_priema]   NVARCHAR (50)  NULL,
    [Semia]         NVARCHAR (250) NULL,
    [Obrazovanie]   NVARCHAR (250) NULL,
    [Nagradi]       NVARCHAR (500) NULL, 
    CONSTRAINT [PK_Personal] PRIMARY KEY ([Number])
);


