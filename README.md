# Digital Wallet & Rewards System

A microservices-based Digital Wallet and Loyalty/Rewards platform built as a final evaluation project.

## Tech Stack

- **Backend:** .NET 8 Web API (Microservices)
- **Frontend:** Angular
- **Database:** SQL Server (EF Core DB First)
- **Auth:** JWT Bearer Tokens
- **Messaging:** RabbitMQ
- **Gateway:** Ocelot API Gateway

## Services & Ports

| Service             | Port  |
|---------------------|-------|
| API Gateway         | 5001  |
| AuthService         | 5003  |
| UserService         | 5005  |
| WalletService       | 5007  |
| RewardsService      | 5009  |
| NotificationService | 5011  |
| AdminService        | 5013  |
| Angular Frontend    | 4200  |

## Architecture
```
Angular (4200)
     │
     ▼
API Gateway (5001)
     │
     ├── /gateway/auth/*         → AuthService (5003)
     ├── /gateway/user/*         → UserService (5005)
     ├── /gateway/wallet/*       → WalletService (5007)
     ├── /gateway/rewards/*      → RewardsService (5009)
     ├── /gateway/notification/* → NotificationService (5011)
     └── /gateway/admin/*        → AdminService (5013)
```

## Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server (SSMS)
- RabbitMQ
- Node.js (for Angular)

### Run the Project
1. Create all databases in SSMS (AuthDB, UserDB, WalletDB, RewardsDB, NotificationDB, AdminDB)
2. Update connection strings in each service's `appsettings.json`
3. Set multiple startup projects in Visual Studio
4. Press F5 — all services start together

### API Documentation
Each service exposes Swagger UI at `/swagger`

| Service      | Swagger URL                      |
|--------------|----------------------------------|
| AuthService  | https://localhost:5003/swagger   |
| UserService  | https://localhost:5005/swagger   |
| WalletService| https://localhost:5007/swagger   |

## Project Status

| Day | Status | What was built |
|-----|--------|----------------|
| Day 1 | ✅ Done | AuthService, API Gateway, JWT, Swagger |
| Day 2 | ⏳ | UserService, WalletService |
| Day 3 | ⏳ | RewardsService, RabbitMQ events |
| Day 4 | ⏳ | AdminService, Angular UI |
| Day 5 | ⏳ | Integration, polish, viva prep |