using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RandomMobs.NPCs
{
    public class Vex : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetDefaults()
        {
            npc.aiStyle = 2;
            npc.width = 10;
            npc.height = 10;
            npc.damage = 25;
            this.noGravity = true;
            this.noTileCollide = true;
            npc.lifeMax = 80;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance;
		}
    }
}
