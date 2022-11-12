using UnrealBuildTool;

public class IbridoVirusTarget : TargetRules
{
	public IbridoVirusTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("IbridoVirus");
	}
}
