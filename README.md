# WEMSharp

WEMSharp is a C# library used to convert Audiokinetic Wwise WEM files to OGG files.

This project was inspired by [ww2ogg](https://github.com/hcs64/ww2ogg).

## Usage
```csharp

WEMFile wem = new WEMFile("locationOfYourWemFile", yourDesiredPacketForcing);
wem.GenerateOGG("locationOfTheOggFile", "locationOfCodebooksToUse", inlineCodebooks, fullSetup);

```

* Packet Format Forcing
  * NoForcePacketFormat - Uses the original Mod Packet Format from the WEM file.
  * ForceModPackets     - Forces to modify the original packets.
  * ForceNoModPackets   - Forces to not modify the original packets.
  
* Inline Codebooks

Whether codebooks should be loaded from the WEM file.

If `false`, `codebooksLocation` must not be empty.
If `true`, `codebooksLocation` should be empty.

* Full Setup

Whether the setup packet should be copied from the WEM file.
