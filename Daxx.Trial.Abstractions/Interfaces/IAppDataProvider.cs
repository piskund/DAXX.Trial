// -------------------------------------------------------------------------------------------------------------
//  IAppDataProvider.cs created by DEP on 2017/02/05
// -------------------------------------------------------------------------------------------------------------

namespace Daxx.Trial.Abstractions.Interfaces
{
    /// <summary>
    /// Provides path to necessary data (placed to the App_Data in our case).
    /// </summary>
    public interface IAppDataProvider
    {
        string GetAppDataPath();
    }
}