#!/bin/bash

# Load SA_PASSWORD from .env file
export $(grep -v '^#' .devcontainer/.env | xargs)
SAPassword=$MSSQL_SA_PASSWORD

bash .devcontainer/mssql/configure-db.sh $SAPassword