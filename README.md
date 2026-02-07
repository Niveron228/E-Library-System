\# 📚 Library Management API



A RESTful Web API built with \*\*ASP.NET Core (.NET 8)\*\* for managing a personal book collection. This project demonstrates the implementation of \*\*CRUD operations\*\*, \*\*advanced search/filtering\*\*, and database integration using \*\*Entity Framework Core\*\*.



---



\## 🚀 Features



\- \*\*CRUD Operations\*\*: Create, Read, Update, and Delete books.

\- \*\*Advanced Search\*\*:

&nbsp; - Find books by \*\*Author\*\*.

&nbsp; - Filter books by \*\*Publication Year\*\*.

&nbsp; - Get specific book details by \*\*Title\*\*.

\- \*\*Persistent Storage\*\*: Uses \*\*SQLite\*\* database via Entity Framework Core.

\- \*\*API Documentation\*\*: Integrated \*\*Swagger UI\*\* for easy testing and exploration.



---



\## 🛠️ Tech Stack



\- \*\*Core\*\*: C#, .NET 8, ASP.NET Core Web API

\- \*\*Database\*\*: SQLite, Entity Framework Core (Code-First approach)

\- \*\*Tools\*\*: Swagger/OpenAPI, Git, Postman

\- \*\*Concepts\*\*: RESTful Architecture, Dependency Injection, LINQ, Async/Await



---



\## 🔌 API Endpoints



\### 📖 Books Management



| Method | Endpoint | Description |

| :--- | :--- | :--- |

| `GET` | `/api/Library` | Get a list of all books |

| `GET` | `/api/Library/{id}` | Get details of a specific book by ID |

| `POST` | `/api/Library` | Add a new book to the library |

| `PUT` | `/api/Library/{id}` | Update an existing book |

| `DELETE` | `/api/Library/{id}` | Remove a book from the library |



\### 🔍 Search \& Filters



| Method | Endpoint | Description |

| :--- | :--- | :--- |

| `GET` | `/api/Library/search/{author}` | Find all books by a specific author |

| `GET` | `/api/Library/year/{year}` | Get all books published in a specific year |

| `GET` | `/api/Library/title/{title}` | Find a specific book by its title |



---



\## ⚙️ Installation \& Setup



To run this project locally, follow these steps:



1\. \*\*Clone the repository:\*\*

&nbsp;  ```bash

&nbsp;  git clone \[https://github.com/YOUR-USERNAME/LibrarySystem.git](https://github.com/YOUR-USERNAME/LibrarySystem.git)

