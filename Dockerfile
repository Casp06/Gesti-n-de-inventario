# ====================================================================
# ETAPA 1: BUILD (Compilar y Publicar la aplicación)
# ====================================================================
# Usamos la imagen SDK para compilar
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia los archivos de proyecto (csproj/sln) y restaura las dependencias
# Esto optimiza el caché de Docker si solo cambian los archivos de código
COPY ["tarea3.csproj", "."]
RUN dotnet restore "tarea3.csproj"

# Copia todo el código fuente del proyecto
COPY . .

# Publica la aplicación, lista para ser ejecutada
RUN dotnet publish "tarea3.csproj" -c Release -o /app/publish --no-restore

# ====================================================================
# ETAPA 2: FINAL (Ejecución)
# ====================================================================
# Usamos la imagen ASP.NET Runtime (mucho más ligera que la SDK)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Exponemos el puerto 8080, que es el puerto predeterminado que Render usa
# para los contenedores (aunque Blazor por defecto usa 80, Render lo mapea)
EXPOSE 8080

# Copia los archivos publicados desde la etapa de 'build'
COPY --from=build /app/publish .

# Define el punto de entrada para ejecutar la aplicación
# Render usará esto para iniciar tu Blazor Server App
ENTRYPOINT ["dotnet", "tarea3.dll"]