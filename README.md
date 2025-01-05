# User Management API

This project is a User Management API developed for TechHive Solutions. The API allows the HR and IT departments to create, update, retrieve, and delete user records efficiently.

## Project Setup

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio Code](https://code.visualstudio.com/) or any other IDE
- [Postman](https://www.postman.com/) or any other API testing tool

### Getting Started

1. Clone the repository:

   ```sh
   git clone https://github.com/bennajah/UserManagementAPI.git
   cd UserManagementAPI

   ```

2. Build the project:

   ```sh
   dotnet build
   ```

3. Run the project:

   ```sh
   dotnet run
   ```

## API Endpoints

### Create User

- **URL:** `/api/users`
- **Method:** `POST`
- **Description:** Create a new user record.
- **Request Body:**
  ```json
  {
    "firstName": "John",
    "lastName": "Doe",
    "email": "john.doe@example.com"
  }
  ```

### Get Users

- **URL:** `/api/users`
- **Method:** `GET`
- **Description:** Retrieve all user records.

### Get User by ID

- **URL:** `/api/users/{id}`
- **Method:** `GET`
- **Description:** Retrieve a user record by ID.

### Update User

- **URL:** `/api/users/{id}`
- **Method:** `PUT`
- **Description:** Update an existing user record.
- **Request Body:**
  ```json
  {
    "firstName": "John",
    "lastName": "Doe",
    "email": "john.doe@example.com"
  }
  ```

### Delete User

- **URL:** `/api/users/{id}`
- **Method:** `DELETE`
- **Description:** Delete a user record by ID.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request.

## License

This project is licensed under the MIT License.
