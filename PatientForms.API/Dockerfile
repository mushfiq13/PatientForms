FROM alpine AS base
    # Metadata
    LABEL org.opencontainers.image.title="Patient Portal" \
        org.opencontainers.image.description="Web API server" \
        org.opencontainers.image.authors="@mushfiq4513"

    # Create directory in container image for src code
    RUN mkdir -p /usr/src    
    # Install .NET 8 runtime
    RUN apk add aspnetcore8-runtime

    # Set environment
    # ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
    COPY PatientPortal.Domain/*.csproj /usr/src/PatientPortal.Domain/
    COPY PatientPortal.EF/*.csproj /usr/src/PatientPortal.EF/
    COPY PatientPortal.API/*.csproj /usr/src/PatientPortal.API/
    
    RUN dotnet restore "/usr/src/PatientPortal.API/PatientPortal.API.csproj"
    
    # Copy all the files and subdirectories.
    # Copy src code (.) to /usr/src in container image.
    COPY . /usr/src
    
    # Set working directory context
    WORKDIR /usr/src/PatientPortal.API/

    RUN dotnet build "PatientPortal.API.csproj" -c Release -o /app/build

FROM build AS publish
    RUN dotnet publish "PatientPortal.API.csproj" -c Release -o /app/publish

FROM base AS final
    WORKDIR /app
    COPY --from=publish /app/publish .
    # Command for container to execute
    ENTRYPOINT [ "dotnet", "PatientPortal.API.dll" ]
