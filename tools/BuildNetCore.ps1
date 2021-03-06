### settings
$relativeNuxeoClientFolderPath = "../"
###

$homeDir = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
$nuxeoClientFolder = [IO.Path]::GetFullPath((Join-Path $homeDir $relativeNuxeoClientFolderPath))
$nuxeoClientSrc = Join-Path $nuxeoClientFolder src/NuxeoClient

cd $nuxeoClientSrc

Write-Host "Building Nuxeo Client (netcore1)" -ForegroundColor Yellow
dotnet restore --no-cache -s https://www.myget.org/F/aspnetvnext/ -f https://www.nuget.org/api/v2/
dotnet build --configuration Release

if ($LASTEXITCODE -ne 0)
{
    Write-Host "Nuxeo Client (netcore1) build failed" -ForegroundColor Red
    cd $homeDir
    Exit 1
}
else
{
    Write-Host "Nuxeo Client (netcore1) build succeeded" -ForegroundColor Green
    cd $homeDir
    Exit 0
}
