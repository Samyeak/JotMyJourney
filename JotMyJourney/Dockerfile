#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["JotMyJourney/JotMyJourney.csproj", "JotMyJourney/"]
RUN dotnet restore "JotMyJourney/JotMyJourney.csproj"
COPY . .
WORKDIR "/src/JotMyJourney"
RUN dotnet build "JotMyJourney.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JotMyJourney.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JotMyJourney.dll"]