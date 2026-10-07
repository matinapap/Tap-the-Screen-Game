# 🐸 Tap the Screen: Frog Game

[![CI](https://github.com/matinapap/Tap-the-Screen-Game/actions/workflows/ci.yml/badge.svg)](https://github.com/matinapap/Tap-the-Screen-Game/actions/workflows/ci.yml)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![.NET Framework 4.7.2](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=dotnet&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-003B57?logo=sqlite&logoColor=white)

A fast-paced Windows desktop arcade game built with **C# and Windows Forms**. Chase a bouncing frog around the pond with your magic wand, grab bonus coins and post your best score to a local **SQLite** leaderboard.

It started as a university assignment for *Object-Oriented Application Development* and was later refactored into a layered, tested codebase.

<!--
  Add gameplay screenshots to docs/screenshots/ and uncomment:
  <p align="center">
    <img src="docs/screenshots/gameplay.png" width="600" alt="Gameplay">
  </p>
-->

## Gameplay

You have **2 minutes** to score as many points as you can.

| Target | Points | Notes |
| --- | --- | --- |
| 🐸 Frog | 100 | Bounces around the pond. From level 2 on it dodges in a random direction every time you hit it. |
| 🦆 Duck | 200 | Level 3 only. Faster than the frog. |
| 🪙 Coin | 50 | 10 coins appear at 1:30, 1:00 and 0:30 and vanish after 10 seconds. |

| Level | Frog speed | Duck | Cursor |
| --- | --- | --- | --- |
| 1 | Slow | – | Wand 1 |
| 2 | Fast, dodges | – | Wand 2 |
| 3 | Medium, dodges | Fast | Wand 3 |

When the round ends you enter a username (6+ characters: lowercase letters, digits, `_`) and your score is saved. The **Leaderboard** shows the top 5 for each level.

## Features

- Five screens: main menu, level select, game, game over and leaderboard
- Physics-style movement with edge bouncing, implemented in a UI-independent `MovingTarget` class
- Timed coin waves and a countdown clock driven by WinForms timers
- Custom mouse cursors generated from images per level
- Persistent high scores stored in SQLite with parameterised queries
- Username validation with clear feedback
- Unit tests for game logic and data access, run on every push with GitHub Actions

## Architecture

```
FrogGame.sln
├── src/
│   ├── FrogGame.Core/            # Game logic and persistence (no UI dependencies, netstandard2.0)
│   │   ├── GameRules.cs          # Points, timings, time formatting
│   │   ├── LevelSettings.cs      # Per-level speed, artwork and behaviour
│   │   ├── MovingTarget.cs       # Movement and bouncing for the frog and duck
│   │   ├── UsernameValidator.cs  # Username rules
│   │   └── ScoreRepository.cs    # SQLite high-score storage
│   └── FrogGame.WinForms/        # Windows Forms UI (net472)
│       ├── Forms/                # MainMenu, LevelSelect, Game, GameOver and Leaderboard screens
│       ├── Assets/               # Images loaded at runtime
│       ├── CoinSpawner.cs        # Spawns and clears bonus coins
│       ├── GameAssets.cs         # Image and cursor loading with graceful fallback
│       └── Navigator.cs          # Screen transitions and application lifetime
└── tests/
    └── FrogGame.Core.Tests/      # xUnit tests (net8.0)
```

The UI layer only handles input and rendering. Rules, movement and storage live in `FrogGame.Core`, so they can be unit tested on any OS without starting a window.

## Getting started

### Requirements

- Windows 10 or 11
- [.NET SDK 8](https://dotnet.microsoft.com/download) (builds the .NET Framework 4.7.2 app as well as the tests)
- Optional: Visual Studio 2022 with the *.NET desktop development* workload

### Run

```bash
git clone https://github.com/matinapap/Tap-the-Screen-Game.git
cd Tap-the-Screen-Game
dotnet run --project src/FrogGame.WinForms
```

Or open `FrogGame.sln` in Visual Studio and press **F5**.

### Test

```bash
dotnet test
```

The tests cover `FrogGame.Core` only and also run on macOS and Linux.

## Tech stack

**C#** · **Windows Forms** · **.NET Framework 4.7.2** · **.NET Standard 2.0** · **SQLite** (Microsoft.Data.Sqlite) · **xUnit** · **GitHub Actions**

## Author

**Matina Papadakou** · [GitHub](https://github.com/matinapap)
