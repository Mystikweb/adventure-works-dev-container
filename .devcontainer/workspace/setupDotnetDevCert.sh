#!/bin/bash

# If there is no development certificate, this command will generate a new one
dotnet dev-certs https

# Export the ASP.NET Core HTTPS development certificate to a PEM file
sudo -E dotnet dev-certs https --export-path /usr/local/share/ca-certificates/dotnet-dev-cert.crt --format pem

# Add the PEM file to the trust store
sudo update-ca-certificates