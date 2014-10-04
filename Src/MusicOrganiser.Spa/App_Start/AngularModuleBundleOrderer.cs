using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace App.MusicOrganiser.Spa
{
    public class AngularModuleBundleOrderer : IBundleOrderer
    {
        private int Rank(BundleFile file)
        {
            string path = file.IncludedVirtualPath.ToLowerInvariant();

            if (!path.Contains("/scripts/app/"))
            {
                return 1;
            }

            if (path.EndsWith(".module.js"))
            {
                return 2;
            }

            return 3;
        }

        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files.OrderBy(Rank);
        }
    }
}