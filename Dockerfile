# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy everything and restore
COPY . .
RUN dotnet restore "RubCubeBack.slnx"

# Build and publish
RUN dotnet publish "RubCubeBack/RubCubeBack.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage (É AQUI QUE A LIB PRECISA ESTAR)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

# Instala a biblioteca necessária para a execução
RUN apt-get update && apt-get install -y \
    libgssapi-krb5-2 \
    && rm -rf /var/lib/apt/lists/*

# Copy published output
COPY --from=build /app/publish ./

# Environment
ENV ASPNETCORE_URLS="http://+:80"
EXPOSE 80

ENTRYPOINT ["dotnet", "RubCubeBack.dll"]