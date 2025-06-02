using System.Web;
using System.Web.Optimization;

namespace OnlineMarketplace.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 【 JavaScript 文件 】

            #region 【 JS 文件類型支援的捆綁 】
            bundles.Add(new ScriptBundle("~/bundles/support/jquery").Include(
                        "~/Content/ScriptsSupport/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/support/jqueryval").Include(
                        "~/Content/ScriptsSupport/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/support/modernizr").Include(
                        "~/Content/ScriptsSupport/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/support/bootstrap").Include(
                      "~/Content/DefaultTheme/js/bootstrap.js"));
            #endregion

            #endregion

            #region 【 CSS 文件 】

            #region 【 CSS 文件類型支援的捆綁 】
            bundles.Add(new StyleBundle("~/Content/support/css").Include(
                      "~/Content/DefaultTheme/css/bootstrap.css",
                      "~/Content/DefaultTheme/css/site.css"));
            #endregion

            #endregion
        }
    }
}
