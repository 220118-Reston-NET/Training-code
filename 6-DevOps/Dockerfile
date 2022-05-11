from mcr.microsoft.com/dotnet/sdk:latest as build

workdir /app

copy Console/*.csproj Console/
copy Console/*.cs Console/

run dotnet publish -c Release -o publish

cmd ["dotnet", "Console.dll"]