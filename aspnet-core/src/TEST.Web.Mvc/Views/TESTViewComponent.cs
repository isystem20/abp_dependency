using Abp.AspNetCore.Mvc.ViewComponents;

namespace TEST.Web.Views
{
    public abstract class TESTViewComponent : AbpViewComponent
    {
        protected TESTViewComponent()
        {
            LocalizationSourceName = TESTConsts.LocalizationSourceName;
        }
    }
}
