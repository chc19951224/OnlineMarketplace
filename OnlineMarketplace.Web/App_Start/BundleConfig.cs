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

            // 自定義 JS 文件類型支援的捆綁
            bundles.Add(new Bundle("~/bundles/support/bootstrap").Include(
                      "~/Content/FrontendTheme/js/bootstrap.bundle.min.js"));
            #endregion

            #region 【 Frontend 捆綁自定義的 Bootstrap 所需脚本 】
            bundles.Add(new ScriptBundle("~/bundles/FrontendTheme/js").Include(
                        //"~/Content/FrontendTheme/js/bootstrap.bundle.min.js",
                        "~/Content/FrontendTheme/js/jquery.min.js",
                        "~/Content/FrontendTheme/js/modernizr.js",
                        "~/Content/FrontendTheme/js/plugins.js",
                        "~/Content/FrontendTheme/js/script.min.js",
                        "~/Content/FrontendTheme/js/SmoothScroll.js"));
            #endregion

            #endregion

            #region 【 CSS 文件 】

            #region 【 CSS 文件類型支援的捆綁 】
            bundles.Add(new StyleBundle("~/Content/support/css").Include(
                      "~/Content/DefaultTheme/css/bootstrap.css",
                      "~/Content/DefaultTheme/css/site.css"));
            #endregion

            #region 【 Frontend 捆綁自定義的 CSS 所需脚本 】
            bundles.Add(new StyleBundle("~/bundles/FrontendTheme/css").Include(
                        "~/Content/FrontendTheme/css/bootstrap.min.css",
                        "~/Content/FrontendTheme/css/fonts.googleapis.com.css",
                        "~/Content/FrontendTheme/css/normalize.css",
                        "~/Content/FrontendTheme/css/style.css",
                        "~/Content/FrontendTheme/css/swiper-bundle.min.css",
                        "~/Content/FrontendTheme/css/vendor.css"));
            #endregion

            #endregion
        }
    }
}
