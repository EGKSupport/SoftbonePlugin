// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class SoftBone : ModuleRules
	{
        public SoftBone(ReadOnlyTargetRules Target) : base(Target)
		{
            PublicIncludePaths.Add("SoftBone/Public");
            PrivateIncludePaths.Add("SoftBone/Private");

            PublicDependencyModuleNames.AddRange(
                new string[] { 
				"Core", 
				"CoreUObject", 
				"Engine", 
				"AnimGraphRuntime",
			    }
            );
		}
	}
}
