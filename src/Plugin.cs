using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace SmoothBuildRepair
{
    [BepInPlugin(Guid, "SmoothBuildRepair", "1.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public const string Guid = "morda.SmoothBuildRepair";

        ConfigEntry<bool> isEnabled;
        ConfigEntry<float> radius;
        ConfigEntry<float> interval;
        ConfigEntry<int> perTick;
        ConfigEntry<bool> respectWards;
        ConfigEntry<bool> pauseNearEnemies;
        ConfigEntry<float> enemyRadius;

        float timer;

        void Awake()
        {
            isEnabled = Config.Bind("General", "Enabled", true, "Auto-repair on/off.");
            radius = Config.Bind("General", "Radius", 50f, "Repair radius around the player in meters.");
            interval = Config.Bind("General", "Interval", 1.0f, "Seconds between repair steps.");
            perTick = Config.Bind("General", "PiecesPerStep", 2, new ConfigDescription(
                "Pieces repaired per step (1-50). Keeps lag away.", new AcceptableValueRange<int>(1, 50)));
            respectWards = Config.Bind("General", "RespectWards", true, "Do not repair inside foreign wards.");
            pauseNearEnemies = Config.Bind("General", "PauseNearEnemies", true, "Pause repairing while an enemy is close, so combat and raids stay smooth.");
            enemyRadius = Config.Bind("General", "EnemyRadius", 40f, "Distance in meters at which an enemy pauses repairing.");
        }

        void Update()
        {
            if (!isEnabled.Value) return;
            timer += Time.deltaTime;
            if (timer < interval.Value) return;
            timer = 0f;

            var player = Player.m_localPlayer;
            if (player == null || player.IsDead()) return;

            if (pauseNearEnemies.Value && EnemyNear(player)) return;

            Vector3 origin = player.transform.position;
            float r2 = radius.Value * radius.Value;
            int left = Mathf.Clamp(perTick.Value, 1, 50);

            // Instance list is already maintained by the game: no physics scan needed.
            var all = WearNTear.GetAllInstances();
            for (int i = 0; i < all.Count && left > 0; i++)
            {
                var wnt = all[i];
                if (wnt == null) continue;
                if ((wnt.transform.position - origin).sqrMagnitude > r2) continue;
                if (wnt.GetHealthPercentage() >= 0.999f) continue;

                if (respectWards.Value && !PrivateArea.CheckAccess(wnt.transform.position, 0f, false, false))
                    continue;

                var nview = wnt.GetComponent<ZNetView>();
                if (nview == null || !nview.IsValid()) continue;
                if (!nview.IsOwner()) nview.ClaimOwnership();

                if (wnt.Repair())
                    left--;
            }
        }

        bool EnemyNear(Player player)
        {
            float r2 = enemyRadius.Value * enemyRadius.Value;
            Vector3 pos = player.transform.position;
            foreach (var c in Character.GetAllCharacters())
            {
                if (c == null || c == player || c.IsDead() || c.IsTamed()) continue;
                if ((c.transform.position - pos).sqrMagnitude > r2) continue;
                if (BaseAI.IsEnemy(player, c)) return true;
            }
            return false;
        }
    }
}
