README.md (Español / English)
# jaofdevEnfudeAPI

🌱 API modular para trazabilidad agrícola, diseñada por [jaofdev](https://github.com/jaofdev)  
Modular agricultural traceability API, designed by [jaofdev](https://github.com/jaofdev)

---

## 📌 Descripción / Description

**ES:**  
Esta API permite gestionar procesos de trazabilidad en cultivos agrícolas, con enfoque en modularidad, seguridad y escalabilidad.  
**EN:**  
This API manages agricultural traceability workflows, focusing on modularity, security, and scalability.

---

## 📁 Estructura del proyecto / Project Structure


jaofdevEnfudeAPI/ ├── EnfudeAPI/               # API principal / Main API ├── EnfundeAPI.Tests/       # Pruebas automatizadas / Automated tests ├── .github/workflows/      # Flujo CI/CD con GitHub Actions └── README.md               # Documentación principal

---

## ⚙️ Tecnologías / Technologies

- ASP.NET Core 8
- Entity Framework Core
- xUnit
- SonarCloud
- GitHub Actions

---

## 🚀 Instalación / Installation

```bash
git clone https://github.com/jaofdev/jaofdevEnfudeAPI.git
cd jaofdevEnfudeAPI
dotnet restore
dotnet build



🧪 Pruebas / Testing
dotnet test EnfundeAPI.Tests/EnfundeAPI.Tests.csproj



🔍 Análisis de calidad / Quality Analysis
.\analizar-sonar.ps1


Requiere token de SonarCloud configurado como variable de entorno SONAR_TOKEN.


🛡️ Badges
 

👥 Créditos / Credits
Desarrollado por JaofDev.
Diseñado para entornos académicos, agrícolas y técnicos con enfoque bilingüe y modular.

📄 Licencia / License
MIT License. Puedes usar, modificar y distribuir libremente con atribución.


