param (
    [Parameter(Mandatory=$false)]
    [ValidateSet('Debug', 'Release')]
    [string]$configuration = 'Debug',
    [Parameter(Mandatory=$false)]
    [string]$version = (Get-Date -Format 'yyyy.MM.dd'),
    [Parameter(Mandatory=$false)]
    [string]$build = (Get-Date -Format 'HHmmss'),
    [Parameter(Mandatory=$false)]
    [string]$versionSuffix = ''
)

function RemoveProjectsFromSolution ($solutionPath, $projectsToRemove) {
    Write-Host "Removing projects from solution:" -ForegroundColor DarkCyan
    foreach ($project in $projectsToRemove) {
        Write-Host "    $($project.Name)" -ForegroundColor DarkCyan
        dotnet sln $solutionPath remove $project.FullName | Out-Null
    }
}

$version = "$version.$build"

$publishDir = "./.artifacts/publish"
$packageDir = "./.artifacts/packages"
$tempSln = "./temp.sln"
$solution = "./Frank.Libraries.sln"

# Generate a temporary solution file
Copy-Item $solution -Destination $tempSln

# Get all test projects and the "TestingInfrastructure" project
$testProjects = Get-ChildItem -Path . -Filter *.csproj -Recurse | Where-Object {$_.FullName.Contains(".Tests") -or $_.FullName.Contains("TestingInfrastructure")}

# Remove all test projects from the temporary solution
RemoveProjectsFromSolution -solutionPath $tempSln -projectsToRemove $testProjects

# Clean output directories
if (Test-Path $publishDir) { Remove-Item "$publishDir/*" -Recurse }
if (Test-Path $packageDir) { Remove-Item "$packageDir/*" -Recurse }

# Build the solution in the specified mode
Write-Host "Building solution in $configuration mode with version $version$versionSuffix..." -ForegroundColor DarkCyan
dotnet build $tempSln --configuration $configuration /p:Version=$version | Out-Null
Write-Host "Build in $configuration mode completed." -ForegroundColor Green

# Publish the solution and pack nugets
Write-Host "Publishing the solution..." -ForegroundColor DarkCyan
dotnet publish $tempSln --configuration $configuration --output $publishDir /p:Version=$version /p:PackageVersion=$version$versionSuffix | Out-Null
Write-Host "Solution has been published." -ForegroundColor Green

# Pack NuGet packages
Write-Host "Packing NuGet packages..." -ForegroundColor DarkCyan
dotnet pack $tempSln --configuration $configuration --output $packageDir /p:Version=$version /p:PackageVersion=$version$versionSuffix | Out-Null
Write-Host "NuGet packages have been packed." -ForegroundColor Green

# Delete the temporary solution file
Remove-Item $tempSln

# Exit with a success code
exit 0