🛒 iMove E-Commerce - .NET 9 MVC
iMove es una aplicación web de comercio electrónico desarrollada como proyecto personal para aplicar conceptos avanzados de ASP.NET Core MVC. El foco principal fue la implementación de un sistema de seguridad robusto y la gestión lógica del ciclo de vida de una compra.

🚀 Funcionalidades Implementadas
Autenticación y Autorización (Identity): Uso de IdentityUser e IdentityRole para diferenciar permisos entre administradores y clientes.

Gestión de Accesos: Control de visibilidad de elementos en la interfaz (Navbar) y protección de endpoints mediante el atributo [Authorize] según el rol del usuario.

Panel Administrativo: Interfaz funcional para que el administrador pueda editar productos y gestionar los permisos de otros usuarios.

Lógica de Carrito: Sistema de selección de productos con cálculo dinámico de totales y persistencia de datos mediante ViewModels y Guids.

Arquitectura de Estados: Implementación del patrón de diseño State mediante la interfaz IEstado para controlar los flujos del carrito (Activo, Vendido, Abandonado).

🛠️ Stack Técnico
Framework: .NET 9 (MVC).

ORM: Entity Framework Core (Code First) con SQL Server.

Seguridad: ASP.NET Core Identity.

Frontend: Razor Views, HTML, CSS y Bootstrap.

Herramientas: LINQ para consultas y filtrado de datos.

📋 Estado del Proyecto y Roadmap
El proyecto se encuentra en una etapa funcional de preventa. Los siguientes pasos técnicos son:

Integración de Mercado Pago SDK para el procesamiento de transacciones.

Lógica de validación y descuento de Stock en la base de datos al confirmar el pago.

Desarrollo del historial de pedidos vinculado al perfil del usuario.
