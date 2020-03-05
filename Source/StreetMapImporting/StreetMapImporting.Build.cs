using System.IO;
using UnrealBuildTool;

namespace UnrealBuildTool.Rules
{
    public class StreetMapImporting : ModuleRules
    {
        public StreetMapImporting(ReadOnlyTargetRules Target)
			: base(Target)
        {
            // Enabling IWYU
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

            PrivatePCHHeaderFile = "Public/StreetMapImporting.h";

            // Private include path
            PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));

            // Public include path
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

            PublicDependencyModuleNames.AddRange(
                new string[] {
                    "Core",
                    "CoreUObject",
                    "Engine",
                    "UnrealEd",
                    "XmlParser",
                    "AssetTools",
                    "Projects",
                    "Slate",
                    "SlateCore",
                    "EditorStyle",
                    "PropertyEditor",
                    "RenderCore",
                    "RHI",
                    "RawMesh",
                    "AssetTools",
                    "AssetRegistry",
                }
            );

            PublicDependencyModuleNames.AddRange(
                new string[] {
                    "StreetMapRuntime"
                }
            );
        }
    }
}