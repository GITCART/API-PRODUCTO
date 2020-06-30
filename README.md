# AspnetCore C#  - Angular

## Aplicación con ASP.NET Core WebAPI y Angular (v9)

El objetivo de este trabajo es mostrar un listado de productos y el detalle al ser seleccionado

Disponibles para el uso del WEB API

* Listado de productos
* Listado del detalle del producto

### Como utlizar el WEB - API:
1. Clonar este proyecto en tu maquina
2. Instale y configue [SQL-SERVER](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) 
3. Ejecute el Query para crear el tabla [Sql-Query](https://github.com/GITCART/API-PRODUCTO/blob/master/QuerySQL.sql)
3. En el Web Api de la clase de conexión
    * Ponga el nombre del servidor en la etiqueta [SERVER](https://github.com/GITCART/API-PRODUCTO/blob/master/WebApi/Datos/ConexionBD.cs)
    * Ponga el nombre del base de datos [DATABASE](https://github.com/GITCART/API-PRODUCTO/blob/master/WebApi/Datos/ConexionBD.cs)
    * Ponga el nombre de usuario en la etiqueta [USER](https://github.com/GITCART/API-PRODUCTO/blob/master/WebApi/Datos/ConexionBD.cs)
    * Coloque la contraseñas en la etiqueta [PASSWORD](https://github.com/GITCART/API-PRODUCTO/blob/master/WebApi/Datos/ConexionBD.cs)
4. Finalmente, compila y ejecuta la aplicación

### Como utilizar el Web - SPA
1. Instalar [NODEJS](https://nodejs.org/es/) para poder instalar Angular
2. Instalar [ANGULAR](https://angular.io/)
3. Para reconstruir la Web-SPA ejecute  en [WEB-SPA](https://github.com/GITCART/API-PRODUCTO/tree/master/WebSpa)
    ```
    npm install
    ```
4. Ejecutar `ng serve` para un servidor de desarrollo. Navega hasta `http://localhost:4200/`. La aplicación se volverá a cargar automáticamente si cambia alguno de los archivos de origen.
5. Mas información sobre el proyecto de [WEB-AGULAR](https://github.com/GITCART/API-PRODUCTO/blob/master/WebSpa/README.md)

### Tecnologias Implementadas
* ASP.NET Core 3.0
* Conexión a la base de datos SQL SERVER 2019
* Swagger
* Angular 9
* TypeScript
* Bootstrap 4

### Arquitectura
* Arquitectura de capas (WebApi)
* Código Limpio
* Arquitectura MVC (Angular)