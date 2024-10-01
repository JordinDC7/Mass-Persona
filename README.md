### README: MassPersona Full Stack Developer Coding Assessment

---

### Overview

Welcome to the **MassPersona Full Stack Developer Coding Assessment** project. This application allows users to review and keep track of different forms of media, such as movies, books, and games. It demonstrates proficiency in C#, .NET, Razor Pages, PostgreSQL, and basic web development skills.

---

### Table of Contents
1. [Prerequisites](#prerequisites)
2. [Set Up PostgreSQL](#set-up-postgresql)
3. [Running SQL Scripts](#running-sql-scripts)
4. [Cloning the Repository](#cloning-the-repository)
5. [Application Architecture](#application-architecture)
6. [Running the Application](#running-the-application)
7. [Assumptions & Design Decisions](#assumptions-design-decisions)
8. [Why I Chose the Media](#why-i-chose-the-media)

---

### Prerequisites

Before running this application, ensure you have the following installed:

- **PostgreSQL**: [Download PostgreSQL](https://www.postgresql.org/download/) and follow installation instructions for your operating system.
- **Visual Studio**: For working with the .NET project and running the Razor Pages.
- **Git**: To clone the repository.

---

### Set Up PostgreSQL

1. **Download and Install PostgreSQL**:
   - [PostgreSQL Download](https://www.postgresql.org/download/).
   - Follow the instructions for your operating system to install.

2. **Starting pgAdmin**:
   - Search for **pgAdmin** on your computer and run it.
   - Right-click on "Databases" in the pgAdmin interface and select **Create > Databases**. Name your database `masspersona_reviews`.

---

### Running SQL Scripts

1. **Connect to the Database**:
   - In the left panel of pgAdmin, under **Databases**, right-click on the created database `masspersona_reviews` and choose **Query Tool**. This will open a query window connected to the database.

2. **Run the SQL Script**:
   - Navigate to the folder containing the SQL script (`masspersona_reviews SQL scripts`).
   - Open the script with a text editor (e.g., Notepad) and copy the contents.
   - Paste the SQL script into the pgAdmin query window and execute it to create the necessary tables and insert test data.

---

### Cloning the Repository

1. **Clone the Repository**:
   Open a terminal or command prompt and run the following command to clone the project:
   ```bash
   git clone https://github.com/JordinDC7/Mass-Persona.git
   ```

2. **Open the Project**:
   - Navigate to the cloned directory and open the solution file (`.sln`) in Visual Studio.

---

### Application Architecture

The application follows a **MVC-like architecture** using **Razor Pages** within ASP.NET Core. Key components of the architecture include:

- **C#/.NET 8**: Backend logic and Razor Pages.
- **Entity Framework Core (EFC)**: ORM to interact with the PostgreSQL database.
- **PostgreSQL**: Used to store the media reviews.
- **Razor Pages**: Used for UI rendering and binding of data from the server-side to the front-end.

#### Key Pages:
- **Home Page**: A simple landing page with navigation to the review section.
- **Review Pages**:
  - **Create Review**: Form to create new media reviews.
  - **Edit Review**: Form to edit existing reviews.
  - **Delete Review**: Page for confirming and deleting reviews.
  - **View Reviews**: Displays a list of all reviews with filtering, sorting, and pagination functionality.

---

### Running the Application

1. **Start the Application**:
   - Once the project is open in Visual Studio, press `F5` or click the **Run** button to start the application.
   - The application will launch in your default web browser.

2. **Interacting with the Application**:
   - Use the **Create New Review** button to add new media reviews.
   - Navigate to **Reviews** to view, edit, delete, filter, or sort existing reviews.

---

### Assumptions & Design Decisions

- **Assumptions**: The categories for the media (e.g., Movie, Book, Game) were predefined. Ratings are restricted to integers between 1 and 5. Future iterations can dynamically pull categories from the database.
- **Design Decisions**: 
   - Utilized Razor Pages for a simplified approach to build the UI and handle server-side logic.
   - Entity Framework Core was chosen to handle database interactions, making it easy to map C# classes to the PostgreSQL database.
   - The use of Bootstrap ensures the application is responsive and visually clean.
   - I decided to go with dropdowns for some of the data/inputs that should ideally have fixed values
   - I made some extra functionality to sort even further handling if no sort is picked we go by date and gave the user some additional options

---

### Why I Chose the Media

For the reviews, I selected various forms of media that are personally significant and impactful. This includes popular books, movies, and games that have had a notable influence on both mainstream culture and my personal interests.

---

This README should give you all the necessary instructions to set up, run, and understand the application. Let me know if you encounter any issues or need additional information.
