using Abp.AspNetCore.Mvc.Controllers;

namespace JF.AiClassRoom.Web.Controllers
{
    public abstract class AiClassRoomControllerBase: AbpController
    {
        protected AiClassRoomControllerBase()
        {
            LocalizationSourceName = AiClassRoomConsts.LocalizationSourceName;
        }
    }
}