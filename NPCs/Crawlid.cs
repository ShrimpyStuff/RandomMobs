using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Mono.Cecil.Cil;
using System.Security.Cryptography.X509Certificates;

namespace RandomMobs.NPCs
{
    public class Crawlid : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetDefaults() {
			npc.width = 27;
			npc.height = 23;
			npc.aiStyle = 66;
			npc.damage = 20;
			npc.defense = 2;
			npc.lifeMax = 80;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 25f;
			npc.buffImmune[BuffID.Confused] = true;
		}

		/*public override void AI() {
			npc.velocity.X *= 3f;
		}*/

        public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldDaySlime.Chance;
		}
    }
}