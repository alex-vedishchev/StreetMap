using System.IO;
using UnrealBuildTool;

namespace UnrealBuildTool.Rules
{
	public class StreetMapRuntime : ModuleRules
	{
        public StreetMapRuntime(ReadOnlyTargetRules Target)
			: base(Target)
		{
            // Enabling IWYU
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

            PrivatePCHHeaderFile = "Public/StreetMapRuntime.h";

            // Private include path
            PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));

            // Public include path
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

            PublicDependencyModuleNames.AddRange(
				new string[] {
                    "Core",
					"CoreUObject",
					"Engine",
					"RHI",
					"RenderCore",
                    "PropertyEditor"
                }
			);
		}
	}
}