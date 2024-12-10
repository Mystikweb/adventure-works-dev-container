FROM mcr.microsoft.com/devcontainers/dotnet:dev-9.0-noble

# Create the user folder for the .NET tools
RUN mkdir -p /home/vscode/.dotnet
RUN mkdir -p /home/vscode/.dotnet/tools

# Add .NET global tools path
ENV PATH $PATH:/home/vscode/.dotnet:/home/vscode/.dotnet/tools

# Install additional OS packages.
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y upgrade \
    && apt-get -y install --no-install-recommends software-properties-common

# Install SQL Tools
COPY ./installSQLtools.sh installSQLtools.sh
RUN bash ./installSQLtools.sh \
     && apt-get clean -y \
     && rm -rf /var/lib/apt/lists/* /tmp/library-scripts
