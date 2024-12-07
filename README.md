SchoolProject 📚🎓
Descripción:
Este proyecto es un sistema de gestión para una escuela, diseñado para administrar estudiantes, profesores, cursos y otros aspectos relacionados con la gestión educativa. La aplicación permite la creación, edición y eliminación de estudiantes, la asignación de profesores a cursos y la gestión de la información académica.

Tecnologías utilizadas:

Frontend: HTML, CSS, Bootstrap 💻
Backend: C# con ASP.NET Core 🖥️
Base de Datos: SQL Server 🗄️
Características:

👩‍🏫 Gestión de estudiantes y profesores.
📚 Creación y administración de cursos.
🧑‍🎓 Asignación de estudiantes a cursos.
📊 Visualización de los detalles de cada curso, estudiante y profesor.
🎨 Interfaz de usuario intuitiva y fácil de usar.
🚀 Instalación
Clona este repositorio en tu máquina local:

bash
Copiar código
git clone https://github.com/DOOM-EXE/SchoolProject.git
Navega al directorio del proyecto:

bash
Copiar código
cd SchoolProject
Abre el proyecto en Visual Studio o tu editor de C# preferido.

Asegúrate de tener SQL Server configurado en tu entorno y ajusta la cadena de conexión en el archivo appsettings.json:

json
Copiar código
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=SchoolDB;Trusted_Connection=True;"
}
Restaura los paquetes NuGet necesarios:

bash
Copiar código
dotnet restore
Ejecuta la aplicación:

bash
Copiar código
dotnet run
💡 Uso
Al ejecutar la aplicación, podrás acceder a la interfaz de usuario en tu navegador 🌐.
Podrás gestionar la información de estudiantes, cursos y profesores 📋, y ver los detalles completos de cada entidad 📑.
