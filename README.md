🛒 E-Commerce App - TiendaNueva
Este proyecto es una aplicación web de comercio electrónico desarrollada con ASP.NET Core MVC. La aplicación permite a los usuarios navegar por un catálogo de productos, seleccionar cantidades dinámicamente y gestionar un carrito de compras de manera eficiente antes de finalizar la compra.

🚀 Funcionalidades Principales
Catálogo de Productos Dinámico: Visualización de productos con imágenes, descripciones y precios unitarios.

Selección Inteligente: Formulario dinámico que permite elegir la cantidad de cada producto mediante un sistema de índices enlazados (Model Binding).

Gestión de Carrito: * Filtrado automático de ítems no seleccionados mediante LINQ.

Cálculo automático de subtotales y precio final.

Persistencia de IDs mediante Guid para garantizar la integridad de los datos.

Arquitectura MVC: Separación clara de responsabilidades utilizando ViewModels para la transferencia de datos entre la vista y el controlador.

🛠️ Tecnologías Utilizadas
Backend: C# con .NET 8/9.

Framework Web: ASP.NET Core MVC.

Base de Datos: Entity Framework Core (SQL Server).

Frontend: Razor Pages, HTML5, CSS3 y Bootstrap para el diseño responsivo.

Lógica de Datos: LINQ para el filtrado de colecciones y manejo de objetos complejos.

📋 Estructura del Proyecto (Lógica del Carrito)
El corazón del sistema de compras reside en el CarritoItemController, donde implementamos una lógica robusta para procesar el formulario:

Recepción de Datos: El controlador recibe un MiCompraViewModel.

Filtrado: Se limpian los objetos donde el ProductoID es igual a Guid.Empty.

Enriquecimiento: Se recuperan los datos reales de la base de datos (nombres, imágenes) para evitar datos corruptos o manipulados desde el cliente.

Cálculo: Se ejecutan los métodos de negocio para obtener el total a pagar.
