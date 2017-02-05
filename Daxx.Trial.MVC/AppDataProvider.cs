// -------------------------------------------------------------------------------------------------------------
//  AppDataProvider.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

using System.Web;
using Daxx.Trial.Abstractions.Interfaces;

namespace Daxx.Trial.MVC
{
    public class AppDataProvider : IAppDataProvider
    {
        public string GetAppDataPath()
        {
            return HttpContext.Current.Server.MapPath("~/App_Data");
        }
    }
}