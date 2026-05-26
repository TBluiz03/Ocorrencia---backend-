#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SOSBackClean.API/SOSBackClean.API.csproj", "SOSBackClean.API/"]
COPY ["SOSBackClean.Infra.IoC/SOSBackClean.Infra.IoC.csproj", "SOSBackClean.Infra.IoC/"]
COPY ["SOSBackClean.Application/SOSBackClean.Application.csproj", "SOSBackClean.Application/"]
COPY ["SOSBackClean.Domain/SOSBackClean.Domain.csproj", "SOSBackClean.Domain/"]
COPY ["SOSBackClean.Data/SOSBackClean.Data.csproj", "SOSBackClean.Data/"]
RUN dotnet restore "./SOSBackClean.API/SOSBackClean.API.csproj"
COPY . .
WORKDIR "/src/SOSBackClean.API"
RUN dotnet build "./SOSBackClean.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SOSBackClean.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SOSBackClean.API.dll"]