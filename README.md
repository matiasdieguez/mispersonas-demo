# mispersonas-demo

----------------------------------------------------------
## Demo 1 - .NET Core
----------------------------------------------------------
dotnet new console
code .
dotnet restore
dotnet run

dotnet new webapi

----------------------------------------------------------
## Demo 2 - NuGet

- A partir de aca mostrar en VS
- Hacer un paquete nuget para buscar personas
- Buscar y generar online clase .NET en base a esquema Json de la AFIP

1-buscar si existe DNI (GET)
https://soa.afip.gob.ar/sr-padron/v2/personas/23456789

2-Buscar datos para el CUIT/CUIL devuelto, si existe (GET)
https://soa.afip.gob.ar/sr-padron/v2/persona/20234567897

----------------------------------------------------------
## Demo 3 - Sql Database y DataAccess
----------------------------------------------------------
crear dll DataAccess
1-dotnet new webapi
2-Guardar datos en tabla Personas
3-Listar datos en tabla Personas


----------------------------------------------------------
## Demo 4 - WebApi
----------------------------------------------------------
crear App Service para hostear el .net core web api
1-dotnet new webapi
2-Guardar datos en tabla Personas
3-Listar datos en tabla Personas

----------------------------------------------------------
## Demo 5 - Xamarin.Forms
----------------------------------------------------------
1-Crear página con textbox de búsqueda
2-Crear página de detalle de MisPersonas, con boton Guardar
3-Crear listado de personas, con boton abir mapa
4-Abrir link google maps
  https://www.google.com.ar/maps/search/belgrano+1180,+lomas+de+zamora
  
