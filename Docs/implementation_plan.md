# QR Code Generator Application Plan

## Goal Description
Create a .NET MVC Core application that collects user information (Name, Role, Mobile No, Experience, Last Company, Skills) and generates a QR code containing this data.

## User Review Required
> [!IMPORTANT]
> **Project Location**: The application will be created in a new subdirectory `QrInfoApp` inside the current Angular workspace `d:/study material/CodePulse/UI/codepulse`. This is to adhere to workspace restrictions. If you prefer a different location, please specify (must be within active workspaces).

## Proposed Changes
### Project Initialization
#### [NEW] [QrInfoApp](file:///d:/study_material/CodePulse/UI/codepulse/QrInfoApp)
- Initialize new ASP.NET Core MVC project: `dotnet new mvc -n QrInfoApp`
- Add NuGet package: `QRCoder`

### Models
#### [NEW] QrInfoApp/Models/UserProfile.cs
- Properties:
  - Name (string)
  - Role (string)
  - MobileNo (string)
  - ExperienceYears (int)
  - LastCompany (string)
  - Skills (string)

### Controllers
#### [MODIFY] QrInfoApp/Controllers/HomeController.cs
- **Index (GET)**: Returns the input form view.
- **Generate (POST)**: Accepts `UserProfile`, generates QR code string (JSON or formatted text), converts to image, passes to View (via ViewBag or ViewModel).

### Views
#### [MODIFY] QrInfoApp/Views/Home/Index.cshtml
- Form to input user details.
#### [NEW] QrInfoApp/Views/Home/Result.cshtml
- Display user details.
- Display generated QR code image (Base64 encoded).

## Verification Plan
### Automated Tests
- Build the project: `dotnet build`
- Ensure no compilation errors.

### Manual Verification
1. Run the app: `dotnet run`
2. Navigate to `http://localhost:5xxx`.
3. Fill in the form with sample data.
4. Click "Generate".
5. Verify the Result page shows the correct details and a visible QR code.
6. (Optional) Scan QR code with a real phone to verify content.
