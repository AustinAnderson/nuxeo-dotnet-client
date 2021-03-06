### settings
$relativeNuxeoClientFolderPath = "../"
###

$homeDir = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
$nuxeoClientFolder = [IO.Path]::GetFullPath((Join-Path $homeDir $relativeNuxeoClientFolderPath))
$nuxeoClientTck = Join-Path $nuxeoClientFolder test/TCK

cd $nuxeoClientTck

Write-Host "Building Nuxeo Client TCK (netcore1)" -ForegroundColor Yellow
dotnet restore --no-cache -s https://www.myget.org/F/aspnetvnext/ -f https://www.nuget.org/api/v2/
dotnet build --configuration Release


if ($LASTEXITCODE -ne 0)
{
    Write-Host "Nuxeo Client TCK (netcore1) build failed" -ForegroundColor Red
    cd $homeDir
    Exit 1
}
else
{
    Write-Host "Nuxeo Client TCK (netcore1) build succeeded" -ForegroundColor Green
}

Write-Host "Running Nuxeo Client TCK (netcore1)" -ForegroundColor Yellow
dotnet test -xml ../../tools/TestResultsNetCore.xml -parallel none

if ($LASTEXITCODE -ne 0)
{
    Write-Host "Nuxeo Client TCK (netcore1) failed" -ForegroundColor Red
    cd $homeDir
    Exit 1
}
else
{
    Write-Host "Nuxeo Client TCK (netcore1) passed" -ForegroundColor Green
    cd $homeDir
    Exit 0
}
