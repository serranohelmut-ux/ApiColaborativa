# ApiColaborativa

Laboratorio práctico de flujo colaborativo en Git. Proyecto ASP.NET Core Web API en .NET 10, creado sin OpenAPI.

## Integrantes y ramas

| Integrante | Cuenta | Aporte | Rama |
| --- | --- | --- | --- |
| Helmut Serrano | serranohelmut-ux | Base del proyecto y DTO | feature/dto-producto |
| Osmar Castro | OsACM | Entidad Producto y resolución del conflicto | feature/entidad-producto y feature/saludo-dev2 |
| Lleyton Méndez | CountryNC | Validador de Producto | feature/validador-producto |

## Ejecutar

Se necesita el SDK de .NET 10.

```powershell
dotnet build
dotnet run --launch-profile http
```

La aplicación escucha en `http://localhost:5121`. La ruta `/` devuelve el saludo del equipo; `/weatherforecast` conserva el ejemplo de la plantilla.

## Pull requests del laboratorio

- [Entidad Producto, PR #2](https://github.com/serranohelmut-ux/ApiColaborativa/pull/2): OsACM; revisión y merge de Helmut.
- [DTO Producto, PR #1](https://github.com/serranohelmut-ux/ApiColaborativa/pull/1): Helmut; aprobación de OsACM y merge de Helmut.
- [Validador de Producto, PR #3](https://github.com/serranohelmut-ux/ApiColaborativa/pull/3): CountryNC; revisión y merge de Helmut.
- [Saludo de Dev 1, PR #4](https://github.com/serranohelmut-ux/ApiColaborativa/pull/4): rama hotfix/puerto.
- [Conflicto resuelto, PR #5](https://github.com/serranohelmut-ux/ApiColaborativa/pull/5): OsACM; revisión y merge de Helmut.

GitHub no permite aprobar un PR propio. Por eso OsACM revisó el DTO del líder.

## Conflicto en Program.cs

Las ramas de Dev 1 y Dev 2 partieron de la misma base e incorporaron saludos distintos en el mismo lugar. Después de integrar hotfix/puerto, `git pull origin main` en la copia local de Dev 2 produjo `CONFLICT (content)` en Program.cs. Se quitaron las marcas de conflicto y se conservó un solo endpoint:

```csharp
app.MapGet("/", () => "Hola desde el equipo Dev 1 y Dev 2");
```

La resolución también quedó guardada en GitHub desde OsACM. Las tres copias locales se sincronizaron con main.

## Forma de trabajo y validación

La práctica se ejecutó en una computadora compartida con tres copias locales y las tres cuentas de GitHub. Se configuró la identidad por repositorio para mantener separadas las cuentas. La publicación de los cambios se hizo desde las sesiones de GitHub y el conector, porque Git en la terminal no tenía autenticación; se usó HTTPS para clonar y sincronizar.

Compilación final: 0 errores y 0 advertencias. Las rutas `/` y `/weatherforecast` se comprobaron mediante solicitudes HTTP.
