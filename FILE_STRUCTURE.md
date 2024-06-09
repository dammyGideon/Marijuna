# File Structure
===============

├── ./
│   ├── .gitattributes
│   ├── .gitignore
│   ├── CHANGELOG.md
│   ├── FILE_STRUCTURE.md
│   ├── LICENSE.md
│   ├── README.md
│   ├── version.json
│   ├── .github/
│   │   ├── workflows/
│   │   │   ├── DeploymentWorkFlow.yml
│   ├── .resources/
│   │   ├── generate_filestructure.py
│   │   ├── generate_version.py
│   │   ├── SCRATCHPAD.txt
│   │   ├── GitHubActions/
│   │   │   ├── herbzhub
│   │   │   ├── nginx.conf
│   ├── backend/
│   │   ├── Herbzhub/
│   │   │   ├── src/
│   │   │   │   ├── .dockerignore
│   │   │   │   ├── .editorconfig
│   │   │   │   ├── docker-compose.yml
│   │   │   │   ├── Herbzhub.sln
│   │   │   │   ├── Herbzhub.Api/
│   │   │   │   │   ├── Dockerfile
│   │   │   │   │   ├── Herbzhub.Api.csproj
│   │   │   │   │   ├── Herbzhub.Api.csproj.user
│   │   │   │   │   ├── HerbzhubApi.http
│   │   │   │   │   ├── Program.cs
│   │   │   │   │   ├── Controllers/
│   │   │   │   │   │   ├── AuthenticationController.cs
│   │   │   │   │   │   ├── BaseController.cs
│   │   │   │   │   │   ├── CountiesController.cs
│   │   │   │   │   │   ├── OnboardingController.cs
│   │   │   │   │   ├── ExtensionMethods/
│   │   │   │   │   │   ├── ExceptionMiddlewareExtensions.cs
│   │   │   │   │   │   ├── ExtensionMethodServices.cs
│   │   │   │   │   │   ├── FluentEmailExtensions.cs
│   │   │   │   │   ├── Resource/
│   │   │   │   │   │   ├── ForgetPasswordTemplate.html
│   │   │   │   │   │   ├── logo192.png
│   │   │   │   ├── Herbzhub.Infrastructure/
│   │   │   │   │   ├── Herbzhub.Infrastructure.csproj
│   │   │   │   │   ├── CrossCutting/
│   │   │   │   │   │   ├── ForgotPassword.cs
│   │   │   │   │   ├── Helper/
│   │   │   │   │   │   ├── BaseResponse.cs
│   │   │   │   │   │   ├── EmailMetadata.cs
│   │   │   │   │   │   ├── EmailServices.cs
│   │   │   │   │   │   ├── EmailSettings.cs
│   │   │   │   │   │   ├── ErrorDetails.cs
│   │   │   │   │   │   ├── JwtTokenHelper.cs
│   │   │   │   │   │   ├── PasswordHandler.cs
│   │   │   │   │   │   ├── SMTPSetting.cs
│   │   │   │   │   ├── Interface/
│   │   │   │   │   │   ├── IAuthenticationService.cs
│   │   │   │   │   │   ├── ICountiesService.cs
│   │   │   │   │   │   ├── ILoggerManager.cs
│   │   │   │   │   │   ├── ImanufacturerService.cs
│   │   │   │   │   ├── Services/
│   │   │   │   │   │   ├── AuthenticationService.cs
│   │   │   │   │   │   ├── CountiesServices.cs
│   │   │   │   │   │   ├── CreateTokenService.cs
│   │   │   │   │   │   ├── LoggerManager.cs
│   │   │   │   │   │   ├── ManufacturerService.cs
│   │   │   │   ├── Herbzhub.Models/
│   │   │   │   │   ├── Herbzhub.Models.csproj
│   │   │   │   │   ├── Request/
│   │   │   │   │   │   ├── AddressRequest.cs
│   │   │   │   │   │   ├── AuthenticationRequest.cs
│   │   │   │   │   │   ├── BusinessDetails.cs
│   │   │   │   │   │   ├── BusinessLocation.cs
│   │   │   │   │   │   ├── ChangePasswordRequest.cs
│   │   │   │   │   │   ├── EmailSendDto.cs
│   │   │   │   │   │   ├── FinancialRequest.cs
│   │   │   │   │   │   ├── ForgotPasswordRequest.cs
│   │   │   │   │   │   ├── LicensingRequest.cs
│   │   │   │   │   │   ├── ManufactureRequest.cs
│   │   │   │   │   │   ├── RefreshTokenRequest.cs
│   │   │   │   │   │   ├── ResentPasswordRequest.cs
│   │   │   │   │   │   ├── UploadRequest.cs
│   │   │   │   │   │   ├── UserDetails.cs
│   │   │   │   │   ├── Response/
│   │   │   │   │   │   ├── AuthResponses.cs
│   │   │   │   │   │   ├── GenericNameResponse.cs
│   │   │   │   │   ├── Validations/
│   │   │   │   │   │   ├── AddressRequestValidator.cs
│   │   │   │   │   │   ├── BusinessDetailsValidator.cs
│   │   │   │   │   │   ├── ManufacturerRequestValidation.cs
│   │   │   │   ├── Herbzub.Data/
│   │   │   │   │   ├── DbApplicationContext.cs
│   │   │   │   │   ├── Herbzhub.Data.csproj
│   │   │   │   │   ├── Models/
│   │   │   │   │   │   ├── Address.cs
│   │   │   │   │   │   ├── AuditFeedback.cs
│   │   │   │   │   │   ├── BaseEntity.cs
│   │   │   │   │   │   ├── City.cs
│   │   │   │   │   │   ├── ContactInformation.cs
│   │   │   │   │   │   ├── Counties.cs
│   │   │   │   │   │   ├── Country.cs
│   │   │   │   │   │   ├── Customer.cs
│   │   │   │   │   │   ├── CustomerAudit.cs
│   │   │   │   │   │   ├── CustomerLegalDocument.cs
│   │   │   │   │   │   ├── CustomerMedicalInformation.cs
│   │   │   │   │   │   ├── CustomerPreferencesNotes.cs
│   │   │   │   │   │   ├── Driver.cs
│   │   │   │   │   │   ├── DriverEmploymentDetail.cs
│   │   │   │   │   │   ├── DriverVehicleInformation.cs
│   │   │   │   │   │   ├── FinancialInformation.cs
│   │   │   │   │   │   ├── InventoryManagement.cs
│   │   │   │   │   │   ├── ManufacturerDispensary.cs
│   │   │   │   │   │   ├── PersonalIdentification.cs
│   │   │   │   │   │   ├── Roles.cs
│   │   │   │   │   │   ├── SecurityMeasures.cs
│   │   │   │   │   │   ├── SMSVerificationCode.cs
│   │   │   │   │   │   ├── State.cs
│   │   │   │   │   │   ├── User.cs
│   │   │   │   │   │   ├── UserRole.cs
│   │   │   │   │   ├── Seeders/
│   │   │   │   │   │   ├── CityTableSeeder.cs
│   │   │   │   │   │   ├── CountiesTableSeeder.cs
│   │   │   │   │   │   ├── CountryTableSeeder.cs
│   │   │   │   │   │   ├── RoleTableSeeder.cs
│   │   │   │   │   │   ├── StateTableSeeder.cs
│   │   │   │   │   │   ├── UserSeedData.cs
│   ├── frontend/
│   │   ├── .prettierrc
│   │   ├── eslint.config.mjs
│   │   ├── package-lock.json
│   │   ├── package.json
│   │   ├── common/
│   │   │   ├── assets/
│   │   │   │   ├── placeholder.txt
│   │   │   ├── hooks/
│   │   │   │   ├── placeholder.txt
│   │   │   ├── styles/
│   │   │   │   ├── placeholder.txt
│   │   │   ├── utils/
│   │   │   │   ├── placeholder.txt
│   │   ├── web/
│   │   │   ├── config-overrides.js
│   │   │   ├── package-lock.json
│   │   │   ├── package.json
│   │   │   ├── public/
│   │   │   │   ├── android-chrome-192x192.png
│   │   │   │   ├── android-chrome-512x512.png
│   │   │   │   ├── apple-touch-icon.png
│   │   │   │   ├── favicon-16x16.png
│   │   │   │   ├── favicon-32x32.png
│   │   │   │   ├── favicon.ico
│   │   │   │   ├── herbzhub_text_152030.png
│   │   │   │   ├── index.html
│   │   │   │   ├── logo192.png
│   │   │   │   ├── logo512.png
│   │   │   │   ├── manifest.json
│   │   │   │   ├── robots.txt
│   │   │   │   ├── images/
│   │   │   │   │   ├── herbzhub_icon_152030.png
│   │   │   │   │   ├── herbzhub_login_bg.jpg
│   │   │   │   │   ├── herbzhub_text_152030.png
│   │   │   ├── src/
│   │   │   │   ├── .env
│   │   │   │   ├── config.js
│   │   │   │   ├── index.js
│   │   │   │   ├── assets/
│   │   │   │   │   ├── images/
│   │   │   │   │   │   ├── android-chrome-192x192.png
│   │   │   │   │   │   ├── android-chrome-512x512.png
│   │   │   │   │   │   ├── apple-touch-icon.png
│   │   │   │   │   │   ├── favicon-16x16.png
│   │   │   │   │   │   ├── favicon-32x32.png
│   │   │   │   │   │   ├── favicon.ico
│   │   │   │   │   │   ├── HerbzHub-white.png
│   │   │   │   │   │   ├── herbzhub_icon_152030.png
│   │   │   │   │   │   ├── herbzhub_login_bg.jpg
│   │   │   │   │   │   ├── herbzhub_pro.png
│   │   │   │   │   │   ├── herbzhub_text_152030.png
│   │   │   │   │   │   ├── serial-num-verification-icon.png
│   │   │   │   ├── components/
│   │   │   │   │   ├── Button.js
│   │   │   │   │   ├── CompletionStep.js
│   │   │   │   │   ├── CountyForm.js
│   │   │   │   │   ├── CredentialsForm.js
│   │   │   │   │   ├── Footer.js
│   │   │   │   │   ├── index.js
│   │   │   │   │   ├── InputField.js
│   │   │   │   │   ├── LicensingForm.js
│   │   │   │   │   ├── LoadingPage.js
│   │   │   │   │   ├── Logo.js
│   │   │   │   │   ├── Map.js
│   │   │   │   │   ├── OrganizationForm.js
│   │   │   │   │   ├── OrganizationTypeForm.js
│   │   │   │   │   ├── PocForm.js
│   │   │   │   │   ├── proSidebar.js
│   │   │   │   │   ├── ReviewStep.js
│   │   │   │   │   ├── SerialNumberForm.js
│   │   │   │   ├── schemas/
│   │   │   │   │   ├── index.js
│   │   │   │   ├── services/
│   │   │   │   │   ├── constant.js
│   │   │   │   │   ├── auth/
│   │   │   │   │   │   ├── index.js
│   │   │   │   │   ├── counties/
│   │   │   │   │   │   ├── index.js
│   │   │   │   │   ├── organizationType/
│   │   │   │   │   │   ├── index.js
│   │   │   │   │   ├── states/
│   │   │   │   │   │   ├── index.js
│   │   │   │   ├── styles/
│   │   │   │   │   ├── auth.css
│   │   │   │   │   ├── dashboard.css
│   │   │   │   │   ├── index.css
│   │   │   │   │   ├── onboarding.css
│   │   │   │   │   ├── sidebar.css
│   │   │   │   ├── utils/
│   │   │   │   │   ├── googleMaps.js
│   │   │   │   │   ├── helper.js
│   │   │   │   │   ├── constant/
│   │   │   │   │   │   ├── index.js
│   │   │   │   │   ├── customHooks/
│   │   │   │   │   │   ├── use-ngProgress.js
│   │   │   │   ├── views/
│   │   │   │   │   ├── 404.js
│   │   │   │   │   ├── App.js
│   │   │   │   │   ├── pages/
│   │   │   │   │   │   ├── proDashboard.js
│   │   │   │   │   │   ├── auth/
│   │   │   │   │   │   │   ├── onboarding.js
│   │   │   │   │   │   │   ├── onboardingCompleted.js
│   │   │   │   │   │   │   ├── resetPassword.js
│   │   │   │   │   │   │   ├── SignIn.js
│   ├── hhos/
│   │   ├── cli.py
│   │   ├── main.py
│   │   ├── requirements.txt
│   │   ├── app/
│   │   │   ├── __init__.py
│   │   │   ├── api/
│   │   │   │   ├── __init__.py
│   │   │   │   ├── endpoints/
│   │   │   │   │   ├── bag.py
│   │   │   │   │   ├── box.py
│   │   │   │   │   ├── cam.py
│   │   │   │   │   ├── lock.py
│   │   │   │   │   ├── __init__.py
│   │   │   ├── cli/
│   │   │   │   ├── bag.py
│   │   │   │   ├── box.py
│   │   │   │   ├── cam.py
│   │   │   │   ├── lock.py
│   │   │   │   ├── setup.py
│   │   │   │   ├── __init__.py
│   │   │   ├── core/
│   │   │   │   ├── config.py
│   │   │   │   ├── __init__.py
│   │   │   ├── models/
│   │   │   │   ├── devices.py
│   │   │   │   ├── __init__.py
│   │   │   ├── services/
│   │   │   │   ├── bag_service.py
│   │   │   │   ├── box_service.py
│   │   │   │   ├── cam_service.py
│   │   │   │   ├── lock_service.py
│   │   │   │   ├── __init__.py
│   │   │   ├── utils/
│   │   │   │   ├── gps.py
│   │   │   │   ├── __init__.py
│   │   ├── tests/
│   │   │   ├── test_bag.py
│   │   │   ├── test_box.py
│   │   │   ├── test_cam.py
│   │   │   ├── test_lock.py
│   │   │   ├── __init__.py
