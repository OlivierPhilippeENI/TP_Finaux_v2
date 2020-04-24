using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TP02M05.Helpers
{
    public static  class Helper
    {
        public static string CustomSubmit(this HtmlHelper htmlHelper, String name)
        {
            StringBuilder result = new StringBuilder();
            result.Append("<div class=\"form - group\">");
            result.Append("<div class=\"col-md-offset-2 col-md-10\">");
            result.Append($"<input type = \"submit\" value=\"{ name }\" class=\"btn btn - default\" />");
            result.Append("</div>");
            result.Append("</div>");

            return result.ToString();
        }
    }
}