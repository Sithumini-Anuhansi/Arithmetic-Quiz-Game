# Arithmetic Quiz Game 🧠✨

A lightweight Windows Forms desktop application built in C# designed to test and improve basic arithmetic skills through randomized math challenges.

## Test Your Arithmetic Knowledge

A Windows Forms desktop game that quizzes the player on arithmetic — addition, subtraction, multiplication, and division — with three selectable difficulty levels.

## Features

- Four randomly generated problems each round: one addition, one subtraction, one multiplication, one division
- Three difficulty levels (numbers from 1–10, 10–100, or 100–1000)
- Instant answer checking with inline error hints showing the correct answer when you're wrong
- Live score display (out of 4)
- Restart button to generate a fresh set of problems

## Tech Stack

- **Language:** C#
- **Framework:** .NET Framework 4.7.2 (Windows Forms)
- **IDE:** Visual Studio 2022

## Project Structure

```
TestYourArithmeticKnowledge/
├── TestYourArithmeticKnowledge.sln      # Visual Studio solution file
└── TestYourArithmeticKnowledge/
    ├── TestYourArithmeticKnowledge.csproj
    ├── Program.cs                       # Application entry point
    ├── Form1.cs                         # Game logic (problem generation, scoring)
    ├── Form1.Designer.cs                # Auto-generated UI layout code
    ├── Form1.resx                       # Form resources
    ├── App.config                       # Runtime configuration
    └── Properties/                      # Assembly info, resources, settings
```

## Getting Started

### Prerequisites

- Windows (Windows Forms apps run on Windows)
- Visual Studio 2022 with the **.NET desktop development** workload
- .NET Framework 4.7.2 Developer Pack (Visual Studio will prompt to install it if missing)

### Run it

1. Open `TestYourArithmeticKnowledge.sln` in Visual Studio
2. Press `F5` to build and run

> This is a .NET Framework (not .NET / .NET Core) project, so it's built and run through Visual Studio rather than the `dotnet` CLI.

## How It Works

On start (and on restart), `GenerateGame()` picks a number range based on the selected difficulty and generates eight random numbers, computing the correct answers for addition, subtraction, multiplication, and division (the division pair is generated to divide evenly). The player enters their four answers and clicks **Check**; each answer is validated with `int.TryParse`, wrong answers get an inline error hint showing the correct value via `ErrorProvider`, and the score is tallied out of 4.

## License

This project is licensed under the **MIT License** - see the LICENSE file for details.

---

<div align="right">
<img src="https://visitor-badge.laobi.icu/badge?page_id=Sithumini-Anuhansi.student-pass-fail-ml&left_text=Views"/>
</div>
