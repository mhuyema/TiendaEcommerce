# 🛒 iMove E-Commerce - .NET 10 MVC

![.NET 9.0](https://img.shields.io/badge/.NET-10.0-purple) ![Entity Framework Core](https://img.shields.io/badge/EF%20Core-Code%20First-blue) ![Status](https://img.shields.io/badge/Status-In%20Development-yellow)

> **Proyecto personal Full Stack** desarrollado para aplicar patrones de arquitectura modernos, seguridad con Identity y lógica de negocio compleja en ASP.NET Core.

## 📋 Sobre el Proyecto

**iMove** es una plataforma de comercio electrónico diseñada para simular el ciclo de vida real de una compra online. El foco principal de este desarrollo no fue solo la interfaz, sino la implementación robusta de **Seguridad (Autenticación/Autorización)** y la gestión de estado del carrito de compras.

Actualmente, el proyecto sirve como demostración de habilidades en **.NET 9**, manejo de bases de datos relacionales con **SQL Server** y arquitectura **MVC**.

---

## 📷 Screenshots

![Panel Principal]([Ruta a tu imagen principal o GIF aquí])
*(Vista del catálogo de productos y navegación)*

---

## 🛠️ Tech Stack

### Backend & Datos
* **Framework:** .NET 10 (ASP.NET Core MVC).
* **ORM:** Entity Framework Core (Enfoque *Code First*).
* **Base de Datos:** SQL Server.
* **Seguridad:** ASP.NET Core Identity.
* **Lógica:** LINQ para consultas avanzadas y filtrado.

### Frontend
* **Motor de Vistas:** Razor Views (.cshtml).
* **Estilos:** Bootstrap 5 & CSS3 Custom.
* **Diseño:** Responsive & Mobile First.

---

## 🚀 Funcionalidades Implementadas

### 🔐 Seguridad y Gestión de Accesos (Identity)
Implementación completa de `IdentityUser` e `IdentityRole` para segregar la lógica de negocio:
* **Roles:** Diferenciación estricta entre **Administradores** y **Clientes**.
* **Protección de Rutas:** Uso de atributos `[Authorize]` en controladores para bloquear accesos no autorizados.
* **UI Dinámica:** La barra de navegación y las opciones visibles cambian según el rol del usuario logueado.

### 🛠️ Panel de Administración
Interfaz dedicada para la gestión del e-commerce:
* **CRUD de Productos:** Alta, baja y modificación de catálogo.
* **Gestión de Usuarios:** El administrador puede gestionar permisos y visualizar usuarios registrados.

### 🛒 Lógica de Carrito de Compras
Sistema de compra persistente y dinámico:
* Cálculo de totales en tiempo real.
* Persistencia de selección mediante `ViewModels` y manejo de sesiones.
* Uso de GUIDs para el rastreo único de transacciones en curso.

---

## 🗺️ Roadmap & Próximos Pasos

El proyecto se encuentra en desarrollo activo. Las próximas implementaciones planificadas son:

- [ ] **Pasarela de Pagos:** Integración con API de **Mercado Pago** para procesamiento real de transacciones.
- [ ] **Gestión de Stock:** Lógica de validación y descuento de inventario en base de datos post-confirmación.
- [ ] **Historial de Pedidos:** Sección de perfil de usuario para visualizar compras pasadas.
- [ ] **Dashboard de Métricas:** Gráficos para el admin (ventas mensuales, productos más vistos).

---

## 🔧 Configuración Local

Para clonar y ejecutar este proyecto en tu entorno local:

1.  **Requisitos:**
    * .NET SDK 9.0 instalado.
    * SQL Server (LocalDB o Express).

2.  **Clonar el repositorio:**
    ```bash
    git clone [https://github.com/TuUsuario/iMove-Ecommerce.git](https://github.com/TuUsuario/iMove-Ecommerce.git)
    ```

3.  **Configurar Base de Datos:**
    Ajusta la cadena de conexión en `appsettings.json`:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=iMoveDB;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```

4.  **Aplicar Migraciones (Code First):**
    ```bash
    dotnet ef database update
    ```

5.  **Ejecutar:**
    ```bash
    dotnet run
    ```

---

## 👤 Autor

**Matías Huyema**
* **Rol:** .NET Developer | Multimedia Designer
* **LinkedIn:** [Tu Link Aquí]
* **Portfolio:** [Tu Link Aquí]

---
