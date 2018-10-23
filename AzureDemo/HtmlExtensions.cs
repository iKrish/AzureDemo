using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace AzureDemo
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString ImageFor(this HtmlHelper html, byte[] imgarr)
        {
            if (imgarr!=null)
            {
                var img = String.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(imgarr));
                return new MvcHtmlString("<img src='" + img + "' />");
            }
            else
                return new MvcHtmlString("Corrupted Image");
        }
    }
}