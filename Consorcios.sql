/*CREATE DATABASE Consorcios
GO*/


Use Consorcios
go
SELECT	E.EmpleadoId,
			E.Apellido,
			E.Nombre,
			E.CUIL,
			E.ValorHora,
			E.HorasPorMes,
			C.ConsorcioId,
			C.Nombre,
			C.CUIT
	FROM Empleados E
	INNER JOIN Consorcios C
		ON C.ConsorcioId = E.ConsorcioId
GO 

/*CREATE TABLE [dbo].[Consorcios](
	[ConsorcioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[CUIT] [char](11) NOT NULL,
 CONSTRAINT [PK_Consorcios] PRIMARY KEY CLUSTERED 
(
	[ConsorcioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Empleados](
	[EmpleadoId] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[CUIL] [char](11) NOT NULL,
	[ValorHora] [decimal](10, 2) NOT NULL,
	[HorasPorMes] [decimal](10, 2) NOT NULL,
	[ConsorcioId] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Consorcios] FOREIGN KEY([ConsorcioId])
REFERENCES [dbo].[Consorcios] ([ConsorcioId])
GO

ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Consorcios]
GO

CREATE PROCEDURE Consorcios_DevolverTodos
AS
BEGIN
	SET NOCOUNT ON;

    SELECT	ConsorcioId,
			Nombre,
			CUIT
	FROM Consorcios
END
GO

CREATE PROCEDURE Empleados_Agregar
	@ConsorcioId INT,
	@Apellido NVARCHAR(100) = '', 
	@Nombre NVARCHAR(100) = '',
	@CUIL CHAR(11) = '',
	@ValorHora DECIMAL(10, 2) = 0,
	@HorasPorMes DECIMAL(10, 2) = 0
	
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO Empleados
		(ConsorcioId, Apellido, Nombre, CUIL, ValorHora, HorasPorMes)
	VALUES
		(@ConsorcioId, @Apellido, @Nombre, @CUIL, @ValorHora, @HorasPorMes)

	SELECT	EmpleadoId, 
			ConsorcioId,
			Apellido,
			Nombre,
			CUIL,
			ValorHora,
			HorasPorMes
	FROM Empleados
	WHERE EmpleadoId = SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE Empleados_DevolverTodos
AS
BEGIN
	SET NOCOUNT ON;

    SELECT	E.EmpleadoId,
			E.Apellido,
			E.Nombre,
			E.CUIL,
			E.ValorHora,
			E.HorasPorMes,
			C.ConsorcioId,
			C.Nombre,
			C.CUIT
	FROM Empleados E
	INNER JOIN Consorcios C
		ON C.ConsorcioId = E.ConsorcioId
END
GO

INSERT INTO Consorcios
	(Nombre, CUIT)
VALUES
	('Dumbledor I', '33123456780'),
	('Dumbledor II', '33234567890'),
	('Pampa', '44123456780'),
	('Nijocali I', '55123456780'),
	('Nijocali II', '55234567890')\

*/

/*
create procedure Buscar_Cuil
@CUIL char(11)
as
begin
 SELECT	E.EmpleadoId,
			E.Apellido,
			E.Nombre,
			E.CUIL,
			E.ValorHora,
			E.HorasPorMes,
			C.ConsorcioId,
			C.Nombre,
			C.CUIT
	FROM Empleados E 
	INNER JOIN Consorcios C
		ON C.ConsorcioId = E.ConsorcioId
		where CUIL=@CUIL
end
go


*/