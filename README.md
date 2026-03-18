# Proyecto EF Core CRUD

Este proyecto consiste en una aplicación web desarrollada con ASP.NET Core que implementa operaciones CRUD utilizando Entity Framework Core.

## Tecnologías utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server (LocalDB)
- C#

## Funcionalidades

- Crear clientes
- Listar clientes
- Editar clientes
- Eliminar clientes
- Validaciones con DataAnnotations

## Base de datos

Se utilizó Entity Framework Core con migraciones para la creación de la base de datos.

Comandos utilizados:

dotnet ef migrations add InitialCreate
dotnet ef database update


## Estructura del proyecto

- Models
 Clase Cliente

- Data
 DbContext (TiendaContext)

- Controllers
 ClienteController (CRUD)

- Views
  Vistas generadas (Index, Create, Edit, Delete)

##  Alani María Encarnación García
