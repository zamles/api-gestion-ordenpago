# 💳 API Gestión de Órdenes de Pago

> Sistema backend para la creación, validación y gestión de órdenes de pago institucionales. Desarrollado con ASP.NET Core y SQL Server, con enfoque en integridad de datos, trazabilidad y escalabilidad.

![Estado](https://img.shields.io/badge/estado-finalizada-green)
![Licencia](https://img.shields.io/badge/licencia-MIT-green)
![C#](https://img.shields.io/badge/C%23-9.0-239120?logo=csharp)
![ASP.NET](https://img.shields.io/badge/ASP.NET%20Core-6.0-512BD4?logo=dotnet)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2014+-CC2927?logo=microsoftsqlserver)

---

## 🎯 Descripción del Proyecto

Esta API REST permite gestionar el ciclo completo de las **órdenes de pago** en entornos institucionales, desde su creación hasta su aprobación y registro contable.

### Problema que resuelve
- Centraliza la gestión de pagos en un sistema único y auditable
- Valida reglas de negocio antes de generar órdenes de pago
- Reduce errores manuales mediante validaciones automáticas
- Facilita la integración con sistemas contables y de tesorería

### Valor para el negocio
- ✅ Trazabilidad completa de cada transacción
- ✅ Validación de presupuestos y límites de gasto
- ✅ Generación de reportes para auditoría
- ✅ Integración con flujos de aprobación jerárquicos

---

## 🏗️ Arquitectura del Sistema

```mermaid
graph LR
    Client[Cliente Web/Móvil] --> API[API ASP.NET Core]
    API --> Auth[Autenticación JWT]
    API --> Validation[Validación de Reglas de Negocio]
    Validation --> DB[(SQL Server)]
    API --> Logs[Registro de Auditoría]    
    
    style API fill:#512BD4,color:white
    style DB fill:#CC2927,color:white
