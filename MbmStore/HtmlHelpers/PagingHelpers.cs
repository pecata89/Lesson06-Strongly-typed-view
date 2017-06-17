using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using MbmStore.ViewModels;

namespace MbmStore.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();

            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination justify-content-center");

            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder li = new TagBuilder("li");
                TagBuilder anchor = new TagBuilder("a");
                anchor.MergeAttribute("href", pageUrl(i));
                anchor.InnerHtml = i.ToString();
                TagBuilder span = new TagBuilder("span");
                span.AddCssClass("page-link");

                // when pagination link is active
                if (i == pagingInfo.CurrentPage)
                {
                    li.AddCssClass("page-item active");
                    span.AddCssClass("page-link");
                    span.InnerHtml = i.ToString();
                    li.InnerHtml = span.ToString();
                }
                // when you can select this page for showing different products
                else
                {
                    li.AddCssClass("page-item");
                    anchor.AddCssClass("page-link");
                    li.InnerHtml += anchor.ToString();
                }


                if (i == 1 && pagingInfo.CurrentPage == 1)
                {
                    ul.InnerHtml += "<li class=\"page-item disabled\"><span class=\"page-link\">Previous</span></li>";
                }
                else if (i == 1 && pagingInfo.CurrentPage > 1)
                {
                    ul.InnerHtml += "<li class=\"page-item\"><a class=\"page-link\" href=\"" + pageUrl((pagingInfo.CurrentPage) - 1) + "\">Previous</a></li>";
                }
                
                ul.InnerHtml += li.ToString();

                if (i == pagingInfo.TotalPages && pagingInfo.CurrentPage == pagingInfo.TotalPages)
                {
                    ul.InnerHtml += "<li class=\"page-item disabled\"><span class=\"page-link\">Next</span></li>";
                }
                else if (i == pagingInfo.TotalPages && pagingInfo.CurrentPage < pagingInfo.TotalPages)
                {
                    ul.InnerHtml += "<li class=\"page-item\"><a class=\"page-link\" href=\"" + pageUrl((pagingInfo.CurrentPage) + 1) + "\">Next</a></li>";
                }

            }

            result.Append(ul.ToString());

            return MvcHtmlString.Create(result.ToString());
        }
    }
}