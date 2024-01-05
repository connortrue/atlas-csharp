#!/bin/bash

# Create the directory if it doesn't exist
mkdir -p 1-new_project

# Navigate into the directory
cd 1-new_project

# Initialize a new C# console application
dotnet new console

# Build the project
dotnet build
