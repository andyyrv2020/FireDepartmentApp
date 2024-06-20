# Contributing to FireDepartmentManagerWebApp

Thank you for considering contributing to FireDepartmentManagerWebApp! We welcome contributions from the community to help improve and extend the functionality of this project.

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [How Can I Contribute?](#how-can-i-contribute)
  - [Reporting Bugs](#reporting-bugs)
  - [Suggesting Features](#suggesting-features)
  - [Submitting Pull Requests](#submitting-pull-requests)
- [Development Setup](#development-setup)
- [Style Guides](#style-guides)
  - [Git Commit Messages](#git-commit-messages)
  - [C# Style Guide](#c-style-guide)
  - [JavaScript Style Guide](#javascript-style-guide)
- [Community](#community)

## Code of Conduct

This project and everyone participating in it are governed by the [Code of Conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to [andyrashev123@icloud.com](mailto:andyrashev123@icloud.com).

## How Can I Contribute?

### Reporting Bugs

If you find a bug in the project, please report it by opening an issue on GitHub. Include the following information:

- A clear and descriptive title.
- A detailed description of the problem.
- Steps to reproduce the issue.
- Any relevant screenshots or logs.

### Suggesting Features

If you have a feature request, please open an issue on GitHub. Provide as much detail as possible, including:

- A clear and descriptive title.
- A detailed description of the proposed feature.
- Any relevant use cases or examples.

### Submitting Pull Requests

If you'd like to contribute code to the project, follow these steps:

1. **Fork the repository** to your own GitHub account.
2. **Clone the repository** to your local machine:
    ```bash
    git clone https://github.com/yourusername/FireDepartmentManagerWebApp.git
    cd FireDepartmentManagerWebApp
    ```
3. **Create a new branch** for your changes:
    ```bash
    git checkout -b feature/your-feature-name
    ```
4. **Make your changes** in the new branch.
5. **Commit your changes** with a clear and descriptive commit message.
6. **Push your changes** to your forked repository:
    ```bash
    git push origin feature/your-feature-name
    ```
7. **Open a pull request** on GitHub. Provide a clear and detailed description of your changes.

## Development Setup

To set up the project for local development:

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/FireDepartmentManagerWebApp.git
    cd FireDepartmentManagerWebApp
    ```
2. **Install backend dependencies**:
    ```bash
    dotnet restore
    ```
3. **Install frontend dependencies**:
    ```bash
    cd ClientApp
    npm install
    cd ..
    ```
4. **Set up the database**:
    - Update the connection string in `appsettings.json`.
    - Run the database migrations:
        ```bash
        dotnet ef database update
        ```
5. **Run the application**:
    ```bash
    dotnet run
    ```

## Style Guides

### Git Commit Messages

- Use the present tense ("Add feature" not "Added feature").
- Use the imperative mood ("Move cursor to..." not "Moves cursor to...").
- Limit the first line to 72 characters or less.
- Reference issues and pull requests liberally.

### C# Style Guide

- Follow the conventions outlined in the [Microsoft C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).
- Use meaningful variable and method names.
- Include XML documentation comments for public methods and classes.

### JavaScript Style Guide

- Follow the conventions outlined in the [Airbnb JavaScript Style Guide](https://github.com/airbnb/javascript).
- Use `const` and `let` instead of `var`.
- Prefer arrow functions for anonymous functions.
- Include JSDoc comments for functions and classes.

