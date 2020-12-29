using System;
using System.Collections.Generic;
using System.Text;
using Demon.Blog.Localization;
using Volo.Abp.Application.Services;

namespace Demon.Blog
{
    /* Inherit your application services from this class.
     */
    public abstract class BlogAppService : ApplicationService
    {
        protected BlogAppService()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}
