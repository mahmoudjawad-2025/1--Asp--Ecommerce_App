# 🛒 E-Commerce API — ASP.NET Core (Clean Architecture)

A clean, scalable 3-layer architecture (DAL → BLL → PL) built for modern e-commerce applications, featuring generic CRUD, JWT authentication, cart & order management, and product/media handling.

---


## 📌 Table of Contents
- [🚀 Overview](#-overview)
- [📐 Architecture](#-architecture)
- [📁 Project-Structure](#-project-structure)
- [🔑 Authentication Flow](#-authentication-flow)
- [🧩 Key Features](#-key-features)
- [🛠 Technologies](#-technologies)
- [📦 How to Run](#-how-to-run)
- [🗂 Services](#-services)
- [📘 API Documentation](#-api-documentation)
- [📞 Contact](#-contact)


---


## 🚀 Overview

The **E-Commerce API** provides a solid backend foundation for any online shopping platform.
It includes:

- Product, category & brand management
- Cart & order system
- Secure JWT authentication
- Generic repository & service pattern
- Media upload for product images
- reviews, user profiles



---




## 📐 Architecture


### **1️⃣ DAL — Data Access Layer**
- EF Core models
- DTOs
- DbContext  
- Generic & specific repositories
- Query filters & includes 


### **2️⃣ BLL — Business Logic Layer**
- AuthenticationService  
- GenericService  
- FileService  
- UserProgressService  
- CartService
- ProductService
- OrderService



### **3️⃣ PL — Presentation Layer**
- Controllers  
- Routing  
- Response models  

---

## 📁 Project Structure

```plaintext

├── BLL
│   ├── Services
│   │   ├── AuthenticationService.cs
│   │   ├── GenericService.cs
│   │   ├── UserProgressService.cs
│   │   └── FileService.cs
│   ├── DTOs
│
├── PL
│   └── Controllers
│
├── Program.cs
└── appsettings.json

ECommerce.API
│
├── DAL
│   ├── Entities
│   ├── DTOs
│   ├── Repositories
│   └── ApplicationDbContext.cs
│
├── BLL
│   ├── Services
│   │   ├── AuthenticationService.cs
│   │   ├── ProductService.cs
│   │   ├── CartService.cs
│   │   ├── OrderService.cs
│   │   ├── GenericService.cs
│   │   └── FileService.cs
│
├── PL
│   └── Controllers
│
├── Program.cs
└── appsettings.json
```



## 🔑 Authentication Flow

Login → access token + refresh token
Refresh token stored in DB
Revoked tokens stored in-memory
Token validation handled by middleware
Supports roles: SuperAdmin / Admin / Customer


🧩 Key Features

✨ Secure JWT authentication
✨ Products, categories, brands CRUD
✨ Shopping cart system
✨ Place & track orders
✨ product reviews
✨ Upload files
✨ Generic CRUD for entities
✨ Clean, scalable 3-layer architecture



## 🛠 Technologies

ASP.NET Core 9
Entity Framework Core
MS SQL Server
AutoMapper
Dependency Injection
Swagger (OpenAPI)



## 📦 How to Run
1️⃣ Update Connection String
"ConnectionStrings": {
  "DefaultConnection": "your-connection"
}

2️⃣ Apply migrations
update-database

3️⃣ Run the API
dotnet run

4️⃣ Open Swagger
https://localhost:{port}/swagger/index.html




## 🗂 Core Services
AuthenticationService	Login, register, refresh tokens
ProductService	Products, categories, brands
CartService	Add/remove items, user carts
OrderService	Checkout, orders, payments (logic level)
FileService	Upload product images
GenericService	Shared CRUD operations


## 📘 API Documentation
[To see the api document of this project click here](./docs/Api_Document.md)



## 📞 Contact

📧 mahmoudjawad02025@gmail.com

🔗 GitHub: [mahmoudjawad-2025](https://github.com/mahmoudjawad-2025/)
