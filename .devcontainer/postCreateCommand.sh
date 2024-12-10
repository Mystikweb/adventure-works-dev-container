#!/bin/bash

# Load SA_PASSWORD from .env file
export $(grep -v '^#' .devcontainer/.env | xargs)
SAPassword=$MSSQL_SA_PASSWORD

# Run the database restore script
bash .devcontainer/mssql/configure-db.sh $SAPassword

# Update the SDK workloads
sudo dotnet workload update

# Add in the dotnet EF tool to the path
dotnet tool install --global dotnet-ef
