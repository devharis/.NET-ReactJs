using System.Web.Optimization;
using System.Web.Optimization.React;

namespace Web
{
    public static class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new JsxBundle("~/bundles/comment").Include(
                "~/Scripts/Comment/*.jsx"
            ));

            bundles.Add(new JsxBundle("~/bundles/pagination").Include(
                "~/Scripts/Pagination/PaginationList.jsx",
                "~/Scripts/Pagination/Item.jsx",
                "~/Scripts/Pagination/PaginationBox.jsx"
            ));

            // Forces files to be combined and minified in debug mode
            // Only used here to demonstrate how combination/minification works
            // Normally you would use unminified versions in debug mode.
            BundleTable.EnableOptimizations = false;
        }
    }
}