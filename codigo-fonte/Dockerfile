FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BrechoLaFripAtelier/BrechoLaFripAtelier.csproj", "BrechoLaFripAtelier/"]
RUN dotnet restore "BrechoLaFripAtelier/BrechoLaFripAtelier.csproj"
COPY . .
WORKDIR "/src/BrechoLaFripAtelier"
RUN dotnet build "BrechoLaFripAtelier.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BrechoLaFripAtelier.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
ENV ASPNETCORE_ENVIRONMENT Production
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BrechoLaFripAtelier.dll"]