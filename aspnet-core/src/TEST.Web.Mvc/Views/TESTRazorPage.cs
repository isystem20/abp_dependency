using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace TEST.Web.Views
{
    public abstract class TESTRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TESTRazorPage()
        {
            LocalizationSourceName = TESTConsts.LocalizationSourceName;
        }
    }
}
