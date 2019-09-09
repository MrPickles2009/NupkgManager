﻿﻿﻿﻿<img src="https://raw.githubusercontent.com/MrPickles2009/NupkgManager/master/Images/nupkgManagerLogo.png" height="128px">

# Nupkg Manager

<p align="center">
	<a href="https://github.com/MrPickles2009/NupkgManager" rel="nofollow">
		<img src="https://img.shields.io/badge/build-passing-brightgreen.svg" alt="Build Status">
	</a>
  <a href="https://marketplace.visualstudio.com/items?itemName=BrokenCapoDevelopment.nupkgmanager">
		<img src="https://img.shields.io/visual-studio-marketplace/v/BrokenCapoDevelopment.nupkgmanager.svg" alt="Visual Studio Marketplace version">
	</a>
  <a href="https://marketplace.visualstudio.com/items?itemName=BrokenCapoDevelopment.nupkgmanager">
		<img src="https://img.shields.io/visual-studio-marketplace/d/BrokenCapoDevelopment.nupkgmanager.svg" alt="downloads">
	</a>
  <a href="https://marketplace.visualstudio.com/items?itemName=BrokenCapoDevelopment.nupkgmanager">
		<img src="https://img.shields.io/visual-studio-marketplace/i/BrokenCapoDevelopment.nupkgmanager.svg" alt="installs">
	</a>
  <a href="https://github.com/MrPickles2009/NupkgManager/blob/master/LICENSE">
		<img src="https://img.shields.io/github/license/MrPickles2009/NupkgManager.svg" alt="license">
	</a>
</p>

This extension allows any developer to easily build new/updated versions of their NuGet packages and push them to nuget.org or any other custom repository.

## Features
1. **Build/Pack NuGet packages** using their .nuspec and project assembly info
2. **Auto increment version number** located in project assembly info
3. **Push built packages** to nuget.org or any other custom NuGet repository
4. **Store** last used API keys, default NuGet packages folder and NuGet repository servers

## To Use
1. Open Visual Studio and select Tools > Nupkg Manager

<img src="https://raw.githubusercontent.com/MrPickles2009/NupkgManager/master/Images/1.png" height="512px">

2. Select nuget projects you wish to build/pack and press 'Build'. Then select the desired packages you wish to push to the NuGet repository and press 'Push'

<img src="https://raw.githubusercontent.com/MrPickles2009/NupkgManager/master/Images/2.png" height="512px">

## Requirements
Visual Studio 2017 and above

## Release notes
**Version 1.1.2**
- Fixed build error by recognizing AssemblyVersion and AssemblyFileVersion if AssemblyInformationalVersion not present.
- Beta assembly versions (eg: `AssemblyVersion("2.2.1beta3")`) no longer crash extension.
- Fixed packages being deleted before they are pushed to server.

**Version 1.1.1**
- FolderBrowserDialog root folder is now MyComputer.

**Version 1.1.0**
- Added support for Visual Studio 2019.

**Version 1.0.0**
- First release.

## Download

[Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=BrokenCapoDevelopment.nupkgmanager)

## License

[GPL](LICENSE)





