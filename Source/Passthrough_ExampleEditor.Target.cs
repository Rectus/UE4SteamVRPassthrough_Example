
using UnrealBuildTool;
using System.Collections.Generic;

public class Passthrough_ExampleEditorTarget : TargetRules
{
	public Passthrough_ExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange(new string[] { "Passthrough_Example" });
	}
}
