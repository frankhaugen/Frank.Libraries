# Define the project path from the directory of this script
$projectPath = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition

# Change directory to the project directory
Set-Location -Path $projectPath

# Build the project in Release configuration
dotnet build --configuration Release

# Run the benchmark in Release configuration
dotnet run --configuration Release --framework net7.0 --filter '*' --no-build --no-restore --verbosity normal