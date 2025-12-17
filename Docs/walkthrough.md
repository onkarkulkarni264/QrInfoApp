# QR Info App Walkthrough

## Overview
The QR Info App allows users to enter their professional details and generates a QR code containing that information.

## Prerequisites
- .NET 9.0 SDK installed

## How to Run
1. Open a terminal in the project directory:
   ```powershell
   cd "d:/study material/CodePulse/UI/codepulse/QrInfoApp"
   ```
2. Run the application:
   ```powershell
   dotnet run
   ```
3. Open your browser to the URL shown in the terminal (usually `http://localhost:5037` or similar).

## Usage
1. **Enter Details**: Fill in the form with your Name, Role, Mobile Number, Experience, Last Company, and Skills.
2. **Generate**: Click the "Generate QR Code" button.
3. **Scan**: Use a QR code scanner (like your phone's camera) to scan the generated code on the result page.
4. **Verify**: Ensure the scanned text matches the information you entered.

## Implementation Details
- **Framework**: ASP.NET Core MVC (.NET 9.0)
- **Library**: QRCoder (for QR generation)
- **Models**: `UserProfile` handles data validation.
- **Views**: 
  - `Index.cshtml`: Input form with validation.
  - `Result.cshtml`: Displays the QR code image rendered from Base64 string.
