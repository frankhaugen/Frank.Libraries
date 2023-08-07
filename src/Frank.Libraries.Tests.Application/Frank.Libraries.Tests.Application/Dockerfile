FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Frank.Libraries.Tests.Application/Frank.Libraries.Tests.Application.csproj", "Frank.Libraries.Tests.Application/"]
RUN dotnet restore "Frank.Libraries.Tests.Application/Frank.Libraries.Tests.Application.csproj"
COPY . .
WORKDIR "/src/Frank.Libraries.Tests.Application"
RUN dotnet build "Frank.Libraries.Tests.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Frank.Libraries.Tests.Application.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Frank.Libraries.Tests.Application.dll"]
