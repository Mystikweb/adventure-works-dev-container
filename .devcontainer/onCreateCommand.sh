#!/bin/bash

# Run the container configuration scripts
echo "Configuring the .NET SDK"
bash .devcontainer/workspace/configureDotnet.sh

echo "Installing the ASP.NET Core Dev certificate"
bash .devcontainer/workspace/setupDotnetDevCert.sh
