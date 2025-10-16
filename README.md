# MudBlazerCRUD

A simple CRUD application built with **MudBlazor**, **.NET 5**, C#, **Entity Framework Core**, and **SQL Server**.  
This project demonstrates how to manage customer information with a modern Blazor UI and robust backend.

---

## Tech Stack

- **Frontend:** Blazor (Razor Components), [MudBlazor](https://mudblazor.com/) (Material Design UI)
- **Backend:** ASP.NET Core (.NET 5)
- **Database:** SQL Server (local or remote)
- **ORM:** Entity Framework Core

---

## Features

- Add, edit, and delete customer records
- Search and sort customers in a responsive MudBlazor table
- Form validation for required fields and phone number format (numeric, 10 digits)
- Snackbar notifications for user actions
- Modern UI with MudBlazor components
- Fixed footer with author credit and dynamic year

---

## Project Structure

- `Pages/CustomerInfo.razor` – Main UI for customer CRUD operations
- `Data/Customer.cs` – Customer entity model with validation attributes
- `Data/CustomerService.cs` – Service for database operations (CRUD)
- `appsettings.json` – Connection string and configuration
- `Shared/MainLayout.razor` – Layout with sidebar navigation and footer

---

## Workflow

1. **Startup:**  
   - The app connects to SQL Server using the connection string in `appsettings.json`.
   - Entity Framework Core manages database migrations and CRUD operations.

2. **Customer Management:**  
   - The main page (`/customer`) displays a form and a table of customers.
   - Users can add new customers, edit existing ones, or delete records.
   - The form validates all fields as required; phone number must be numeric and exactly 10 digits.

3. **UI/UX:**  
   - MudBlazor components provide a responsive, material design interface.
   - Snackbar notifications inform users of successful actions.
   - The footer displays author credit, a heart icon, copyright, and the current year.

---

## Getting Started

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- SQL Server (Express or full)
- Visual Studio 2022 or later

### Setup

1. **Clone the repository:**

2. **Configure the database:**
- Update the `DefaultConnection` string in `appsettings.json` if needed.

3. **Apply migrations:**

4. **Run the application:**

Or use Visual Studio to start debugging.

## Screenshots

> Add screenshots of the UI here for better visualization.


## Author

Made with &#10084;&#65039; by Subrata Debnath &copy; [@DateTime.Now.Year]



