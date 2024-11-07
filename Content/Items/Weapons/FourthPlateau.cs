using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Psychasia.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/s:table/ExampleMod
	public class FourthPlateau : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.Psychasia.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 416;
			Item.DamageType = DamageClass.Melee;
			Item.width = 45;
			Item.height = 45;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 9;
			Item.value = Item.buyPrice(platinum: 11, gold: 43);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
