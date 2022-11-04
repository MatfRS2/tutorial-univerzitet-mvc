#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Moj Univerzitet/Moj Univerzitet.csproj", "Moj Univerzitet/"]
RUN dotnet restore "Moj Univerzitet/Moj Univerzitet.csproj"
COPY . .
WORKDIR "/src/Moj Univerzitet"
RUN dotnet build "Moj Univerzitet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Moj Univerzitet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Moj Univerzitet.dll"]