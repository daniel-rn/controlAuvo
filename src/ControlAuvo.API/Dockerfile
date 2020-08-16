FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/ControlAuvo.API/ControlAuvo.API.csproj", "src/ControlAuvo.API/"]
RUN dotnet restore "src/ControlAuvo.API/ControlAuvo.API.csproj"
COPY . .
WORKDIR "/src/src/ControlAuvo.API"
RUN dotnet build "ControlAuvo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ControlAuvo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ControlAuvo.API.dll"]