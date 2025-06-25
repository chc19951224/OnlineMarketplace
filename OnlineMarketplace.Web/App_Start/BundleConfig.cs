using System.Data;
using System.Web;
using System.Web.Optimization;

namespace OnlineMarketplace.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 【 JS 文件 】
            // 官方 JS 文件
            bundles.Add(new ScriptBundle("~/bundles/support/jqueryval").Include(
                        "~/Content/ScriptsSupport/jquery.validate*")); // 未使用
            bundles.Add(new ScriptBundle("~/bundles/support/modernizr").Include(
                        "~/Content/ScriptsSupport/modernizr-*"));

            #region 【 Frontend 第三方主題 JS 捆綁和支援 】
            bundles.Add(new ScriptBundle("~/bundles/frontend/js").Include(
                        "~/Content/FrontendTheme/js/plugins.js",
                        "~/Content/FrontendTheme/js/SmoothScroll.js",
                        "~/Content/FrontendTheme/js/script.min.js"));

            bundles.Add(new Bundle("~/bundles/frontend/support/jquery").Include(
                      "~/Content/FrontendTheme/js/jquery.min.js"));
            bundles.Add(new Bundle("~/bundles/frontend/support/bootstrap").Include(
                      "~/Content/FrontendTheme/js/bootstrap.bundle.min.js"));
            bundles.Add(new Bundle("~/bundles/frontend/support/swiper").Include(
                      "~/Content/FrontendTheme/js/swiper-bundle.min.js"));
            #endregion

            #region 【 Backend 第三方主題 JS 捆綁和支援 】
            bundles.Add(new ScriptBundle("~/bundles/backend/js").Include(
                        "~/Content/BackendTheme/js/jquery.easing.min.js",
                        "~/Content/BackendTheme/js/sb-admin-2.min.js",
                        "~/Content/BackendTheme/js/Chart.min.js",
                        "~/Content/BackendTheme/js/chart-area-demo.js",
                        "~/Content/BackendTheme/js/chart-pie-demo.js"));

            bundles.Add(new Bundle("~/bundles/backend/support/jquery").Include(
                      "~/Content/BackendTheme/js/jquery.min.js"));
            bundles.Add(new Bundle("~/bundles/backend/support/bootstrap").Include(
                      "~/Content/BackendTheme/js/bootstrap.bundle.min.js"));
            #endregion
            #endregion


            #region 【 CSS 文件 】
            #region 【 Frontend 第三方主題 CSS 捆綁 】
            bundles.Add(new StyleBundle("~/bundles/frontend/css").Include(
                        "~/Content/FrontendTheme/css/bootstrap.min.css",
                        "~/Content/FrontendTheme/css/vendor.css",
                        "~/Content/FrontendTheme/css/swiper-bundle.min.css",
                        "~/Content/FrontendTheme/css/style.css",
                        "~/Content/FrontendTheme/css/fonts.googleapis.com.css"));
            #endregion

            #region 【 Backend 第三方主題 CSS 捆綁 】
            bundles.Add(new StyleBundle("~/bundles/backend/css").Include(
                        "~/Content/BackendTheme/css/fonts.googleapis.com.css",
                        "~/Content/BackendTheme/css/sb-admin-2.min.css",
                        "~/Content/BackendTheme/css/table.css"));
            #endregion
            #endregion
        }
    }
}
