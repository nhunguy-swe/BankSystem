# BankSystem - Unit Testing Practice 

A C# project demonstrating professional unit testing workflows for bank account management logic.

## Tech Stack
* **Language:** C# (.NET Core)
* **Testing Framework:** Microsoft Unit Test Framework (MSTest)
* **Tool:** Visual Studio Test Explorer

## Testing Methodology
This project focuses on verifying the reliability of debit and credit transactions through an iterative testing process:
1. **Arrange-Act-Assert (AAA):** Each test is structured to set up data, perform the operation, and verify the outcome.
2. **Bug Discovery:** Initial unit tests were used to identify and fix logic errors in balance calculations.
3. **Refactoring:** Improved the production code to use descriptive constants for error messages after passing initial tests.

## Testing Scenarios
* **Debit Validation:** Ensuring debits cannot exceed the current balance.
* **Boundary Testing:** Testing with zero, positive, and negative amounts to ensure system stability.
* **Exception Handling:** Verifying that `ArgumentOutOfRangeException` is thrown with specific error messages for invalid inputs.

## How to Run
1. Open the `.sln` file in **Visual Studio**.
2. Open **Test Explorer** (`Test > Windows > Test Explorer`).
3. Click **Run All** to execute the test suite and view the green/red status results.

---
*This project follows Microsoft's best practices for creating and running unit tests for managed code*.
