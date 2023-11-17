# .NET Web API Template


``` powershell
# Install template locally using:
dotnet new install ./content

# Reinstall template locally using:
dotnet new install ./content --force

# Pack template
./nuget.exe pack template.nuspec -OutputDirectory ./dist -NoDefaultExcludes

# Publish template
./nuget.exe push .\dist\Taro.Net.Web.Api.Template.1.0.2.nupkg -ApiKey <YOUR_API_KEY> -Source https://api.nuget.org/v3/index.json

# Install from nuget:
dotnet new install Taro.Net.Web.Api.Template
```