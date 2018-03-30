# AngularASPNETCore2WebApiAuth

## References
https://fullstackmark.com/post/13/jwt-authentication-with-aspnet-core-2-web-api-angular-5-net-core-identity-and-facebook-login

## Development Environment
- SQL Server Developer Edition 2017
- Visual Studio Code
- Node 8.9.4 & NPM 5.6.0
- .NET Core 2.1 Preview SDK
- Angular CLI -> `npm install -g @angular/cli`

## Setup
To build and run the project using the command line:
1. Install npm packages with `npm install` in the `src` directory.
2. Restore nuget packages with `dotnet restore` in the `src` directory.
3. Create the database with `dotnet ef database update` in the `src` directory.
4. Run the project with `dotnet run` in the `src` directory.
5. Point your browser to **https://localhost:5001**.

N.B: If using Postman to hit the WebAPI endpoints, make sure to disable SSL Certificate Validation in Setting or you will see no response back from the endpoint.