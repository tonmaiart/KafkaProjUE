// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using UnrealBuildTool.Rules;

public class UkoreToolkit : ModuleRules
{
	public UkoreToolkit(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);


        PrivateIncludePaths.AddRange(
            new string[] {
                System.IO.Path.GetFullPath(Target.RelativeEnginePath)+"/Plugins/Runtime/GeometryCache/Source/GeometryCacheTracks/Classes",
                System.IO.Path.GetFullPath(Target.RelativeEnginePath)+"Source/Editor/Blutility/Private",
                System.IO.Path.GetFullPath(Target.RelativeEnginePath)+"Source/Editor/Blutility/Private"

            }
            );


        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "ContentBrowser",
                "AssetRegistry",
                "Core",
                "Blutility",
                "EditorScriptingUtilities",
                "UnrealEd",
                "InputCore",
                "Slate",
                "AssetRegistry",
                "LevelSequence",
                "MovieSceneTools",
                "LevelSequenceEditor",
                "DeveloperSettings",
                "ToolMenus",
                "MovieScene",
                "GeometryCache",
                "GeometryCacheTracks",
                "AlembicImporter",

                //"AlembicLibrary"

				// ... add other public dependencies that you statically link with here ...
			}
            );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "EditorScriptingUtilities",
                "UnrealEd",
                "AlembicLibrary",
                "AlembicImporter",
                            "MovieScene",
                "GeometryCache",
                "GeometryCacheTracks"
				// ... add private dependencies that you statically link with here ...	
			}
            );


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
				// ... add any modules that your module loads dynamically here ...
			}
            );
    }
}
