# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY *.sln ./
COPY PORTFOLIO-BACKEND-DOTNET-MASTER/*.csproj  PORTFOLIO-BACKEND-DOTNET-MASTER/
RUN dotnet restore

# Copy the rest of the application code
COPY . ./
RUN dotnet publish  PORTFOLIO-BACKEND-DOTNET-MASTER/portfolio.csproj -c Release -o out

# Use the official ASP.NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "portfolio.dll"]