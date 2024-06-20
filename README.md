# FMOD For Unity

This package is dependent on the FMOD Unity Integration plugin so be sure to install it before using this.
You can find the plugin here: [https://www.fmod.com/unity](https://www.fmod.com/unity)

I wish I could simply include it as a dependency in the manifest so it's automatically installed for you but that is not currently possible.
As a workaround, I've referenced the relevant assemblies by name instead of GUID which could cause conflicts if you've got assemblies with the same name.
If for whatever reason this does not work, please ensure the following assembly references are maintained:
- `Packages/FMOD Parameters/Runtime/WinterwireGames.FMODParameters.asdef` should reference the following:
  - `Assets/Plugins/FMOD/FMODUnity.asdef`
