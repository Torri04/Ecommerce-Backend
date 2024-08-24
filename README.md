# ECommerce Backend .NET Core API

This project is .NET Core API for an e-commerce platform. It provides endpoints for managing products, orders, shopping carts, wish lists, and more. The API integrates with Azure services for storage, queuing, and messaging, and uses JWT for authentication. 

## Table of Contents
- [Prerequisites](#prerequisites)
- [Setup](#setup)
- [Configuration](#configuration)
- [Running the Function](#running-the-function)
- [Deploying to Azure](#deploying-to-azure)

## Features

- **Authentication**: Secure access using JWT tokens.
- **Authorization**: Role-based access control for users and admins.
- **Azure Integration**:
  - **Azure Blob Storage**: For storing and managing images.
  - **Azure Queue Storage**: For handling background tasks and messaging.
  - **[Azure Function](https://github.com/Torri04/Azure-Function/edit/master/README.md)**: For serverless operations. 
  - **Azure Container Instances**: For deploying containers.
- **Database**: SQL Server, with Docker support for local development and deployment.

## Prerequisites

Before running the project, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop)
- [Azure Account](https://azure.microsoft.com/en-us/free/)


## Setup

1. **Clone the repository**:
    ```bash
    git clone https://github.com/Torri04/Azure-Function.git
    ```

2. **Restore the dependencies**:
    ```bash
    dotnet restore
    ```

3. **Build the project**:
    ```bash
    dotnet build
    ```
   
### **Docker**

Change to the Docker directory where your Docker configuration files are located:

```bash
cd Docker
```

Run docker Compose

```bash
docker-compose up -d
```

### **Configuration**
   
Create a appsettings.json file in the root of the project with the following content:

```json
{
  "ConnectionStrings": {
  "MyDatabase": "<Your-Database-ConnectionString>"
  },
  "JWT": {
    "Issuer": "<Your-WebIssuer>",
    "Audience": "<Your-WebAudience>",
    "SigningKey": "<Your-WebSigningKey>"
  },
  "MailSettings": {
    "Mail": "<Your-Email>",
    "DisplayName": "<Email-DisplayName>",
    "Password": "<Your-AppPassword>",
    "Host": "smtp.gmail.com",
    "Port": 587
  },
  "AzureStorage": {
    "ConnectionStrings": "<Your-Azure-ConnectionString>"
  }
}
```



 
