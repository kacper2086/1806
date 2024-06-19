# Pobierz obraz .NET runtime jako obraz bazowy do uruchamiania aplikacji
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5157

# Pobierz obraz .NET SDK jako obraz bazowy do budowania aplikacji
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["1806/1806.csproj", "1806/"]
RUN dotnet restore "./1806/1806.csproj"
COPY . .
WORKDIR "/src/1806"
RUN dotnet build "./1806.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Opublikuj aplikację
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./1806.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Użyj obrazu runtime jako finalnego obrazu
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Ustaw zmienną środowiskową, aby aplikacja nasłuchiwała na porcie 5157
ENV ASPNETCORE_URLS=http://+:5157

# Zdefiniuj polecenie startowe
ENTRYPOINT ["dotnet", "1806.dll"]
