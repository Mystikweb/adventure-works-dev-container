#!/bin/bash

SAPassword=$1

# Create the application connection string as a user secret
dotnet user-secrets set "ConnectionStrings:Application" "Server=localhost;Database=AdventureWorks2022;User Id=sa;Password=${SAPassword};MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;" --project src/AdventureWorksDevContainer.Host

echo "done"