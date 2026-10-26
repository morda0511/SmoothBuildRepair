# SmoothBuildRepair

Valheim BepInEx mod that automatically repairs damaged building pieces around you - a few at a time, so there is no lag. No effects, no cost.

## Config (`BepInEx/config/morda.SmoothBuildRepair.cfg`)
- `Enabled`: on/off
- `Radius`: repair radius in meters (default 50)
- `Interval`: seconds between repair steps (default 1)
- `PiecesPerStep`: pieces repaired per step, 1-50 (default 2)
- `RespectWards`: skip pieces inside foreign wards (default true)

Client-side only, not needed on the server.

## Build
```
dotnet build -c Release -p:ValheimDir="C:\path\to\Valheim"
```
