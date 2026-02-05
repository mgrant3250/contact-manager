# Contact Manager – ASP.NET Core

## Overview
This project is a **Contact Manager web application** built with **ASP.NET Core (C#)** that allows users to **create, read, update, and delete (CRUD)** contacts.

---

## Features
- Create new contacts  
- View a list of contacts  
- Edit existing contact details  
- Delete contacts  
- Server-side validation  
- Persistent data storage  

---

## Tech Stack
- **Language:** C#  
- **Framework:** ASP.NET Core  
- **Architecture:** MVC 
- **ORM:** Entity Framework Core  
- **Database:**  
  - LocalDB (development)  
  - Hosted database for production (Azure SQL) 
- **Tools:** Visual Studio, .NET CLI  

---

## Data Model
Each contact includes:
- First Name  
- Last Name  
- Email  
- Phone Number
- Relationship (e.g., friend, family)

(The model can be easily extended.)

---

## Getting Started (Local Setup)

### Prerequisites
- .NET SDK installed  
- Visual Studio or VS Code  

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   cd your-repo-name
   dotnet restore
   dotnet ef database update
   dotnet run
