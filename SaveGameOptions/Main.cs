using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;

namespace SaveGameOptions
{
	public class Main : Mod
	{
		public override void Entry(IModHelper helper)
		{
			helper.Events.Display.MenuChanged += this.Menu;
			helper.Events.GameLoop.SaveLoaded += this.Load;
		}
		private void Menu(object sender, MenuChangedEventArgs e)
		{
			if (e.NewMenu is GameMenu)
			{
				this.Save();
			}
		}
		private void Load(object sender, SaveLoadedEventArgs e)
		{
			Data gameOptions = this.Helper.Data.ReadJsonFile<Data>("data/SavedOptions.json");
			if (gameOptions != null)
			{
				this.setOptionsFromData(gameOptions);
				return;
			}
			this.Save();
		}
		private void setOptionsFromData(Data options)
		{
			Options gameoptions = Game1.options;

			//General
			gameoptions.autoRun = options.autoRun;
			gameoptions.showPortraits = options.showPortraits;
			gameoptions.showMerchantPortraits = options.showMerchantPortraits;
			gameoptions.alwaysShowToolHitLocation = options.alwaysShowToolHitLocation;
			gameoptions.hideToolHitLocationWhenInMotion = options.hideToolHitLocationWhenInMotion;
			gameoptions.showPlacementTileForGamepad = options.showPlacementTileForGamepad;
			gameoptions.pauseWhenOutOfFocus = options.pauseWhenOutOfFocus;
			gameoptions.snappyMenus = options.snappyMenus;
			gameoptions.showAdvancedCraftingInformation = options.showAdvancedCraftingInformation;

			//Sounds
			gameoptions.playFootstepSounds = options.playFootstepSounds;
			gameoptions.ambientOnlyToggle = options.ambientOnlyToggle;
			gameoptions.musicVolumeLevel = options.musicVolumeLevel;
			gameoptions.soundVolumeLevel = options.soundVolumeLevel;
			gameoptions.ambientVolumeLevel = options.ambientVolumeLevel;
			gameoptions.footstepVolumeLevel = options.footstepVolumeLevel;
			gameoptions.dialogueTyping = options.dialogueTyping;

			//Graphics
			gameoptions.windowedBorderlessFullscreen = options.windowedBorderlessFullscreen;
			gameoptions.preferredResolutionX = options.preferredResolutionX;
			gameoptions.preferredResolutionY = options.preferredResolutionY;
			gameoptions.fullscreen = options.fullscreen;
			gameoptions.vsyncEnabled = options.vsyncEnabled;
			gameoptions.showMenuBackground = options.showMenuBackground;
			gameoptions.pinToolbarToggle = options.pinToolbarToggle;
			gameoptions.zoomLevel = options.zoomLevel;
			gameoptions.zoomButtons = options.zoomButtons;
			gameoptions.lightingQuality = options.lightingQuality;
			gameoptions.snowTransparency = options.snowTransparency;
			gameoptions.screenFlash = options.screenFlash;
			gameoptions.hardwareCursor = options.hardwareCursor;

			//Controls
			gameoptions.rumble = options.rumble;
			gameoptions.invertScrollDirection = options.invertScrollDirection;
			gameoptions.actionButton = options.actionButton;
			gameoptions.useToolButton = options.useToolButton;
			gameoptions.menuButton = options.menuButton;
			gameoptions.journalButton = options.journalButton;
			gameoptions.mapButton = options.mapButton;
			gameoptions.moveUpButton = options.moveUpButton;
			gameoptions.moveLeftButton = options.moveLeftButton;
			gameoptions.moveDownButton = options.moveDownButton;
			gameoptions.moveRightButton = options.moveRightButton;
			gameoptions.chatButton = options.chatButton;
			gameoptions.emoteButton = options.emoteButton;
			gameoptions.runButton = options.runButton;
			gameoptions.toolbarSwap = options.toolbarSwap;
			gameoptions.inventorySlot1 = options.inventorySlot1;
			gameoptions.inventorySlot2 = options.inventorySlot2;
			gameoptions.inventorySlot3 = options.inventorySlot3;
			gameoptions.inventorySlot4 = options.inventorySlot4;
			gameoptions.inventorySlot5 = options.inventorySlot5;
			gameoptions.inventorySlot6 = options.inventorySlot6;
			gameoptions.inventorySlot7 = options.inventorySlot7;
			gameoptions.inventorySlot8 = options.inventorySlot8;
			gameoptions.inventorySlot9 = options.inventorySlot9;
			gameoptions.inventorySlot10 = options.inventorySlot10;
			gameoptions.inventorySlot11 = options.inventorySlot11;
			gameoptions.inventorySlot12 = options.inventorySlot12;
		}
		private void Save()
		{
			Options savedOptions = Game1.options;
			Data data = new Data
			{
				//General
				autoRun = savedOptions.autoRun,
				showPortraits = savedOptions.showPortraits,
				showMerchantPortraits = savedOptions.showMerchantPortraits,
				alwaysShowToolHitLocation = savedOptions.alwaysShowToolHitLocation,
				hideToolHitLocationWhenInMotion = savedOptions.hideToolHitLocationWhenInMotion,
				showPlacementTileForGamepad = savedOptions.showPlacementTileForGamepad,
				pauseWhenOutOfFocus = savedOptions.pauseWhenOutOfFocus,
				snappyMenus = savedOptions.snappyMenus,
				showAdvancedCraftingInformation = savedOptions.showAdvancedCraftingInformation,

				//Sound
				playFootstepSounds = savedOptions.playFootstepSounds,
				ambientOnlyToggle = savedOptions.ambientOnlyToggle,
				musicVolumeLevel = savedOptions.musicVolumeLevel,
				soundVolumeLevel = savedOptions.soundVolumeLevel,
				ambientVolumeLevel = savedOptions.ambientVolumeLevel,
				footstepVolumeLevel = savedOptions.footstepVolumeLevel,
				dialogueTyping = savedOptions.dialogueTyping,

				//Graphics
				windowedBorderlessFullscreen = savedOptions.windowedBorderlessFullscreen,
				preferredResolutionX = savedOptions.preferredResolutionX,
				preferredResolutionY = savedOptions.preferredResolutionY,
				fullscreen = savedOptions.fullscreen,
				vsyncEnabled = savedOptions.vsyncEnabled,
				showMenuBackground = savedOptions.showMenuBackground,
				pinToolbarToggle = savedOptions.pinToolbarToggle,
				zoomLevel = savedOptions.zoomLevel,
				zoomButtons = savedOptions.zoomButtons,
				lightingQuality = savedOptions.lightingQuality,
				snowTransparency = savedOptions.snowTransparency,
				screenFlash = savedOptions.screenFlash,
				hardwareCursor = savedOptions.hardwareCursor,

				//Controls
				rumble = savedOptions.rumble,
				invertScrollDirection = savedOptions.invertScrollDirection,
				actionButton = savedOptions.actionButton,
				useToolButton = savedOptions.useToolButton,
				menuButton = savedOptions.menuButton,
				journalButton = savedOptions.journalButton,
				mapButton = savedOptions.mapButton,
				moveUpButton = savedOptions.moveUpButton,
				moveLeftButton = savedOptions.moveLeftButton,
				moveDownButton = savedOptions.moveDownButton,
				moveRightButton = savedOptions.moveRightButton,
				chatButton = savedOptions.chatButton,
				emoteButton = savedOptions.emoteButton,
				runButton = savedOptions.runButton,
				toolbarSwap = savedOptions.toolbarSwap,
				inventorySlot1 = savedOptions.inventorySlot1,
				inventorySlot2 = savedOptions.inventorySlot2,
				inventorySlot3 = savedOptions.inventorySlot3,
				inventorySlot4 = savedOptions.inventorySlot4,
				inventorySlot5 = savedOptions.inventorySlot5,
				inventorySlot6 = savedOptions.inventorySlot6,
				inventorySlot7 = savedOptions.inventorySlot7,
				inventorySlot8 = savedOptions.inventorySlot8,
				inventorySlot9 = savedOptions.inventorySlot9,
				inventorySlot10 = savedOptions.inventorySlot10,
				inventorySlot11 = savedOptions.inventorySlot11,
				inventorySlot12 = savedOptions.inventorySlot12
			};
			this.Helper.Data.WriteJsonFile<Data>("data/SavedOptions.json", data);
		}
	}
}
