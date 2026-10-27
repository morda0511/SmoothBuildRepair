![Smooth Build Repair - Quiet auto-repair](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/smooth-build-repair-banner.png)

<br>

**Your base repairs itself. A few pieces at a time, so the game never stutters.**

Damaged building pieces around you are repaired quietly in the background. No effects, no material cost, no lag spikes.

> **Client-side only. Not needed on the server.** Valheim 1.0 · BepInExPack 5.4.2350+

[Bug reports](https://github.com/morda0511/SmoothBuildRepair/issues) · [Discord](https://discord.gg/9bD8sSdvX)

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/divider-norse.png)

## What it does

- Repairs damaged building pieces within a radius around you (default **50 m**)
- Works in small steps: **1 to 50** pieces per step (default 2), one step per second, so there is no lag
- Uses the piece list the game already keeps, no extra scanning
- No particle or sound effects when repairing
- Free: repairing costs no materials
- Skips pieces inside foreign wards (switch it off if you want)

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/divider-norse.png)

## Config

`BepInEx/config/morda.SmoothBuildRepair.cfg`

| Setting | Default | What it does |
|:---|:---|:---|
| **Enabled** | true | Auto-repair on/off |
| **Radius** | 50 | Repair radius in meters |
| **Interval** | 1 | Seconds between repair steps |
| **PiecesPerStep** | 2 | Pieces repaired per step (1-50). Raise it slowly if you want it faster |
| **RespectWards** | true | Do not repair inside foreign wards |

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/divider-norse.png)

## More mods by Morda

| Mod | What it does |
|:---|:---|
| **[StoreAndCraft](https://thunderstore.io/c/valheim/p/Morda/StoreAndCraft/)** | Auto-store drops, dump inventory, craft and build from nearby chests, storage displays, scarecrow |
| **[AnyAngle](https://thunderstore.io/c/valheim/p/Morda/AnyAngle/)** | Move and rotate the build preview on every axis before placing, even into the ground |
| **[WorkbenchesPlus](https://thunderstore.io/c/valheim/p/Morda/WorkbenchesPlus/)** | Sort and filter crafting menus: craftable first, categories, armor and weapon sets by biome tier |
| **[Forager's Garden](https://thunderstore.io/c/valheim/p/Morda/ForagersGarden/)** | Berry bushes, wild herbs and mushrooms with the Cultivator, plus Ice, Royal Jelly and Crystal beehives |
| **[Morda's Gearhold](https://thunderstore.io/c/valheim/p/Morda/MordasGearhold/)** | Three switchable equipment sets, shared inventory, quickslots, ammo slots, trinkets, transmog looks, armour dyes |
| **[Valheim Mannequins](https://thunderstore.io/c/valheim/p/Morda/ValheimMannequins/)** | Player-shaped mannequins: dress them with real gear, pose and name them, keep several gear sets |
| **[ServerRates](https://thunderstore.io/c/valheim/p/Morda/ServerRates/)** | Server-side rates for dedicated servers (PC and console), live apply, presets |

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/divider-norse.png)

## Install

1. Install [BepInExPack Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)
2. Put `SmoothBuildRepair.dll` in `BepInEx/plugins/SmoothBuildRepair/` (or use Thunderstore / r2modman)

## Build

```
dotnet build -c Release -p:ValheimDir="C:\path\to\Valheim"
```

![Misty valley](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/smooth-build-repair-footer.png)
