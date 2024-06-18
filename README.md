# FireDepartmentManagerWebApp

FireDepartmentManagerWebApp is a web application designed to assist fire departments in managing their operations, resources, and personnel effectively.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Personnel Management**: Track and manage fire department personnel details.
- **Resource Allocation**: Allocate and track resources and equipment.
- **Incident Reporting**: Log and manage incident reports.
- **User Authentication**: Secure login and user management.
- **Responsive Design**: Accessible on various devices.

## Installation

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/) (for frontend dependencies)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or another compatible database)

### Steps

1. **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/FireDepartmentManagerWebApp.git
    cd FireDepartmentManagerWebApp
    ```

2. **Install backend dependencies:**
    ```bash
    dotnet restore
    ```

3. **Install frontend dependencies:**
    ```bash
    cd FireDepartmentManagerWebApp/ClientApp
    npm install
    ```

4. **Set up the database:**
    - Update the connection string in `appsettings.json` to point to your database.
    - Run the database migrations:
        ```bash
        dotnet ef database update
        ```

5. **Run the application:**
    ```bash
    dotnet run
    ```

## Usage

- Access the application in your browser at `https://localhost:5001` or `http://localhost:5000`.
- Log in with your credentials or create a new account.
- Navigate through the various sections to manage personnel, resources, and incidents.

## Project Structure

```plaintext
FireDepartmentManagerWebApp/
│
├── FireDepartmentManagerWebApp.sln          # Solution file
├── FireDepartmentManagerWebApp/             # Main project folder
│   ├── Controllers/                         # API Controllers
│   ├── Models/                              # Data models
│   ├── Views/                               # Razor views
│   ├── wwwroot/                             # Static files
│   ├── appsettings.json                     # Application configuration
│   └── Program.cs                           # Application entry point
│
├── FireDepartmentManagerWebApp.Tests/       # Unit tests
│
└── ClientApp/                               # Frontend application (React/Angular)
    ├── src/
    ├── public/
    ├── package.json
    └── webpack.config.js
```

## Contributing

Contributions are welcome! Please read the [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
