using Microsoft.CodeAnalysis;
using NSwag;

namespace LibKubernetesGenerator;

internal class VersionGenerator
{
    public void Generate(OpenApiDocument swagger, GeneratorExecutionContext context)
    {
        context.AddSource("k8sver.cs", $"// <auto-generated />\n" + "internal static partial class ThisAssembly { internal const string KubernetesSwaggerVersion = \"" + swagger.Info.Version + "\";}");
    }
}
