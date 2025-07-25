#Prueba Técnica: Gestión de Roles y Usuarios

Pequeña aplicación ASP.NET Core MVC para gestionar roles y usuarios con Entity Framework Core.

## Requisitos

- .NET 6.0 o superior
- SQL Server (o la base de datos que estés usando)
- Visual Studio
Paquetes NuGet:
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

---

## Instalación

1. Clona el repositorio o descarga el código.
2. Abre la solución en Visual Studio.
3. Configura tu cadena de conexión en `appsettings.json`:
```json
"ConnectionStrings": {
  "Conn": "Server=TU_SERVIDOR;Database=TU_BD;Trusted_Connection=True;"
}
4.Ejecuta el proyecto (F5 o botón "Run").

## Notas
-La aplicación tiene completado el CRUD de Roles.
-Tener en cuenta: 
  - El CRUD de Usuarios está incompleto.
  - No permite crear un Usuario, parece guardar pero no lo hace, ni en SQL.
