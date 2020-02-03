using Abp.AspNetCore.Mvc.Views;

namespace JF.AiClassRoom.Web.Views
{
    public abstract class AiClassRoomRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AiClassRoomRazorPage()
        {
            LocalizationSourceName = AiClassRoomConsts.LocalizationSourceName;
        }
    }
}
