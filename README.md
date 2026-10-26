# CyberShield Password Analyser

A C# Windows Forms desktop application that helps security analysts evaluate the strength of employee passwords before they are approved for use. Passwords are scored against a set of security rules, classified by strength, and checked against different policies for Personal, Business, and Administrator accounts. The project demonstrates core object-oriented programming principles: abstraction, inheritance, and polymorphism.

## Screenshots

### Analyst registration
![Start form](docs/screenshots/start-form.png)

### Password analysis
![Main form](docs/screenshots/main-form.png)

### Security report
![Report form](docs/screenshots/report-form.png)

## Features

- Analyst registration with name validation (letters and spaces only, using `char.IsLetter()` and iteration)
- Password scoring out of 100 against five standard security rules
- Account-specific policies for Personal, Business, and Administrator passwords
- Strength classification: Weak, Moderate, Strong, Very Strong
- Tailored recommendations for improving weak passwords
- Session history of every analysed password
- Summary report with totals, average, highest, lowest, and a breakdown by strength

## Scoring rules

Each rule met earns 20 marks, for a maximum of 100.

| Rule | Marks |
| At least 8 characters | 20 |
| At least one uppercase letter | 20 |
| At least one lowercase letter | 20 |
| At least one digit | 20 |
| At least one special character | 20 |

### Password policies

| Account type | Additional rule | Penalty |
| Personal | Must not contain a possible birth year (1950 to the current year) | -10 |
| Business | Must contain at least 10 characters | -10 |
| Administrator | Must contain at least 12 characters | -10 |
| Administrator | Must contain at least 2 special characters | -10 |

### Strength classification

| Score | Strength |
| 0 to 39 | Weak |
| 40 to 69 | Moderate |
| 70 to 89 | Strong |
| 90 to 100 | Very Strong |

## Project structure

```
PasswordAnalyzer/
├── Program.cs                    Application entry point
├── Models/
│   ├── Password.cs               Abstract base class
│   ├── PersonalPassword.cs       Birth-year check
│   ├── BusinessPassword.cs       10-character minimum
│   ├── AdministratorPassword.cs  12-character and 2-special-character rules
│   └── PasswordManager.cs        Session storage and statistics
└── Forms/
    ├── StartForm.cs              Analyst registration
    ├── MainForm.cs               Password analysis
    └── ReportForm.cs             Session report
```

## Object-oriented design

- **Abstraction:** `Password` is an abstract class that holds the shared state and logic (`CalculateScore()`, `GetStrength()`, `GenerateRecommendation()`) and declares the abstract method `AnalysePassword()`.
- **Inheritance:** `PersonalPassword`, `BusinessPassword`, and `AdministratorPassword` inherit from `Password`.
- **Polymorphism:** each subclass overrides `AnalysePassword()` with its own policy. `MainForm` and `PasswordManager` work with the `Password` type and never need to know which subclass they hold.
- **Encapsulation:** `PasswordManager` owns the `List<Password>` and exposes only the operations needed for reporting.

## Getting started

### Prerequisites

- Windows 10 or 11
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- .NET 8 SDK

### Run the project

```bash
git clone https://github.com/SmangalisoMathebula/PasswordAnalyzer.git
cd PasswordAnalyzer
```

1. Open `PasswordAnalyzer.sln` (or the `.csproj`) in Visual Studio.
2. Build the solution with **Ctrl + Shift + B*.
3. Press *F5* to run.

## Usage

1. Enter your name on the start screen (letters and spaces only).
2. Enter a password and choose the account type.
3. Click **Analyse** to see the score, strength, and recommendations.
4. Repeat for as many passwords as you like. Each one is added to the session list.
5. Click **Generate Report** for a summary of the session.

## Example results

| Password | Type | Result |
| `abc` | Personal | Weak, with several recommendations |
| `Summer1999!` | Personal | Birth-year warning, 10 marks deducted |
| `Passw0rd!` | Business | Under 10 characters, 10 marks deducted |
| `Admin123!` | Administrator | Under 12 characters and only one special character, 20 marks deducted |
| `Tr!cky#Pass42word` | Administrator | Meets every rule, Very Strong |

## Challenges and what I learned

- **Sharing logic without repeating it:** the five standard rules apply to every password type, so they live once in the abstract `Password` class. Each subclass calls that shared scoring first and then applies only its own extra rule.
- **Keeping the score in range:** deductions could push a score below zero, so a single helper clamps the score between 0 and 100.
- **Separating logic from the interface:** the password classes know nothing about Windows Forms. The forms only create objects, call `AnalysePassword()`, and display the results, which keeps the scoring easy to test and change.
- **Working with the Visual Studio designer:** I learned how designer files, control names, and event handlers connect, and how stale build output can cause duplicate-attribute errors.

## Built with

- C# and .NET 8
- Windows Forms

## Author

Smangaliso Mathebula
[GitHub](https://github.com/SmangalisoMathebula)
