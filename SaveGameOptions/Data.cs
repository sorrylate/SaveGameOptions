using System;
using StardewValley;

namespace SaveGameOptions
{
	internal class Data
	{
		//General
		public bool autoRun = true;
		public bool showPortraits = true;
		public bool showMerchantPortraits = true;
		public bool alwaysShowToolHitLocation;
		public bool hideToolHitLocationWhenInMotion = true;
		public bool showPlacementTileForGamepad = true;
		public bool pauseWhenOutOfFocus = true;
		public bool snappyMenus = true;
		public bool showAdvancedCraftingInformation;

		//Sounds
		public bool playFootstepSounds = true;
		public bool ambientOnlyToggle;
		public float musicVolumeLevel = 0.75f;
		public float soundVolumeLevel = 1f;
		public float ambientVolumeLevel = 0.75f;
		public float footstepVolumeLevel = 0.9f;
		public bool dialogueTyping = true;

		//Graphics
		public bool windowedBorderlessFullscreen = true;
		public int preferredResolutionX;
		public int preferredResolutionY;
		public bool fullscreen;
		public bool vsyncEnabled = true;
		public bool showMenuBackground;
		public bool pinToolbarToggle;
		public float zoomLevel = 1f;
		public bool zoomButtons;
		public int lightingQuality = 32;
		public float snowTransparency = 1f;
		public bool screenFlash = true;
		public bool hardwareCursor;

		//Controls
		public bool rumble = true;
		public bool invertScrollDirection;
		public InputButton[] actionButton;
		public InputButton[] useToolButton;
		public InputButton[] menuButton;
		public InputButton[] journalButton;
		public InputButton[] mapButton;
		public InputButton[] moveUpButton;
		public InputButton[] moveLeftButton;
		public InputButton[] moveDownButton;
		public InputButton[] moveRightButton;
		public InputButton[] chatButton;
		public InputButton[] emoteButton;
		public InputButton[] runButton;
		public InputButton[] toolbarSwap;
		public InputButton[] inventorySlot1;
		public InputButton[] inventorySlot2;
		public InputButton[] inventorySlot3;
		public InputButton[] inventorySlot4;
		public InputButton[] inventorySlot5;
		public InputButton[] inventorySlot6;
		public InputButton[] inventorySlot7;
		public InputButton[] inventorySlot8;
		public InputButton[] inventorySlot9;
		public InputButton[] inventorySlot10;
		public InputButton[] inventorySlot11;
		public InputButton[] inventorySlot12;
	}
}
