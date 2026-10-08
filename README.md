# Millionaire

A C# Windows Forms quiz game inspired by the classic **Who Wants to Be a Millionaire?** format.

The game takes the player through 15 levels of questions, with increasing prize values. Questions and answers are loaded from an external text file, while questions and answer choices are randomized during gameplay.

## Features

- 15 progressive levels
- Randomly selected questions
- Randomized answer order
- 50/50 lifeline
- Question-switch lifeline
- Withdraw / walk-away option
- Answer confirmation
- Prize progression
- Win and game-over states
- Questions loaded from an external `questions.txt` file

## Technologies

- **C#**
- **.NET 8**
- **Windows Forms**
- **Object-Oriented Programming**

## Project Structure

```text
Millionaire/
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── GAMEMANAGER.cs
├── QUESTION.cs
├── QUESTIONBASE.cs
├── Program.cs
├── Millionaire.csproj
└── questions.txt
````

## Main Components

### `Form1.cs`

Handles the user interface and main gameplay flow, including answer selection, level progression, lifelines, and withdrawing from the game.

### `GAMEMANAGER.cs`

Handles loading questions, selecting questions, and shuffling answer choices.

### `QUESTIONBASE.cs`

Defines the base structure for questions.

### `QUESTION.cs`

Extends `QUESTIONBASE` and handles correct-answer validation.

### `Program.cs`

Contains the application entry point and launches the Windows Forms interface.

## Gameplay

The player starts at the first level and receives a randomly selected question.

Each question has four possible answers, with the correct answer randomized among the available positions.

The player can:

* Select an answer
* Use the **50/50** lifeline
* Switch the current question
* Withdraw with the current prize

A correct answer advances the player to the next level. A wrong answer ends the game.

Reaching the final level completes the game.

## Question System

Questions are stored externally in `questions.txt` and loaded when the application starts.

The game manager handles the question pool and random selection, keeping the question data separate from the main gameplay logic.

## Object-Oriented Design

The project uses several OOP concepts, including:

* Classes and objects
* Inheritance
* Abstract classes
* Method overriding
* Encapsulation
* Separation of game logic and UI logic

The `QUESTION` class inherits from the `QUESTIONBASE` class and implements its own answer-validation logic.

## Requirements

* Windows
* .NET 8 SDK
* Visual Studio 2022 or another IDE supporting .NET 8 Windows Forms

## Running the Project

Clone the repository:

```bash
git clone https://github.com/Jandyi/Millionaire.git
```

Open the solution in Visual Studio:

```text
Millionaire.sln
```

Build and run the project.

## Project Information

* **Status:** Completed
* **Developed:** 2024
