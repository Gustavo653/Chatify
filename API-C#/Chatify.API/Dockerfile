FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
COPY ["Chatify.API/mediashow-394823-54ae513fb4ce.json", "."]
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Chatify.API/Chatify.API.csproj", "Chatify.API/"]
COPY ["Common.DTO/Common.DTO.csproj", "Common.DTO/"]
COPY ["Common.Functions/Common.Functions.csproj", "Common.Functions/"]
COPY ["Chatify.DTO/Chatify.DTO.csproj", "Chatify.DTO/"]
COPY ["Chatify.Domain/Chatify.Domain.csproj", "Chatify.Domain/"]
COPY ["Chatify.Persistence/Chatify.Persistence.csproj", "Chatify.Persistence/"]
COPY ["Chatify.Service/Chatify.Service.csproj", "Chatify.Service/"]
COPY ["Chatify.DataAccess/Chatify.DataAccess.csproj", "Chatify.DataAccess/"]
COPY ["Common.DataAccess/Common.DataAccess.csproj", "Common.DataAccess/"]
COPY ["Common.Infrastructure/Common.Infrastructure.csproj", "Common.Infrastructure/"]
RUN dotnet restore "Chatify.API/Chatify.API.csproj"
COPY . .
WORKDIR "/src/Chatify.API"
RUN dotnet build "Chatify.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chatify.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chatify.API.dll"]