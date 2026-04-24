// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MEGA_CUM : ModuleRules
{
	public MEGA_CUM(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MEGA_CUM",
			"MEGA_CUM/Variant_Platforming",
			"MEGA_CUM/Variant_Platforming/Animation",
			"MEGA_CUM/Variant_Combat",
			"MEGA_CUM/Variant_Combat/AI",
			"MEGA_CUM/Variant_Combat/Animation",
			"MEGA_CUM/Variant_Combat/Gameplay",
			"MEGA_CUM/Variant_Combat/Interfaces",
			"MEGA_CUM/Variant_Combat/UI",
			"MEGA_CUM/Variant_SideScrolling",
			"MEGA_CUM/Variant_SideScrolling/AI",
			"MEGA_CUM/Variant_SideScrolling/Gameplay",
			"MEGA_CUM/Variant_SideScrolling/Interfaces",
			"MEGA_CUM/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
