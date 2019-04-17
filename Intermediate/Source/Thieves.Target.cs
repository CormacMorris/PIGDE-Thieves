using UnrealBuildTool;

public class ThievesTarget : TargetRules
{
	public ThievesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Thieves");
	}
}
