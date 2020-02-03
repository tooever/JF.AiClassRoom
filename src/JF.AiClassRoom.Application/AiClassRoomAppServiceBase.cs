using Abp.Application.Services;

namespace JF.AiClassRoom
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AiClassRoomAppServiceBase : ApplicationService
    {
        protected AiClassRoomAppServiceBase()
        {
            LocalizationSourceName = AiClassRoomConsts.LocalizationSourceName;
        }
    }
}