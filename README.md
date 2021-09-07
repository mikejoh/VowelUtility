# VowelUtilty

`VowelUtility` is a library used for counting vowels and various other vowel related operations.

_This repository was created to explore how the .NET C# development ecosystem looks like._

## Notes
Pre-req (running on Ubuntu 21.04+):
* Install the Microsoft package signing keys and repositories:
```
wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
```
* Install .NET SDK (5.0):
```
sudo apt install -y dotnet-sdk-5.0
```
* Install `mono` and the `nuget` tool:
```
sudo apt install -y mono-complete
wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
chmod 755 nuget.exe
```
Add command alias for `mono nuget.exe`.

Using the `dotnet` tool:
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

Using the `nuget` tool:
* `nuget spec`, generate a `nuspec` manifest
* `nuget pack <nuspec>` generate a `nupkg` zip file containing all assemblies and other related files
* `nuget push <nupkg> <API key> -src https://api.nuget.org/v3/index.json`