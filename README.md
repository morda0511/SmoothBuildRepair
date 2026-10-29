![Smooth Build Repair - Quiet auto-repair](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/smooth-build-repair-banner.png)

<br>

**Your base repairs itself. A few pieces at a time, so the game never stutters.**

Damaged building pieces around you are repaired quietly in the background. No effects, no material cost, no lag spikes.

> **Client side only, no server install needed.** Valheim 1.0 · BepInExPack 5.4.2350+

[Bug reports](https://github.com/morda0511/SmoothBuildRepair/issues) · [Discord](https://discord.gg/9bD8sSdvX)

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/dividers/divider-at-a-glance.png)

| ![Repair](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/icon-repair-160.png) | ![Quiet](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/icon-quiet-160.png) | ![Radius](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/icon-radius-160.png) | ![Wards](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/icon-wards-160.png) |
|:---:|:---:|:---:|:---:|
| **Repair**<br>Damaged pieces around you are fixed by themselves | **Quiet**<br>A few pieces per second, no effects, no lag | **Radius**<br>Everything within **50 m** of you | **Wards**<br>Foreign wards are respected |

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/dividers/divider-smooth-build-repair.png)

### How it works
- Repairs damaged building pieces within a radius around you (default **50 m**)
- Works in small steps: **1 to 50** pieces per step (default 2), one step per second, so there is no lag
- Uses the piece list the game already keeps, no extra scanning
- No particle or sound effects when repairing, and it costs no materials
- Skips pieces inside foreign wards (switch it off if you want)
- Pauses while an enemy is within 40 m, so raids and fights never stutter

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/dividers/divider-config.png)

The file is `BepInEx/config/morda.SmoothBuildRepair.cfg`.

| Setting | Default | What it does |
|:---|:---|:---|
| **Enabled** | true | Auto-repair on / off |
| **Radius** | 50 | Repair radius in meters |
| **Interval** | 1 | Seconds between repair steps |
| **PiecesPerStep** | 2 | Pieces repaired per step (1-50). Raise it slowly if you want it faster |
| **RespectWards** | true | Do not repair inside foreign wards |
| **PauseNearEnemies** | true | Pause repairing while an enemy is close, so fights and raids stay smooth |
| **EnemyRadius** | 40 | Distance in meters at which an enemy pauses repairing |

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/dividers/divider-more-mods-by-morda.png)

| [![Store and Craft](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-storeandcraft-160.png)](https://thunderstore.io/c/valheim/p/Morda/StoreAndCraft/) | [![Workbenches+](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-workbenches-192.png)](https://thunderstore.io/c/valheim/p/Morda/WorkbenchesPlus/) | [![Forager's Garden](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-foragers-192.png)](https://thunderstore.io/c/valheim/p/Morda/ForagersGarden/) | [![Morda's Gearhold](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-gearhold-192.png)](https://thunderstore.io/c/valheim/p/Morda/MordasGearhold/) |
|:---:|:---:|:---:|:---:|
| **[Store and Craft](https://thunderstore.io/c/valheim/p/Morda/StoreAndCraft/)** | **[Workbenches+](https://thunderstore.io/c/valheim/p/Morda/WorkbenchesPlus/)** | **[Forager's Garden](https://thunderstore.io/c/valheim/p/Morda/ForagersGarden/)** | **[Morda's Gearhold](https://thunderstore.io/c/valheim/p/Morda/MordasGearhold/)** |

| [![Valheim Mannequins](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-mannequins-192.png)](https://thunderstore.io/c/valheim/p/Morda/ValheimMannequins/) | [![ServerRates](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-serverrates-192.png)](https://thunderstore.io/c/valheim/p/Morda/ServerRates/) | [![Any Angle](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-anyangle-192.png)](https://thunderstore.io/c/valheim/p/Morda/AnyAngle/) | [![Easy Build Cam](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/logo-easybuildcam-192.png)](https://thunderstore.io/c/valheim/p/Morda/EasyBuildCam/) |
|:---:|:---:|:---:|:---:|
| **[Valheim Mannequins](https://thunderstore.io/c/valheim/p/Morda/ValheimMannequins/)** | **[ServerRates](https://thunderstore.io/c/valheim/p/Morda/ServerRates/)** | **[Any Angle](https://thunderstore.io/c/valheim/p/Morda/AnyAngle/)** | **[Easy Build Cam](https://thunderstore.io/c/valheim/p/Morda/EasyBuildCam/)** |

![](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/dividers/divider-install.png)

1. Install [BepInExPack Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)
2. Put `SmoothBuildRepair.dll` in `BepInEx/plugins/SmoothBuildRepair/` (or use Thunderstore / r2modman)
3. Client side: no install on the server needed

![Smooth Build Repair](https://raw.githubusercontent.com/morda0511/SmoothBuildRepair/main/thunderstore-assets/smooth-build-repair/smooth-build-repair-footer.png)

## Build

```
dotnet build -c Release -p:ValheimDir="C:\path\to\Valheim"
```
