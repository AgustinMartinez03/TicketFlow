# 🎫 TicketFlow - Plataforma de Reserva de Entradas

TicketFlow es una solución de software escalable para la gestión y reserva de entradas de eventos, diseñada aplicando **Clean Architecture** para garantizar un alto desacoplamiento entre las reglas de negocio y la infraestructura.

Este repositorio contiene la **Entrega 1**, que establece la infraestructura base, el modelo de dominio, la API de Catálogo y la experiencia de usuario (UX) inicial para la selección de butacas.

---

## 🏗️ Arquitectura y Tecnologías

El proyecto está dividido en dos grandes bloques completamente desacoplados:

### Backend (API RESTful)
* **Framework:** .NET 8 (C#)
* **Arquitectura:** Clean Architecture (Domain, Application, Infrastructure, API).
* **Patrones:** Inyección de Dependencias (IoC), CQRS (Separación de Commands/Queries), DTOs y Mappers.
* **Base de Datos:** SQL Server.
* **ORM:** Entity Framework Core (Code-First).

### Frontend (SPA Vanilla)
* **Lenguajes:** HTML5, CSS3, JavaScript (Vanilla ES6+).
* **Framework CSS:** Bootstrap 5.
* **Librerías Extra:** SweetAlert2 (Para modales y alertas UX).
* **Enfoque:** Modular (Componentes y Servicios separados), Diseño Responsive y Accesibilidad (WAI-ARIA).

---

## 🚀 Requisitos Previos

Para ejecutar este proyecto, necesitas:
1. [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. **Docker Desktop** (Recomendado para la API y la Base de Datos).
3. Extensión **Live Server** (en VS Code) para levantar el frontend.
   
*(Opcional: Si no usas Docker, requerirás SQL Server local y Visual Studio 2022).*

---

## 🐳 Opción A: Ejecución Rápida con Docker (Recomendado)

El proyecto incluye un entorno preconfigurado mediante `docker-compose` que levanta la API y la Base de Datos SQL Server automáticamente.

### Paso 1: Levantar Backend y Base de Datos
1. Abre una terminal y navega hasta la carpeta raíz donde se encuentra la solución (la carpeta `TicketFlow` que contiene el archivo `docker-compose.yml`).
2. Ejecuta el siguiente comando:
   ```bash
   docker-compose up -d --build
   ```
3. Docker descargará las imágenes, configurará SQL Server y levantará la API de TicketFlow.
4. Puedes verificar que la API está funcionando accediendo a la documentación autogenerada (Swagger UI) en tu navegador, generalmente en: `http://localhost:8080/swagger` (o el puerto mapeado en tu consola).

### Paso 2: Levantar el Frontend
1. Abre la carpeta raíz del proyecto en Visual Studio Code.
2. Haz clic derecho sobre el archivo `/frontend/index.html` y selecciona **"Open with Live Server"**.
*(Nota: Asegúrate de que las URLs en `/frontend/Js/Services/` apunten al puerto expuesto por tu contenedor de Docker).*

### Apagar los servicios
Cuando termines de probar, puedes apagar y limpiar los contenedores ejecutando:
```bash
docker-compose down
```

---

## ⚙️ Opción B: Ejecución Local Manual (Visual Studio)

Si prefieres no usar Docker y ejecutar todo localmente:

### Paso 1: Configurar la Base de Datos
1. Abre la solución `TicketFlow.sln` en Visual Studio.
2. Dirígete al proyecto **`TicketFlow.API`** y abre el archivo `appsettings.Development.json`.
3. Verifica que la cadena de conexión (`DefaultConnection`) apunte a tu servidor SQL Server local. Ejemplo:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=TicketFlowDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```

### Paso 2: Ejecutar las Migraciones y Seed
El proyecto incluye un script de inicialización (`Seed`) que cargará 1 evento activo, sectores y butacas automáticamente.
1. Abre la **Consola del Administrador de Paquetes** en Visual Studio.
2. Selecciona **`TicketFlow.Infrastructure`** como Proyecto Predeterminado.
3. Ejecuta:
   ```powershell
   Update-Database -Project TicketFlow.Infrastructure -StartupProject TicketFlow.API
   ```

### Paso 3: Levantar el Backend (API)
1. Establece **`TicketFlow.API`** como proyecto de inicio.
2. Presiona `F5`. Se abrirá automáticamente **Swagger UI** (`https://localhost:7198/swagger`) para explorar la API.

### Paso 4: Levantar el Frontend
1. Navega a la carpeta `/frontend/Js/Services/` y verifica que las URLs apunten a tu localhost (`https://localhost:7198`).
2. Abre `/frontend/index.html` con la extensión **Live Server**.

---

## 📋 Funcionalidades Cumplidas en la Entrega 1

✅ Catálogo paginado de eventos.

✅ Visualización dinámica de sectores y precios.

✅ Grilla de butacas responsive e interactiva (con estados Disponible, Reservada, Vendida).

✅ Endpoint de reserva "Naive" con registro en tabla de auditoría (`AuditLog`).

✅ Documentación autogenerada vía Swagger / OpenAPI.

✅ Accesibilidad en el Frontend (WAI-ARIA) para lectores de pantalla.


---
*Desarrollado con ❤️ para la cátedra.*
