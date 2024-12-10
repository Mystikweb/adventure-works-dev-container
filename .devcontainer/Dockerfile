FROM mcr.microsoft.com/devcontainers/dotnet:1-9.0-bookworm

# Add .NET global tools path
ENV PATH $PATH:/home/vscode/.dotnet:/home/vscode/.dotnet/tools

# Install additional OS packages.
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends software-properties-common

# Install SQL Tools: SQLPackage and sqlcmd
COPY mssql/installSQLtools.sh installSQLtools.sh
RUN bash ./installSQLtools.sh \
     && apt-get clean -y \
     && rm -rf /var/lib/apt/lists/* /tmp/library-scripts
