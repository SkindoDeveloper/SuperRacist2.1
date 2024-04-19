using UnrealBuildTool;

public class SuperRacist2EditorTarget : TargetRules
{
	public SuperRacist2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SuperRacist2");
	}
}
