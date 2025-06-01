📚 Library Management System
This is a Library Management System built entirely in C# OOP, without using SQL or any external database. It uses classes and in-memory data structures to store and manage data related to books, members, and transactions.

💡 Features
Book Management: Add, edit, delete, and view books.

Member Management: Register, edit, delete, and view members.

Issue/Return Books: Simulate book issue and return using classes.

Search and Filter: Search for books and members by ID or name.

Reports: Basic console reports of available and issued books.

🛠️ Technologies Used
C# (OOP): Core logic using classes and objects.

No Database: All data is stored in memory (e.g. List<T> or similar structures).

Console Application: Simple text-based interface.

📦 Project Structure
pgsql
Copy
Edit
/LibraryManagement
│
├── Program.cs           // Entry point
├── Book.cs              // Book class with properties like Id, Title, Author, etc.
├── Member.cs            // Member class with properties like Id, Name, Email, etc.
├── Transaction.cs       // Class to handle issuing and returning books
└── Library.cs           // Class managing the core logic (e.g. lists of books/members)
🚀 How to Run
Clone or download the repository.

Open the solution (.sln file) in Visual Studio (or any C# IDE).

Build and run the project (F5).

📖 Usage
Follow the console prompts to:

Add new books and members.

View available books and registered members.

Issue and return books.

Generate simple reports.
