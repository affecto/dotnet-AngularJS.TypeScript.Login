using System.Web.Optimization;

namespace Affecto.AngularJS.TypeScript.Login
{
    public static class LoginBundle
    {
        public static Bundle CreateScriptBundle(string virtualPath)
        {
            return new ScriptBundle(virtualPath)
                .Include("~/Scripts/angular-local-storage.min.js")
                .IncludeDirectory("~/App/Packages/Login/Constants", "*.js")
                .IncludeDirectory("~/App/Packages/Login/Services", "*.js")
                .IncludeDirectory("~/App/Packages/Login/Models", "*.js")
                .IncludeDirectory("~/App/Packages/Login/Controllers", "*.js")
                .Include("~/App/Packages/Login/Login.js");
        }
    }
}