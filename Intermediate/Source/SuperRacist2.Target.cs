using UnrealBuildTool;

public class SuperRacist2Target : TargetRules
{
	public SuperRacist2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SuperRacist2");
	}
}
