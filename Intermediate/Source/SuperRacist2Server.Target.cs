using UnrealBuildTool;

public class SuperRacist2ServerTarget : TargetRules
{
	public SuperRacist2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SuperRacist2");
	}
}
