# 2-Rechner (WinForms)

## Overview
Legacy Windows Forms calculator project for school exercises.
The app takes two numeric inputs and computes different operations based on selected radio buttons.

## Main Features
- Basic arithmetic: `+`, `-`, `*`, `/`, modulo
- Geometry helpers: circle area, cylinder volume, Pythagoras
- Trigonometry: `sin`, `cos` (degree input)
- Digit sum (Quersumme) for integer input
- GUI with direct result output and validation messages

## Tech Stack
- C#
- .NET Framework 4.7.2
- Windows Forms

## Project Structure
- `Program.cs`: application entry point
- `Form1.cs`: operation logic and validation
- `Form1.Designer.cs`: UI layout and controls
- `2_RECHNER.sln`: Visual Studio solution

## Requirements
- Windows
- Visual Studio 2019/2022 with .NET desktop workload

## Run Locally
1. Open `2_RECHNER.sln` in Visual Studio.
2. Build the solution.
3. Start with `F5` (Debug) or `Ctrl+F5` (without debugger).

## Security and Data Hygiene
- Repository is source-only; build output must stay untracked.
- Never commit secrets (`.env`, keys, certs) or local data dumps.
