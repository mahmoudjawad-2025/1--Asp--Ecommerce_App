
# 🚀 Backend API

**ASP.NET Core 9 | Clean Architecture | REST API**

![.NET](https://img.shields.io/badge/.NET-9.0-blue)
![Build](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-green)

---

## 📖 Table of Contents

* [Overview](#overview)
* [Architecture](#architecture)
* [Tech Stack](#tech-stack)
* [Getting Started](#getting-started)
* [Environment Variables](#environment-variables)
* [Authentication](#authentication)
* [API Modules](#api-modules)
* [Error Handling](#error-handling)
* [API Documentation](#api-documentation)
* [Deployment](#deployment)
* [Versioning](#versioning)
* [Contributing](#contributing)
* [Support](#support)
* [Contact](#contact)
* [License](#license)

---

## 📌 Overview

This repository contains a **production-ready backend API** built with **ASP.NET Core 9**, following **Clean Architecture**, **SOLID principles**, and industry best practices.

The API is designed to be consumed by:

* Mobile applications
* Web applications
* Third-party services

---

## 🧱 Architecture

This project follows a **3-Layer Architecture**:

```
PL  → Controllers / API
BLL → Business Logic & Services
DAL → Data Access (EF Core + Repositories)
```

Each layer is **fully isolated** and communicates via **interfaces only**.

---

## 🚀 Tech Stack

* ASP.NET Core 9
* Entity Framework Core
* SQL Server
* JWT Authentication
* Dependency Injection
* Swagger / OpenAPI

---

## ⚙️ Getting Started

### Prerequisites

* .NET SDK 9.0
* SQL Server
* Visual Studio 2022+

### Installation

```bash
git clone https://github.com/your-org/project-name.git
cd project-name
dotnet restore
dotnet ef database update
dotnet run
```

---

## 🔐 Environment Variables

Configure the following in `appsettings.json` or environment variables:

| Key                                   | Description         |
| ------------------------------------- | ------------------- |
| `ConnectionStrings:DefaultConnection` | Database connection |
| `Jwt:Key`                             | JWT secret key      |
| `Jwt:Issuer`                          | Token issuer        |
| `Jwt:Audience`                        | Token audience      |
| `Email:SmtpHost`                      | SMTP server         |
| `Email:Username`                      | SMTP user           |
| `Email:Password`                      | SMTP password       |

---

## 🔐 Authentication

Authentication is implemented using **JWT Bearer Tokens**.

```
Authorization: Bearer <token>
```

---

## 📦 API Modules

* Users
* Authentication
* Quran / Content / Lessons *(domain-based)*
* Quizzes
* User Progress

---

## ❌ Error Handling

* Centralized exception handling
* Standard HTTP status codes
* Consistent response format

```json
{
  "message": "Validation failed"
}
```

---

## 📑 API Documentation

Swagger UI:

```
/swagger
```

---

## 🚀 Deployment

Supported deployment options:

* IIS
* Docker
* Azure App Service
* Linux (Kestrel + Nginx)

---

## 🏷 Versioning

This project follows **Semantic Versioning**:

```
vMAJOR.MINOR.PATCH
```

Example:

```
v1.2.0
```

---

## 🤝 Contributing

1. Fork repository
2. Create feature branch
3. Commit changes
4. Open Pull Request

---

## 🆘 Support

If you encounter issues:

* Open a **GitHub Issue**
* Provide logs and steps to reproduce

---

## 📬 Contact

**Project Maintainer:** Mahmoud Jawad
**Email:** [your-email@example.com](mailto:your-email@example.com)
**GitHub:** [https://github.com/mahmoudjawad-2025](https://github.com/mahmoudjawad-2025)

---

## 📄 License

MIT License

