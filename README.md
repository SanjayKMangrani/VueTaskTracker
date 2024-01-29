# Vue Task Tracker

Vue Task Tracker is a simple CRUD (Create, Read, Update, Delete) application built with Vue.js for the frontend and ASP.NET Core for the backend. It allows users to manage their tasks efficiently.

## Features

- View a list of tasks
- Add a new task
- View task details
- Update task details
- Delete a task

## Technologies Used

- **Frontend**: Vue.js
- **Backend**: ASP.NET Core
- **Database**: SQL Server

## Getting Started

### Prerequisites

- Node.js
- Visual Studio Code (or any code editor of your choice)
- SQL Server Management Studio (for database management)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/vue-task-tracker.git
   ```

2. Navigate to the project directory:

   ```bash
   cd vue-task-tracker
   ```

3. Install frontend dependencies:

   ```bash
   cd Tasks-frontend
   npm install
   ```

4. Install backend dependencies:

   Open the `Tasks-backend` folder in Visual Studio and restore packages.

5. Set up the database:

   - Create a new database in SQL Server Management Studio.
   - Update the connection string in `Tasks-backend/appsettings.json` with your database details.

6. Run the application:

   - Run the backend API using Visual Studio.
   - Run the frontend:

     ```bash
     cd Tasks-frontend
     npm run serve
     ```

7. Access the application:

   Open your browser and visit [http://localhost:8080](http://localhost:8080).

## Usage

- Navigate to the task list to view, add, update, or delete tasks.
- Click on a task to view its details and make changes.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature/bugfix: `git checkout -b feature-name`
3. Commit your changes: `git commit -am 'Add new feature'`
4. Push to the branch: `git push origin feature-name`
5. Submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

---

Feel free to modify the sections based on your project details and preferences.
