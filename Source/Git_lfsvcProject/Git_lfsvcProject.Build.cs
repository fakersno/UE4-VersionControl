// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Git_lfsvcProject : ModuleRules
{
    public Git_lfsvcProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
