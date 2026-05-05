# BankSystem: Unit Testing Walkthrough

A C# implementation of a bank account management system, developed using **Test-Driven Development (TDD)** principles and the **Microsoft Unit Test Framework**.

## Project Overview
This repository demonstrates a professional workflow for creating, running, and customizing unit tests in .NET. It focuses on the `BankAccount` class, specifically ensuring the reliability of debit and credit transactions.

## Features & Logic
- **Account Management:** Handles customer names and balances.
- **Transaction Validation:** 
  - Prevents debits exceeding the current balance.
  - Prevents transactions with negative amounts.
  - Throws `ArgumentOutOfRangeException` with detailed error messages for invalid inputs.

## Testing Architecture
The project is split into two main components following industry standards:
1. **Bank Project:** The core logic containing the `BankAccount` class.
2. **BankTests Project:** A dedicated unit test project using **MSTest** (adaptable to NUnit).

### Test Methodology
We use an iterative process of analysis, test development, and refactoring:
- **Arrange-Act-Assert (AAA):** Each test method is structured to set up data, perform the action, and verify the result.
- **Exception Testing:** Uses `Assert.ThrowsException` and `StringAssert.Contains` to verify that the correct error messages are delivered when logic fails.
- **Boundary Analysis:** Tests include valid amounts, negative amounts, and amounts exceeding the balance.

## Getting Started

### Prerequisites
- Visual Studio 2019/2022 or .NET SDK.
- **Test Explorer** window for managing and running test suites.

### Running Tests
1. **Build the Solution:** `Ctrl + SHIFT + B`.
2. **Open Test Explorer:** `Test > Windows > Test Explorer`.
3. **Run All Tests:** Click **Run All** in Test Explorer to execute the suite and view the green/red status bar.

## Iterative Improvement & Refactoring
As per the walkthrough, this project evolved through:
1. **Bug Discovery:** Initial tests uncovered a bug where debits were incorrectly added to the balance.
2. **Refactoring:** Improved the production code to provide richer exception information using constants for error messages.
3. **Robustness:** Added `Assert.Fail()` to test methods to ensure they fail if an expected exception is *not* thrown.

---
*This project follows the official Microsoft documentation for creating and running unit tests for managed code.*
