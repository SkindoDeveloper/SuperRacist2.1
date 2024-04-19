using UnrealBuildTool;

public class SuperRacist2ClientTarget : TargetRules
{
	public SuperRacist2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SuperRacist2");
	}
}
