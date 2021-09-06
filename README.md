# VowelUtilty

`VowelUtility` is a library used for counting vowels and various other vowel related operations.

_This repository was created to explore how the .NET C# development ecosystem looks like._

## Notes
* `dotnet build --configuration release`, builds and packs since `GeneratePackageOnBuild` is set to true in `csproj`
* `dotnet pack --configuration release`
* `dotnet nuget push bin/release/VowelUtility.0.1.0.nupkg --api-key <KEY> -s https://api.nuget.org/v3/index.json`
* `dotnet nuget delete VowelUtility 0.1.0 --api-key <KEY> -s https://api.nuget.org/v3/index.json`
* The fields in the `csproj` file is added to the `nuspec` file bundled within the `nupkg` during `dotnet pack/build`
* During `dotnet push` the `nuspec` file is accessible next to the `nupkg` here, probably sent and generated as it is when the `nupkg` zip file is created:
```
curl https://api.nuget.org/v3-flatcontainer/VowelUtility/0.1.0/VowelUtility.0.1.0.nupkg
curl https://api.nuget.org/v3-flatcontainer/VowelUtility/0.1.0/VowelUtility.nuspec
```