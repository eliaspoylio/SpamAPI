#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/runtime:5.0 AS build
WORKDIR /src
COPY ["SpamAPI/SpamAPI.csproj", "SpamAPI/"]
RUN dotnet restore "SpamAPI/SpamAPI.csproj"
COPY . .
WORKDIR "/src/SpamAPI"
RUN dotnet build "SpamAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SpamAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SpamAPI.dll"]