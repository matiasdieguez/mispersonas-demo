CREATE TABLE [dbo].[Personas]
(
	[Id] BIGINT NOT NULL PRIMARY KEY, 
    [Nombre] NVARCHAR(2000) NULL, 
    [Direccion] NVARCHAR(1000) NULL, 
    [Localidad] NVARCHAR(1000) NULL
)
