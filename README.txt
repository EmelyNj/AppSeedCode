#Prueba T�cnica: Gesti�n de Roles y Usuarios

Peque�a aplicaci�n ASP.NET Core MVC para gestionar roles y usuarios con Entity Framework Core.

## Requisitos

- .NET 6.0 o superior
- SQL Server (o la base de datos que est�s usando)
- Visual Studio
Paquetes NuGet:
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

---

## Instalaci�n

1. Clona el repositorio o descarga el c�digo.
2. Abre la soluci�n en Visual Studio.
3. Configura tu cadena de conexi�n en `appsettings.json`:
```json
"ConnectionStrings": {
  "Conn": "Server=TU_SERVIDOR;Database=TU_BD;Trusted_Connection=True;"
}
4.Ejecuta el proyecto (F5 o bot�n "Run").

## Notas
-La aplicaci�n tiene completado el CRUD de Roles.
-Tener en cuenta: 
  - El CRUD de Usuarios est� incompleto.
  - No permite crear un Usuario, parece guardar pero no lo hace, ni en SQL.
