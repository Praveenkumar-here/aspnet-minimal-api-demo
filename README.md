# ASP.NET Minimal API Demo

This project is a simple ASP.NET Core minimal API that demonstrates basic API concepts using in-memory data and C#.  
Built as a learning exercise after completing FreeCodeCamp and Microsoft C# certifications.

## ✨ Features

- Stores a list of games in memory using C# objects and lists
- Provides REST API endpoints:
  - `GET /games`: Returns all games as a JSON array
  - `GET /games/{id}`: Returns a single game by ID

## 🛠️ How It Works

- API endpoints defined using the `.MapGet` syntax introduced in minimal APIs
- Data is managed with a `List<Game>` in code (no database required)
- You can test endpoints using `games.http`, Postman, curl, or your browser, preferable VS Code REST extension.

## 📁 Example Endpoints

GET http://localhost:5175/games
GET http://localhost:5175/games/1

# 🚀 How to Run

1. **Clone this repository** **You don't need to clone this repository, this is something my learning scribble**
              git clone https://github.com/Praveenkumar-here/aspnet-minimal-api-demo.git
  
2. **Restore dependencies**
              dotnet restore
 
3. **Run the API**
               dotnet run


4. **Test the endpoints**
- Use a tool like Postman, or
- Use the included `games.http` file with VS Code REST Client extension

## 📚 What I Learned

- How to build a minimal API with ASP.NET using C#
- Basic REST concepts — GET endpoints, route parameters
- Working with collections (`List<Game>`)
- Returning strongly-typed objects as API responses
- Testing APIs using .http files

## 👨‍💻 About Me

I'm an aspiring developer passionate about backend and web technologies.  
Open to learning, feedback, and collaboration!

---

*This project is for educational purposes and as a portfolio sample.  
Feel free to fork, raise issues, or suggest improvements!*

   
