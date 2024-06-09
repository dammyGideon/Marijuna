![DEKMACO Logo](https://dekamco.com/images/logo.png)

# HERBZHUB

## 🔧 Change Log

### Versioning Key

- **MAJOR**: Incompatible API changes (use `0` during initial development).
- **MINOR**: Backward-compatible functionality added (use `1` for the first minor release).
- **PATCH**: Backward-compatible bug fixes.
- **PRE-RELEASE**: Pre-release versions, indicating development stages (e.g., `alpha`, `beta`, `rc`).
- **FORMAT**: `MAJOR.MINOR.PATCH-PRE-RELEASE.BUILD` (e.g., `0.1.0-alpha.1`).

### Categories Reference

- **FEATURE**: New features or functionalities.
- **ENHANCEMENT**: Improvements to existing features or functionalities.
- **FIX**: Bug fixes.
- **DOCS**: Improvements or additions to documentation.
- **STYLE**: Code style changes (formatting, missing semi-colons, etc.), not affecting the logic of the code.
- **REFACTOR**: Code refactoring without adding new features or fixing bugs (improving code structure).
- **TEST**: Adding or updating tests.
- **CHORE**: Routine tasks, maintenance, or chores that do not fit into the other categories (e.g., updating build scripts).

### v0.1.0-alpha.34 - API Consumption and Bug Fixes
**Commit Date**: 6/8/2024  
**Developer**: Christian Stayton

#### ENHANCEMENT
- Consumed API to improve functionality and integration.
- Updated `index.js` file to fix API bug in the following location: `frontend\web\src\services\organizationType\index.js`.
- Updated `constant.js` file with new API endpoints in the following location: `frontend\web\src\services\constant.js`.

#### CHORE
- Updated file structure documentation to reflect recent changes.
- Updated the changelog.

### v0.1.0-alpha.33 - Comprehensive Controller and Infrastructure Updates
**Commit Date**: 6/8/2024  
**Developer**: Dami Gideon

#### FEATURE
- Added new functions in `OnboardingController`:
  - `GetCountries`
  - `GetStates`
  - Modifications to `ManufacturerOnboarding` function

#### ENHANCEMENT
- Updated `AuthenticationController`:
  - Improved `Login` function
  - Enhanced `ForgotPassword` and `ResetPassword` functions for better user experience
- Refined `CountiesController`:
  - Enhanced `GetCountries` function
  - Improved `GetStates` function
  - Updates to `GetManufacturer` and `GetCities` functions
- Updates to `ExtensionMethodServices` and email configurations to enhance authentication workflows.

#### REFACTOR
- Significant changes across various controllers and services to improve structure and maintainability.
- Code refactoring across `AuthenticationController`, `CountiesController`, and `OnboardingController`.

#### CHORE
- Project deployment settings updated to reflect recent changes.
- Multiple changes to `Herbzhub.Api.AssemblyInfo.cs` with 24 additions and deletions.
- Updates to related files:
  - `Herbzhub.Api.AssemblyInfoInputs.cache`
  - `Herbzhub.Api.GeneratedMSBuildEditorConfig.editorconfig`
  - `Herbzhub.Api.GlobalUsings.g.cs`
- Added binary files with sizes ranging from 22.2 KB to 53.1 KB.
- Changes to files within the Herbzhub infrastructure directory, including `Infrastructure.csproj.AssemblyReference.cache`.

#### FIX
- Updates to code files:
  - `AuthenticationRequest.cs`
  - `RefreshTokenRequest.cs`
  - `ResentPasswordRequest.cs`
  - `AuthResponses.cs`
- Changes to binary Release files within the Herbzhub infrastructure.

### v0.1.0-alpha.32 - Automated Version Badge Update
**Commit Date**: 6/6/2024  
**Developer**: Christian Stayton

#### FEATURE
- Implemented a Python script to automatically update the version badge in `README.md` based on the latest entry in `CHANGELOG.md`.

#### ENHANCEMENT
- Enhanced the `generate_version.py` script to handle character encoding issues.

### v0.1.0-alpha.31 - ANTD Warning Resolution
**Commit Date**: 6/6/2024  
**Developer**: Christian Stayton

#### FIX
- Resolved ANTD issues by updating `index.js` and `config-ovverrides.js`.

### v0.1.0-alpha.30 - Interactive CLI and Device Management Enhancements
**Commit Date**: 6/5/2024  
**Developer**: Christian Stayton

#### ENHANCEMENT
- Implemented an interactive CLI with menu options for managing devices.
- Added a loading screen with a progress bar during initialization.
- Introduced real-time status logging for user actions.
- Redesigned the CLI screen to display HHOS version and device information.

#### FEATURE
- Added setup process for configuring device name, type, serial number, and hardware version.
- Provided view configuration option for each device (Cam, Lock, Bag, Box).

#### FIX
- Resolved curses-related issues by ensuring bounds checking and proper text handling in the CLI.

### v0.1.0-alpha.29 - Enhancement - API integration
**Commit Date**: 6/5/2024  
**Developer**: Sajjad Ali

#### ENHANCEMENT
- Axios Package added for smooth API integration.
- Get All States API integrated into the onboarding flow.
- Get All Counties API integrated into the onboarding flow.
- Fixed dotenv import issue.
- Added Loader to wait for API data.
- Updated package.json to include Axios for API integration.
- Forget Password API integrated.
- Dynamic notification on API success or failure added.
- Working on API integration.
- Onboarding form ready to Integrate with mock data.
- Updated onboarding flow for new users.
- Updated onboarding flow and made it ready to integrate as per BE payload demand.
- Get Organization types API integration added.

### v0.1.0-alpha.28 - Refactored HHOS
**Commit Date**: 6/5/2024  
**Developer**: Christian Stayton

#### REFACTOR
- Refactored the HHOS file structure.

### v0.1.0-alpha.27 - Environment Variable Integration for API Key
**Commit Date**: 6/4/2024  
**Developer**: Christian Stayton

#### ENHANCEMENT
- Updated `map.js` to fetch the API key from the `.env` file instead of `config.js`.

#### CONFIG
- Added `dotenv` package to manage environment variables.
- Modified `config.js` to export the API key from the environment variables.
- Updated `package.json` to include the `dotenv` dependency.

#### DOCS
- Added an entry to the changelog for recent updates and configuration changes.

### v0.1.0-alpha.27 - Updated Dashboard and Sidebar Styling
**Commit Date**: 6/4/2024  
**Developer**: Christian Stayton

#### ENHANCEMENT
- Updated the sidebar and dashboard components to match the Figma design.
- Improved sidebar navigation with new styles for active links and hover states.
- Adjusted dashboard layout for better alignment and responsiveness.

#### FIX
- Corrected import paths for components and styles in the dashboard implementation.

#### DOCS
- Added an entry to the changelog for recent updates and fixes.

### v0.1.0-alpha.26 - Created Dashboard for Manufacturing 'Pro'
**Commit Date**: 6/4/2024  
**Developer**: Christian Stayton

#### FEATURE
- Created the Pro Dashboard for manufacturing with a sidebar for navigation.
- Integrated Google Maps for asset location display.
- Ensured responsiveness across various devices.

#### CHORE
- Updated `package.json` to include `react-app-rewired` for customizing CRA configuration.

### v0.1.0-alpha.25 - Updated Onboarding Process
**Commit Date**: 6/3/2024  
**Developer**: Sajjad Ali, CHristian Stayton

#### ENHANCEMENT
- Updated complete onboarding process with review information page.
- Added error handling on password & confirm password matching.
- Progress bar added on each screen.
- Added responsiveness for all gadgets.

#### CHORE
- Updated `package.json` file to include `nprogress` dependencies.

### v0.1.0-alpha.24 - Another Test Update
**Commit Date**: 6/3/2024  
**Developer**: Christian Stayton

#### FEATURE
- Added another feature to test the version badge update again.

#### CHORE
- More minor updates and fixes.

### v0.1.0-alpha.23 - Automated Version Badge Update
**Commit Date**: 6/3/2024  
**Developer**: Christian Stayton

#### FEATURE
- Implemented a GitHub Action to automatically update the version badge in `README.md` based on the latest entry in `CHANGELOG.md`.

#### CHORE
- Added a placeholder for the version badge in `README.md` and set up the workflow to update it automatically.

### v0.1.0-alpha.22 - Automated Version Badge Update
**Commit Date**: 6/3/2024  
**Developer**: Christian Stayton

#### FEATURE
- Implemented a GitHub Action to automatically update the version badge in `README.md` based on the latest entry in `CHANGELOG.md`.

#### CHORE
- Added a placeholder for the version badge in `README.md` and set up the workflow to update it automatically.

### v0.1.0-alpha.21 - Review Step Integration
**Commit Date**: 6/3/2024  
**Developer**: Christian Stayton

#### FEATURE
- Added a review step before the completion step in the onboarding process. This step displays all the information entered by the user for review and allows edits before submission.

#### FIX
- Added missing Organization Type value 'Transporter' on the `OrganizationTypeForm.js`.
- Adjusted spacing in `auth.css` for text and images on Sign In and Onboarding screens.

### v0.1.0-alpha.20 - Connection and Style Fixes
**Commit Date**: 6/2/2024  
**Developer**: Christian Stayton

#### FIX
- Corrected the capitalization in an import link to resolve a connection issue in the `index.js` file: changed `import './styles/onboarding.css'` to `import './styles/Onboarding.css'`.
- Updated `package.json` to ensure all dependencies are installed before starting the application.
- Adjusted spacing in `auth.css` for text and images on Sign In and Onboarding screens.

### v0.1.0-alpha.19 - Codebase Enhancement
**Commit Date**: 6/2/2024  
**Developer**: Sajjad Ali

#### ENHANCEMENT
- Codebase refactoring.
- Updated folder structure.
- Removed unused code.
- Updated styles folder with `auth.css` file (style will be managed module-wise from now onward).
- Updated sign-in and reset password pages with responsiveness and general style.
- Enhanced 3 packages (Formik, AntD, Yup):
  - Formik for managing all forms with a single state.
  - AntD for front-end fixes.
  - Yup for error handling on the front end.
- Updated footer style and added favicon.
- Added Suspense fallback loading page.
- Added 404 page.
- Fixed reset password screen content display and updated it.
- Added error notification display.
- Updated onboarding flow with routing and cosmetic issues.

### v0.1.0-alpha.18 - Workflow Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.17 - Workflow Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.16 - Workflow Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.15 - Workflow Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.14 - Workflow Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.13 - Feature Addition, Workflow & Changelog Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton, Dami GIdeon

#### FEATURE

- Created Reset Password API.

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.
- Updated `CHANGELOG.md` file format and organization.

### v0.1.0-alpha.12 - Workflow & Changelog Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.
- Updated `CHANGELOG.md` file format and organization.

### v0.1.0-alpha.11 - Workflow Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.10 - Workflow Update
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.9 - Workflow Update & Bug fixes
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file to use Node.js 20.
- Reverted previously changed backend files to v0.1.0-alpha.1.

### v0.1.0-alpha.8 - Workflow Update & Bug fixes
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file to use Node.js 20.
- Reverted previously changed backend files to v0.1.0-alpha.1.

### v0.1.0-alpha.7 - Workflow Update & Bug fixes
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file to use Node.js 20.

#### FIX
- Fixed non-nullable property warnings by initializing properties in constructors for:
  - `UserDetails`
  - `UploadRequest`
  - `ResentPasswordRequest`
  - `ManufactureRequest`
  - `GenericNameResponse`
  - `AddressRequest`
  - `AuthResponses`
  - `AuthenticationRequest`
  - `LicensingRequest`
  - `ForgotPasswordRequest`
  - `FinancialRequest`
  - `ChangePasswordRequest`
  - `BusinessLocation`
- Corrected property names in `ManufactureRequest` to follow PascalCase convention.
- Updated `ManufacturerRequestValidator` and `AddressRequestValidator` to use correct property names.

### v0.1.0-alpha.6 - Workflow Update & Bug fixes
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file to use Node.js 20.

#### FIX
- Fixed non-nullable property warnings by initializing properties in constructors for:
  - `UserDetails`
  - `UploadRequest`
  - `ResentPasswordRequest`
  - `ManufactureRequest`
  - `GenericNameResponse`
  - `AddressRequest`
  - `AuthResponses`
  - `AuthenticationRequest`
  - `LicensingRequest`
  - `ForgotPasswordRequest`
- Corrected property names in `ManufactureRequest` to follow PascalCase convention.
- Updated `ManufacturerRequestValidation` to use correct property names.

### v0.1.0-alpha.5 - Workflow Update & Bug fixes
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

#### FIX
- Fixed non-nullable property warnings by initializing properties in constructors:
  - `UserDetails`
  - `UploadRequest`
  - `ResentPasswordRequest`
  - `ManufactureRequest`

### v0.1.0-alpha.4 - Workflow Update & Bug fixes
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.3 - Workflow Update & Bug fixes
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### CHORE
- Updated `DeploymentWorkFlow.yml` file.

### v0.1.0-alpha.2 - Multiple Features, Onboarding Refactor & More
**Commit Date**: 6/1/2024  
**Developer**: Christian Stayton

#### FEATURE
- Created the 'Reset Password' page.
  - Added functionality for users to input their email to request a password reset.
  - Displayed a confirmation message after the email is submitted.
  - Updated `App.js` with new route for the 'Reset Password' page. 
- Created `LicensingForm.js` to handle the new step for licensing and regulatory compliance in the onboarding process.
  - Added relevant input fields and logic for handling the state license numbers.
- Created `CompletionStep.js` for the final step in the onboarding process.
  - Displays a completion message and a button to navigate to the dashboard.
  - Updated `Onboarding.js` to include the new completion step.

#### FIX
- Fixed issue in `Onboarding.js` where the serial number input field was not accepting input. Updated the `handleInputChange` function to correctly update the `serialNumber` state.

#### REFACTOR
- Refactored `Onboarding.js` into smaller, more manageable components for better readability, maintainability, and reusability:
  - `OrganizationTypeForm.js`: Handles the organization's type selection.
  - `CountyForm.js`: Manages the county selection form.
  - `SerialNumberForm.js`: Manages the serial number input form.
  - `PocForm.js`: Handles the organization representative information form.
  - `VerificationForm.js`: Manages the ID verification form.
  - `OrganizationForm.js`: Handles the organization information form.
  - `CredentialsForm.js`: Manages the account creation form.
  - `CompletionStep.js`: Displays the onboarding completion message.
- **OrganizationForm.js Update**
  - Removed 'Operational Information' and 'Financial Information' sections.
  - Only includes 'Business Details' and 'Location and Contact Information' sections.

#### ENHANCEMENT
- Created `helper.js` in the `utils` directory to manage the `getStatusIcon` function, which returns the appropriate status icon based on the verification status.
- Provided a clear directory structure to organize the components and other files (see 'file_structure.txt' file for update structure).
- **Onboarding Steps Update**
  - Updated `Onboarding.js` to include the new licensing and regulatory compliance step.
  - Adjusted step numbers:
    - Licensing and Regulatory Compliance is now step 5.
    - OrganizationForm is now step 6.
    - CredentialsForm is now step 7.
    - CompletionStep is now step 8.

#### STYLE
- Added and updated CSS styles specific to the 'Reset Password' page for consistency with the login page design.
- Added and updated CSS styles for the onboarding completion step.

#### CHORE
- **Directory Structure Update**
  - Updated `file_structure.txt` to reflect the new component and changes.
  - Corrected import paths and ensured all components were correctly imported and used in `Onboarding.js`.
- Updated `.gitignore` file and deleted any duplicates that were not at the source of the project.
- Changed `login.js` and `login.css` to `signin.js` and `signin.css`.
- Updated `App.js` file to change `login` routes to `signin` routes.
- Moved all CSS files to the styles folder.
- Updated all JS files to link to the moved CSS files.
- Changed all CSS references from `login` to `signin`.
- Corrected import paths and ensured that all components were correctly imported in `Onboarding.js`.
- Ensured states were correctly imported in `PocForm.js`.

### v0.0.10 - 5/29/2024 - Frontend fixes

#### FIX
- Fixed `Login.js` layout.

#### CHORE
- Uploaded `.gitignore` file.

### v0.0.9 - 5/28/2024 - Backend fixes

#### FEATURE
- New Onboarding Endpoint.

### v0.0.8 - 5/27/2024 - Backend fixes

#### FEATURE
- Created Onboarding Endpoint.

### v0.0.7 - 5/21/2024 - Fixed Bugs Cont.

#### FIX
- Fixed issue where input fields in `Onboarding.js` were not editable.

#### ENHANCEMENT
- Added non-breaking space between "Already have an account?" and "Sign in." in `Onboarding.js`.

### v0.0.6 - 5/20/2024 - Frontend work & Bug Fixes

#### ENHANCEMENT
- Added validation to all fields in the Onboarding component, ensuring all required fields are satisfied before moving to the next step.
- Added an API check for Federal and State License Numbers, displaying an indicator for validation status using FontAwesome icons.
- Included additional verification for phone numbers, emails, and other components in the onboarding forms.
- Updated fields for the organization form to include Licensing and Regulatory Compliance, Business Details, Location and Contact Information, Operational Information, and Financial Information.
- Added dropdowns for State fields in all relevant forms.
- Improved component reuse by integrating the Button component for form submissions.

#### FEATURE
- Implemented functionality to upload a copy of the license for Licensing and Regulatory Compliance.
- Added functionality to upload a photo of an ID and display the ID verification status.

#### STYLE
- Modified the CSS for the Onboarding component to improve layout and responsiveness.
  - Adjusted padding and alignment to ensure a consistent look across devices.
  - Implemented styles for the verification status bubble with dynamic colors based on status.

#### FIX
- Fixed issues related to image paths and component imports.

#### CHORE
- Addressed ESLint warnings to ensure code quality.

### v0.0.5 - 5/19/2024 - Backend and workflow Configuration

#### FEATURE
- Added Counties list to the Database.
  - Step 1: Seeded list of Counties into the Database.
  - Step 2: Created an endpoint to get all counties from the counties table.
- Created the Authentication Endpoint.
  - Step 1: Checked if user exists in the database table.
  - Step 2: Generated token for Authenticated Users.
- Manufacturer CRUD.
  - Step 1: Get Input from the frontend.
  - Step 2: Adding Validation using FluentApi.

### v0.0.4 - 5/17/2024

#### ENHANCEMENT
- Updated the Onboarding component to include a multi-step form.
  - Step 1: County selection.
  - Step 2: Device serial number input.
  - Step 3: Company representative information form with fields arranged in horizontal pairs.
- Improved component reuse by integrating the Button component for form submissions.

#### FEATURE
- Added functionality to upload a photo of an ID and display the ID verification status.

#### STYLE
- Modified the CSS for the Onboarding component to improve layout and responsiveness.
  - Adjusted padding and alignment to ensure a consistent look across devices.
  - Implemented styles for the verification status bubble with dynamic colors based on status.

#### FIX
- Fixed issues related to image paths and component imports.

#### CHORE
- Addressed ESLint warnings to ensure code quality.

### v0.0.3 - 5/9/2024

#### FIX
- Fixed Github issue uploading 'Mobile' folder.

### v0.0.2 - 4/30/2024

#### FEATURE
- Initiated frontend development for Herbzhub using React and React Native.

#### CONFIG
- Established distinct directories for web (web) and mobile (mobile) development within the frontend, with shared resources in the common directory.

#### CHORE
- Set up the environment for both React (web) and React Native (mobile) applications, including necessary dependencies and navigation libraries.
- Configured ESLint and Prettier for maintaining code quality standards across the project.

#### ENHANCEMENT
- Planned the component architecture for both web and mobile platforms, focusing on reusable components and specific views.

### v0.0.1 - 4/28/2024

#### FEATURE
- Initial setup of the Herbzhub Operating System (HHOS) for devices including HerbzCam and HerbzLock.
- Implemented basic simulation and interaction classes for devices:
  - BaseDevice class for generalized device behaviors such as connect, disconnect, and send data.
  - HerbzCam and HerbzLock classes enhanced to handle specific functionalities like camera streaming and lock control.
- Created a structured approach to handle device commands using a master-slave architecture with HerbzCam as the potential master.

#### CHORE
- Development environment established, integrating Python with specific hardware components on Raspberry Pi Zero 2 W.
- Started integration with Raspberry Pi-specific libraries such as `RPi.GPIO` and `picamera`, acknowledging issues when attempting installation on non-Pi systems.
- Prepared mock setups and simulated functionalities for non-Raspberry Pi development environments.
- Resolved initial software installation issues and set up the project's Python environment appropriately.
