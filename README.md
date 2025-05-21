# 📚 Digital Library Management System

A modular digital book management system built in **C#**, demonstrating **7+ classic design patterns** from the GoF catalog.  
The system supports borrowing and returning books, hierarchical categorization, decorated labels, role-based access control, memory-efficient object handling, and colorful book display.

---

## 🧠 Design Patterns Implemented

| Pattern     | Role in the System |
|-------------|--------------------|
| **Adapter** | Converts raw book data to a category-based, color-coded display format. |
| **Bridge** | Decouples color logic (foreground/background) from the display abstraction. |
| **Composite** | Models a tree of categories and subcategories, each holding books. |
| **Decorator** | Adds runtime labels (e.g., `Rare`, `Library Use Only`) without modifying the base book class. |
| **Flyweight** | Reuses shared book instances (by title-author-category) to reduce memory usage. |
| **Proxy** | Manages access to restricted books (e.g., only `Premium` users may borrow rare books). |
| **Facade** | Provides a simplified interface for borrowing, returning, printing, and checking availability. |

---

## ✅ Features

- 🧩 Hierarchical book categorization using Composite pattern
- 🎨 Color-based display via Adapter + Bridge
- 💾 Efficient memory usage with Flyweight
- 🔐 Access control using Proxy pattern (Premium vs Standard users)
- 🏷️ Book enhancements (tags/labels) via Decorator
- 🖥️ Simplified API interface using Facade

---

## 🚀 Getting Started

```bash
git clone https://github.com/yourusername/digital-library-patterns.git
cd digital-library-patterns
# Open the solution (.sln) file with Visual Studio
```

> Requires [.NET SDK](https://dotnet.microsoft.com/download) and Visual Studio 2022+

---

## 💡 Example Use Cases

- Add a "Rare" label to a book using a decorator
- Display a book using either background or foreground color (Bridge)
- Attempt to borrow a restricted book with a standard user (Proxy)
- Load two identical books and verify memory reuse (Flyweight)
- Search and print all books in a subcategory (Composite + Facade)

---

## 🛠 Tech Stack

- **Language:** C#
- **Architecture:** Object-Oriented Programming, SOLID Principles
- **Patterns:** Adapter, Bridge, Composite, Decorator, Flyweight, Proxy, Facade
- **Tools:** .NET Core, Visual Studio, Console App

---

## 👩‍💻 Author

Built with ❤️ by miryamizadka  
For educational and professional demonstration purposes.
