using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;

namespace ChlorophyteDrops.Content
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class ChlorophyteDropCondition : IItemDropRuleCondition
	{
		public bool CanDrop(DropAttemptInfo info) {
			NPC npc = info.npc;
			return Main.hardMode
				&& NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3
				&& !NPCID.Sets.CannotDropSouls[npc.type]
				&& !npc.boss
				&& !npc.friendly
				&& npc.lifeMax > 1
				&& npc.value >= 1f
				&& info.player.ZoneJungle
				&& (info.player.ZoneRockLayerHeight || info.player.ZoneDirtLayerHeight);
		}

		public bool CanShowItemDropInUI() {
			return false;
		}

		public string GetConditionDescription() {
			// This should never show up because this is only used for a global loot drop condition
			return "If you're seeing this, this is a bug!";
		}
	}
}
