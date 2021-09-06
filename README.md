# VowelUtilty

`VowelUtility` is a library used for counting vowels and various other vowel related operations.

_This repository was created to explore how the .NET C# development ecosystem looks like._

## Notes
* `dotnet build --configuration release`, builds and packs since `GeneratePackageOnBuild` is set to true in `csproj`
* `dotnet pack --configuration release`
* `dotnet 
* The API key at nuget.org need `unlist` package permissions if you want to be able to delete a package using:
```
dotnet nuget delete VowelUtility 0.1.0 --api-key <KEY> -s https://api.nuget.org/v3/index.json
```