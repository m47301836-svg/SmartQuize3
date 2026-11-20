# SmartQuiz - Interactive Console Application

## About The Project
SmartQuiz is a console-based interactive quiz application built entirely from scratch using **C# and .NET**. 
This project was created to practice and master **Object-Oriented Programming (OOP)** principles, clean software architecture, dynamic data handling, and advanced data querying with **LINQ**.

## Architecture
The solution is divided into three separate layers to ensure separation of concerns and maintainability:
*   **`SmartQuiz.Models` (Class Library):** Contains the core data structures, including abstract classes and inheritance (e.g., `Question`, `User`).
*   **`SmartQuiz.Services` (Class Library):** Contains the business logic, such as quiz management, user inputs, scoring, and dynamic data sorting (e.g., `QuizManager`).
*   **`SmartQuiz.ConsoleApp` (Console Application):** The entry point and user interface.

## Key Features & Concepts Applied
*   **OOP:** Mastery of Inheritance, Polymorphism (`virtual`, `override`), and Abstraction (`abstract`).
*   **Data Structures:** Utilization of `List<T>` for dynamic collections.
*   **File I/O (Version 2.0):** Implemented dynamic loading of questions from an external `questions.txt` file. The app parses the text using delimiters.
*   **LINQ (Version 3.0):** Integrated Language Integrated Query (LINQ) to dynamically sort questions. Using `OrderByDescending` and Lambda expressions, the hardest questions (highest scores) are presented first.
*   **Error Handling:** Robust implementation of `try-catch` blocks to handle invalid inputs and missing files.

## Data Format
The questions are loaded from `questions.txt` using the following format:
`Type|Question Text|Score|Correct Answer|Options (comma separated)`
*Example:*
`MC|What is the capital of Iran?|10|Tehran|Shiraz,Tehran,Mashhad`

## Built With
*   C#
*   .NET 8.0

## How to Run
1. Clone the repository.
2. Open `SmartQuiz.sln` in Visual Studio.
3. Ensure `questions.txt` is in the same directory as the executable.
4. Build and run the `SmartQuiz.ConsoleApp` project.

## Future Roadmap (Coming Soon)
- [ ] Migrating from TXT to JSON for better data structure management.
- [ ] Saving user scores and high scores to a file/database.
- [ ] Connecting to a SQL Database using Entity Framework Core.
- [ ] Building a Web API using ASP.NET Core.
- [ ] Creating a graphical user interface (UI).

## Author
**Mohammad** - 15-year-old aspiring Software Engineer
