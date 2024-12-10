#!/bin/bash

# Load SA_PASSWORD from .env file
export $(grep -v '^#' .devcontainer/.env | xargs)
SAPassword=$MSSQL_SA_PASSWORD

# Run the database restore script
bash .devcontainer/mssql/configureDb.sh $SAPassword
