using Orchard.UI.Resources;

namespace ivNet.TringAllotment
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            //manifest.DefineScript("Theme").SetUrl("theme.js", "theme.js").SetDependencies("jQuery");

        }
    }
}