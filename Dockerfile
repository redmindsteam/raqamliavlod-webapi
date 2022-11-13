FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY src/ .
RUN dotnet restore "RaqamliAvlod.Api/RaqamliAvlod.Api.csproj"
WORKDIR "/src/RaqamliAvlod.Api"
RUN dotnet build "RaqamliAvlod.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RaqamliAvlod.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "RaqamliAvlod.Api.dll"]
