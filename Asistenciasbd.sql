USE [SistemaAsistencias]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[Id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_cargo] [varchar](max) NULL,
	[Sueldo_por_hora] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[Id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[Id_personal] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](max) NULL,
	[Identificacion] [varchar](max) NULL,
	[Pais] [varchar](max) NULL,
	[Id_cargo] [int] NULL,
	[Sueldo_por_hora] [numeric](18, 2) NULL,
	[Estado] [varchar](max) NULL,
	[Codigo] [varchar](max) NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[Id_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Cargo] FOREIGN KEY([Id_cargo])
REFERENCES [dbo].[Cargo] ([Id_cargo])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_Cargo]
GO
/****** Object:  StoredProcedure [dbo].[BuscarCargo]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarCargo]
@buscador varchar(50)
as
select Id_cargo,Nombre_cargo,Sueldo_por_hora as Sueldo  from Cargo
where Nombre_cargo lIKE '%' + @buscador +'%'
GO
/****** Object:  StoredProcedure [dbo].[BuscarPersonal]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarPersonal]
@Desde int,
@Hasta int,
@Buscador varchar(60)
as
Set Nocount On;
Select 
Id_personal,Nombres,Identificacion,Sueldo_por_hora,Nombre_cargo,Id_cargo,Estado,codigo
from
(Select Id_personal ,Nombres,Identificacion,Personal.Sueldo_por_hora,Nombre_cargo,Personal.Id_cargo,Estado,codigo,
Row_Number() Over(Order by Id_personal) 'Numero_de_fila'
from Personal
inner join Cargo on Cargo.Id_cargo=Personal.Id_cargo ) as Paginado
Where (Paginado.Numero_de_fila >=@Desde) and (Paginado.Numero_de_fila<=@Hasta)
and (Nombres + Identificacion like	'%' + @Buscador + '%')
GO
/****** Object:  StoredProcedure [dbo].[EditarCargo]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarCargo]
@id int,
@NombreCargo varchar(max)
,@Sueldo as numeric(18,2)
as
if EXISTS (SELECT Nombre_cargo FROM Cargo  where Nombre_cargo = @NombreCargo and Id_cargo<>@id  )
RAISERROR ('YA EXISTE UN CARGO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
update  Cargo set Nombre_cargo=@NombreCargo, Sueldo_por_hora=@Sueldo
where Id_cargo=@id
GO
/****** Object:  StoredProcedure [dbo].[EditarPersonal]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarPersonal]
@Id_personal int ,
@Nombres Varchar(max),	
@Identificacion Varchar(max),
@Pais Varchar(max),
@Id_cargo int,
@Sueldo_por_hora numeric(18,2)

as
	--validacion
	if exists(select Identificacion from personal where Identificacion=@Identificacion and Id_personal <> @Id_personal)
	raiserror ('Ya existe un registro con esta identificacion', 16,1)
	
	
	else
Update Personal set
Nombres = @Nombres, Identificacion=@Identificacion, Pais  =@Pais , Id_cargo= @Id_cargo , Sueldo_por_hora =@Sueldo_por_hora
where Id_personal =@Id_personal
GO
/****** Object:  StoredProcedure [dbo].[EliminarPersonal]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarPersonal]

@Id_personal int
as
Update Personal set Estado='ELIMINADO'
where Id_personal = @Id_personal 
GO
/****** Object:  StoredProcedure [dbo].[InsertarCargo]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarCargo]
@NombreCargo varchar(max),
@Sueldo_por_hora numeric(18,2)
as
if EXISTS (SELECT Nombre_cargo FROM Cargo  where Nombre_cargo = @NombreCargo  )
RAISERROR ('YA EXISTE UN CARGO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
insert into Cargo  values (@NombreCargo, @Sueldo_por_hora)
GO
/****** Object:  StoredProcedure [dbo].[InsertarPersonal]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarPersonal]
@Nombres Varchar(max),	
@Identificacion Varchar(max),
@Pais Varchar(max),
@Id_cargo int,
@Sueldo_por_hora numeric(18,2)

	as
	
	declare @Estado Varchar(max)
	declare @Codigo Varchar(max)
	declare	@Id_personal int

	set @Estado = 'ACTIVO'
	set @Codigo = '-'


			--validacion
			if Exists (select Identificacion from Personal where Identificacion=@Identificacion)
			Raiserror('Ya existe un registro con esta identificacion',16,1)
			else



Insert Into Personal
Values (
@Nombres ,
@Identificacion,
@Pais ,
@Id_cargo ,
@Sueldo_por_hora ,
@Estado ,
@Codigo 
)
Select @Id_personal=SCOPE_IDENTITY()
Update Personal set Codigo = @Id_personal



GO
/****** Object:  StoredProcedure [dbo].[MostrarPersonal]    Script Date: 11/05/2023 10:50:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarPersonal]
@Desde int,
@Hasta int
as
Set Nocount On;
Select 
Id_personal,Nombres,Identificacion,Sueldo_por_hora,Nombre_cargo,Id_cargo,Estado,codigo
from
(Select Id_personal ,Nombres,Identificacion,Personal.Sueldo_por_hora,Nombre_cargo,Personal.Id_cargo,Estado,codigo,
Row_Number() Over(Order by Id_personal) 'Numero_de_fila'
from Personal
inner join Cargo on Cargo.Id_cargo=Personal.Id_cargo ) as Paginado
Where (Paginado.Numero_de_fila >=@Desde) and (Paginado.Numero_de_fila<=@Hasta)
GO
