using Komiko.Models;

namespace Komiko.Contracts.Engines
{
    interface IApplicationEngine
    {
        /// <summary>
        /// Get application settings. Builds defaults if settings are not available
        /// </summary>
        /// <returns></returns>
        Config GetSettings();
    }
}
