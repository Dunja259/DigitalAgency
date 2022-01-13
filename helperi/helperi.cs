using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat.helperi
{
    public static class helperi
    {
        public static MvcHtmlString logoHelper(string img, string desc)
        {
            var tagBuilder = new TagBuilder("div");
            tagBuilder.InnerHtml = "<img src=" + img + ">" + "<p>" + desc + "</p>";
            tagBuilder.AddCssClass("logo");
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}