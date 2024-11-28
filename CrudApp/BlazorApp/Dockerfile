# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy the project file(s) and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . ./

# Build the application
RUN dotnet publish -c Release -o /out

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Copy the published files from the build stage
COPY --from=build /out .

# Expose the port Blazor Server uses
EXPOSE 5000

# Start the application
ENTRYPOINT ["dotnet", "YourBlazorApp.dll"]
