#!/bin/bash

# Change ownership of the .dotnet directory to the vscode user (to avoid permission errors)
sudo chown -R vscode:vscode /home/vscode/.dotnet
sudo chown -R vscode:vscode /home/vscode/.dotnet/tools
sudo chown -R vscode:vscode /home/vscode/.microsoft

# Update the SDK workloads
sudo dotnet workload update

# Add the dotnet EF tool to the path
dotnet tool install --global dotnet-ef