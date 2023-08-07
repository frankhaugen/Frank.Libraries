param (
    [Parameter(Mandatory=$false)]
    [ValidateSet('Debug', 'Release')]
    [string]$configuration = 'Debug'
)

# Get the current date and time
$date = Get-Date -Format 'yyyy.MM.dd.HHmmss'
$publishDir = "./.artifacts/publish"
$packageDir = "./.artifacts/packages"
$tempSln = "./temp.sln"
$solution = "./Frank.Libraries.sln"

# Generate a temporary solution file
Copy-Item $solution -Destination $tempSln

# Get all test projects and the "TestingInfrastructure" project
$testProjects = Get-ChildItem -Path . -Filter *.csproj -Recurse | Where-Object {$_.FullName.Contains(".Tests") -or $_.FullName.Contains("TestingInfrastructure")}

# Remove all test projects from the temporary solution
foreach ($project in $testProjects) {
    Write-Host "Removing $($project.FullName) from the solution..." -ForegroundColor DarkCyan
    dotnet sln $tempSln remove $project.FullName
}

# Clean output directories
if (Test-Path $publishDir) { Remove-Item "$publishDir/*" -Recurse }
if (Test-Path $packageDir) { Remove-Item "$packageDir/*" -Recurse }

# Build the solution in the specified mode
Write-Host "Building solution in $configuration mode with version $date..." -ForegroundColor DarkCyan
dotnet build $tempSln --configuration $configuration /p:Version=$date
Write-Host "Build in $configuration mode completed." -ForegroundColor Green

# Publish the solution and pack nugets
Write-Host "Publishing the solution..." -ForegroundColor DarkCyan
dotnet publish $tempSln --configuration $configuration --output $publishDir /p:Version=$date
Write-Host "Solution has been published." -ForegroundColor Green

Write-Host "Packing NuGet packages..." -ForegroundColor DarkCyan
dotnet pack $tempSln --configuration $configuration --output $packageDir /p:Version=$date
Write-Host "NuGet packages have been packed." -ForegroundColor Green

# Delete the temporary solution file
Remove-Item $tempSln

# Exit with a success code
exit 0