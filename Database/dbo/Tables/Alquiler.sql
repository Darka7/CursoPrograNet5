CREATE TABLE dbo.Alquiler
(
	  AlquilerId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Alquiler PRIMARY KEY CLUSTERED(AlquilerId)
	, FechaAlquiler DATE NOT NULL
	, FechaRegresarAlquiler DATE NOT NULL
	, AngeciasId INT NOT NULL 
		CONSTRAINT FK_Alquiler_Angecias FOREIGN KEY(AngeciasId) REFERENCES dbo.Angecias(AngeciasId)
	, VehiculoId INT NOT NULL 
		CONSTRAINT FK_Alquiler_Vehiculo FOREIGN KEY(VehiculoId) REFERENCES dbo.Vehiculo(VehiculoId)
)
WITH (DATA_COMPRESSION = PAGE)
GO