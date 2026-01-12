# 🛒 E-Commerce API — ASP.NET Core (Clean Architecture)

A clean, scalable 3-layer architecture (DAL → BLL → PL) built for modern e-commerce applications, featuring generic CRUD, JWT authentication, cart & order management, and product/media handling.

![.NET](https://img.shields.io/badge/.NET-9.0-blue)
![Build](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-green)

<br>
<hr>
<br>

## 📌 Table of Contents
- [🚀 Overview](#-overview)
- [📐 Architecture](#-architecture)
- [🧩 Key Features](#-key-features)
- [🚀 Tech Stack](#-tech-stack)
- [📁 Project Structure](#-project-structure)
- [🔑 Authentication Flow](#-authentication-flow)
- [📦 API Modules](#-api-modules)
- [❌ Error Handling](#-error-handling)
- [⚙️ Getting Started](#-getting-started)
- [🔐 Environment Variables](#-environment-variables)
- [📘 API Documentation](#-api-documentation)
- [📞 Contact](#-contact)





















<br>
<hr>
<br>






















## 🚀 Overview

The **E-Commerce API** provides a solid backend foundation for any online shopping platform.
It includes:

- Product, category & brand management
- Cart & order system
- Secure JWT authentication
- Generic repository & service pattern
- Media upload for product images
- reviews, user profiles

<br>

🧩 Key Features

* ✨ Secure JWT authentication
* ✨ Products, categories, brands CRUD
* ✨ Shopping cart system
* ✨ Place & track orders
* ✨ product reviews
* ✨ Upload files
* ✨ Generic CRUD for entities
* ✨ Clean, scalable 3-layer architecture

<br>

## 🚀 Tech Stack
* ASP.NET Core 9
* Entity Framework Core
* SQL Server
* JWT Authentication
* Dependency Injection
* Swagger / OpenAPI

<br>

## 📐 Architecture
This project follows a **3-Layer Architecture**:
```
PL  → Controllers / API
BLL → Business Logic & Services
DAL → Data Access (EF Core + Repositories)
```
Each layer is **fully isolated** and communicates via **interfaces only**.

<br>

## 📁 Project Structure
```plaintext
Nibras.API
│
├── DAL
│   ├── Data_Base
│   │   ├── Migrations
│   │   ├── ApplicationDbContext.cs
|   ├── DTO
│   ├── Models
│   ├── Utils
│   └── Repositories
│       ├── Interfaces
│       └── Classes
│
├── BLL
│   └── Services
│       ├── Interfaces
│       └── Classes
│
└── PL
    ├── Areas (Controllers)
    │   ├── Admin
    │   ├── Identity
    |   └── Customer
    ├── Utils
    ├── appsettings.json
    └── Program.cs

```






















<br>
<hr>
<br>





















## 🔑 Authentication Flow

Authentication is implemented using **JWT Bearer Tokens**.

```
Authorization: Bearer <token>
```

Login → JWT access token  
Token validation handled via JWT Bearer middleware  

<br>

## 📦 API Modules

* **Authentication & Identity:** User registration, login, and secure password management.
* **Admin - Product Management:** Inventory control, creation, and stock visibility status.
* **Admin - Category Management:** Organization of product hierarchies and status toggles.
* **Admin - Brand Management:** Partner brand profiles and visibility control.
* **Admin - Order Management:** Fulfillment tracking and order status updates.
* **Admin - Reports:** Sales analytics and user activity data.
* **Customer - Shopping Experience:** Cart management, product browsing, and category viewing.
* **Customer - Checkout:** Payment processing and order success verification.
* **Customer - Reviews:** Product ratings and review submissions.
* **User Management:** Administrative control over user roles and account access (Block/Unblock).

<br>

## ❌ Error Handling

* Centralized exception handling
* Standard HTTP status codes
* Consistent response format

```json
{
  "message": "Validation failed"
}
```




















<br>
<hr>
<br>




















## ⚙️ Getting Started

### Prerequisites
- .NET SDK 9.0
- SQL Server
- Visual Studio 2022+

### Installation
git clone ...
dotnet restore

### Database Setup
update-database

### Run Application
dotnet run

### API Access
https://localhost:{port}/swagger

<br>

## 🔐 Environment Variables

Configure the following in `appsettings.json` or environment variables:

| Key                                   | Description                  |
|--------------------------------------|------------------------------|
| ConnectionStrings:DefaultConnection  | SQL Server connection string |
| jwtOptions:SecretKey                 | JWT signing secret key       |




















<br>
<hr>
<br>



















## 📘 API Documentation
[To see the api document of this project click here](./Docs/Api_Document.md)

<br>

## 📞 Contact

📧 mahmoudjawad02025@gmail.com

🔗 GitHub: [mahmoudjawad-2025](https://github.com/mahmoudjawad-2025/)
