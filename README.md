# Arquitectura de Software - Actividad #14 - Práctica .NET: Implementar MVC con ASP.NET Core

## Información del Estudiante

* **Nombre:** Patricio Medina Batún
* **Grupo:** 1B
* **Cuatrimestre:** 2do Cuatrimestre
* **Carrera:** Ingeniería en Desarrollo de Software y Negocios Digitales
* **Universidad:** Tecnológico de Software
* **Profesor:** Jorge Javier Pedrozo Romero

---

## Sistema de Gestión de Citas Médicas

Este proyecto es una aplicación web MVC desarrollada en .NET que permite administrar información relacionada con pacientes, médicos y citas médicas.

El sistema facilita el registro y visualización de pacientes, médicos y citas, organizando la información mediante el patrón de arquitectura Modelo-Vista-Controlador (MVC). Esto permite mantener una estructura ordenada, escalable y fácil de mantener.

## Características

* Registro y gestión de pacientes.
* Registro y gestión de médicos.
* Administración de citas médicas.
* Organización mediante arquitectura MVC.
* Interfaz web desarrollada con Razor Views.
* Separación clara entre modelos, vistas y controladores.
* Código estructurado para futuras ampliaciones.

## Cómo funciona el sistema

1.  **Inicio de la aplicación:** El usuario accede al sistema desde el navegador.
2.  **Gestión de pacientes:** Se pueden visualizar y administrar los datos de los pacientes.
3.  **Gestión de médicos:** Se registran y consultan médicos con su especialidad y número de licencia.
4.  **Gestión de citas:** Se programan citas asociando pacientes y médicos.
5.  **Controladores MVC:** Procesan las solicitudes y retornan las vistas correspondientes.
6.  **Modelos:** Representan las entidades principales del sistema.
7.  **Vistas:** Presentan la información de manera visual e interactiva.

## Estructura del proyecto

    CitasApp/
    ├── Areas/
    │   └── Identity/
    │
    ├── Controllers/
    │   ├── HomeController.cs
    │   ├── PacienteController.cs
    │   ├── MedicoController.cs
    │   └── CitaController.cs
    │
    ├── Data/
    │   ├── ApplicationDbContext.cs
    │   ├── Pacientes.json
    │   ├── Medico.json
    │   └── Cita.json
    │
    ├── Migrations/
    │
    ├── Models/
    │   ├── Paciente.cs
    │   ├── Medico.cs
    │   ├── Cita.cs
    │   ├── EstadoCita.cs
    │   └── ErrorViewModel.cs
    │
    ├── Properties/
    │
    ├── Views/
    │   ├── Cita/
    │   │   ├── Crear.cshtml
    │   │   ├── Index.cshtml
    │   │   └── PorPaciente.cshtml
    │   │
    │   ├── Home/
    │   │   ├── Index.cshtml
    │   │   └── Privacy.cshtml
    │   │
    │   ├── Medico/
    │   │   ├── Crear.cshtml
    │   │   ├── Detalle.cshtml
    │   │   └── Index.cshtml
    │   │
    │   ├── Paciente/
    │   │   ├── Crear.cshtml
    │   │   ├── Detalle.cshtml
    │   │   └── Index.cshtml
    │   │
    │   └── Shared/
    │       ├── _Layout.cshtml
    │       ├── _LoginPartial.cshtml
    │       ├── _ValidationScriptsPartial.cshtml
    │       └── Error.cshtml
    │
    ├── wwwroot/
    │   ├── css/
    │   ├── js/
    │   └── lib/
    │
    ├── Program.cs
    ├── appsettings.json
    ├── appsettings.Development.json
    ├── CitasApp.csproj
    ├── CitasApp.slnx
    ├── README.md
    ├── .gitignore
    └── .gitattributes


## Imagenes
## Capturas de Pantalla

**Inicio**
<img width="1911" height="903" alt="image" src="https://github.com/user-attachments/assets/826548a1-99f3-443d-afcd-e69e1b0f9187" />

**Citas**
<img width="1892" height="839" alt="image" src="https://github.com/user-attachments/assets/cbf35e7e-c92a-46b2-a96b-57dfbc36b641" />

**Médicos**
<img width="1898" height="881" alt="image" src="https://github.com/user-attachments/assets/03b1550d-e0be-478c-9bd3-a706c8c2e27a" />

**Pacientes**
<img width="1905" height="911" alt="image" src="https://github.com/user-attachments/assets/791510cf-e84a-4bc2-bf78-d31e9f3f163a" />

## Modelos principales

### Paciente
Contiene información básica de los pacientes:
* `Id`
* `Nombre`
* `Apellido`
* `Email`
* `Telefono`

### Médico
Contiene información profesional de los médicos:
* `Id`
* `Nombre`
* `Apellido`
* `Especialidad`
* `NumeroLicencia`

### Cita
Representa las citas médicas programadas:
* `Id`
* `PacienteId`
* `MedicoId`
* `Fecha` (DateOnly)
* `Hora` (TimeOnly)
* `Motivo`
* `Estado` (Pendiente, Confirmada, Cancelada)

## Archivos principales

* **Program.cs** – Configuración principal y arranque de la aplicación.
* **Controllers/** – Controladores encargados de gestionar las solicitudes.
* **Models/** – Entidades principales del sistema.
* **Views/** – Interfaz visual para los usuarios.
* **Data/** – Configuración y acceso a datos.
* **wwwroot/** – Recursos estáticos como CSS, JavaScript e imágenes.
* **appsettings.json** – Configuración general del proyecto.

## Cláusula de Uso de Inteligencia Artificial

Durante el desarrollo de este proyecto se utilizó apoyo de herramientas de Inteligencia Artificial (IA) únicamente como recurso complementario de aprendizaje y consulta.

## Objetivo de la práctica

Aplicar los principios de la arquitectura MVC mediante el desarrollo de una aplicación web capaz de gestionar pacientes, médicos y citas médicas, fortaleciendo el uso de .NET, C# y la organización del código en capas.
