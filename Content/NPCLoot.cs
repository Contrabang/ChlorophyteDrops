using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace ChlorophyteDrops.Content
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class NPCLoot : GlobalNPC
	{
		public override void ModifyGlobalLoot(GlobalLoot globalLoot) {
			globalLoot.Add(ItemDropRule.ByCondition(new ChlorophyteDropCondition(), ItemID.ChlorophyteOre, 5, 1, 1));
		}
	}
}
