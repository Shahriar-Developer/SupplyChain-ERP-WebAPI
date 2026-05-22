# 🏢 SupplyChain-ERP-WebAPI

<div align="center">
  <img src="https://img.shields.io/badge/.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Core" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Entity_Framework-0078D4?style=for-the-badge&logo=.net&logoColor=white" alt="EF Core" />
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/JWT_Auth-000000?style=for-the-badge&logo=JSON%20web%20tokens&logoColor=white" alt="JWT" />
</div>

## 📖 Project Overview
This repository contains the core **RESTful Web API** for an enterprise-level Supply Chain and ERP system. Built with **ASP.NET Core**, it follows a clean architecture employing the **Repository Pattern** and **DTOs**. It serves as the centralized backend engine for interconnected frontend applications, handling complex procurement lifecycles, advanced warehouse operations, and dynamic master data management.

*(To view the Frontend Applications, check the interconnected repositories in my profile).*

---

## 🚀 Core Modules & Features

### 🔐 1. Security & Identity Management
- **JWT Authentication:** Secure, stateless API communication.
- **Role-Based Authorization (RBAC):** Tiered access limits for Admin, Purchase Manager, Purchase Officer, and Store Manager.
- **Departmental Claims:** Users are strictly mapped to specific departments for localized data access and operations.

### 🔄 2. Complete Procurement Lifecycle
- **Purchase Requisition (PR):** Departmental requests for materials.
- **Request for Quotation (RFQ) & Supplier Quotation:** Automating multi-vendor bidding processes.
- **Comparative Statement (CS):** Automated financial logic to select the most cost-effective supplier bids.
- **Purchase Order (PO):** Finalized system-generated POs linked to approved CS.

### 🏬 3. Advanced Warehouse & Inventory Management
- **Multi-Tier Location Tracking:** Precise inventory mapping via `Warehouse -> Floor -> Zone -> Aisle -> Rack -> Shelf -> Bin`.
- **Goods Receipt Note (GRN) & Quality Check (QC):** Multi-step verification of incoming stock with partial approval/rejection logic.
- **Batch & Expiry Management:** Strict tracking of manufacturing and expiration dates for perishable and non-perishable goods.
- **Stock Movement:** Dynamic stock transfers across internal warehouse locations.

### 📦 4. Store Operations & Distribution
- **Employee Requisitions:** Inter-departmental material requests.
- **Store Issues (FIFO):** Automated inventory deduction based on First-In-First-Out logic to minimize waste.
- **Low Stock Alerts:** Real-time inventory monitoring via dashboard APIs.

### 📊 5. Master Data Management (MDM)
- Dynamic CRUD operations for **Products, Categories, Brands, Suppliers, Currencies, and Unit Sets**.

---

## 🏗️ Technical Architecture
- **Layered Architecture:** Clear separation of concerns (Controllers, Repositories, Entities, DTOs).
- **Data Access:** Entity Framework Core (Code-First approach).
- **Asynchronous Programming:** Fully asynchronous API endpoints to maximize throughput and server scalability.
- **Soft Deletion Mechanism:** Safely retaining historical data for audits without cluttering active database queries.

---

## 📂 Project Folder Structure

![API Folder Structure](Api-Folder-Struct.png)

The project follows a clean and highly decoupled architecture as shown above:
- **Attributes:** Custom authorization & validation logic.
- **Controllers:** API Endpoints for routing and HTTP requests.
- **Data & Migrations:** Entity Framework `AppDbContext` and DB generation files.
- **DTOs:** Data Transfer Objects for Request/Response mapping.
- **Entities & Models:** Domain Models and Database Entities.
- **Repositories:** Data Access Layer (Interfaces & Implementations).

---

## 🛠️ How to Run Locally

### Prerequisites
- .NET 6.0 / 7.0 SDK or higher
- MS SQL Server
- Visual Studio 2022 / VS Code

### Installation Steps
1. Clone the repository:
   ```bash
   git clone [https://github.com/Shahriar-Developer/SupplyChain-ERP-WebAPI.git](https://github.com/Shahriar-Developer/SupplyChain-ERP-WebAPI.git)
