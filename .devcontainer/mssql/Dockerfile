# Create downloader stage
FROM alpine:latest AS downloader

# Install curl
RUN apk add --no-cache curl

# Create a work directory
RUN mkdir -p /work
WORKDIR /work

# Download the AdventureWorks backup
RUN curl -L -o AdventureWorks2022.bak "https://github.com/Microsoft/sql-server-samples/releases/download/adventureworks/AdventureWorks2022.bak"

# Create the SQL Server container
FROM mcr.microsoft.com/mssql/server:2022-latest

RUN mkdir -p /var/opt/mssql/backup

# Copy the backup file from the downloader stage
COPY --chown=mssql:mssql --from=downloader /work/AdventureWorks2022.bak /var/opt/mssql/backup

# Set the entrypoint script
ENTRYPOINT ["/opt/mssql/bin/sqlservr"]