
using UnrealBuildTool;
using System.Collections.Generic;

public class Passthrough_ExampleTarget : TargetRules
{
	public Passthrough_ExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange(new string[] { "Passthrough_Example" });
	}
}
