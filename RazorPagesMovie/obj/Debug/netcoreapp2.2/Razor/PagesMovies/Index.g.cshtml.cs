#pragma checksum "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462583d626960633af5689c53e3d325dfa19ebb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.PagesMovies_Index), @"mvc.1.0.razor-page", @"/PagesMovies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/PagesMovies/Index.cshtml", typeof(AspNetCore.PagesMovies_Index), null)]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462583d626960633af5689c53e3d325dfa19ebb3", @"/PagesMovies/Index.cshtml")]
    public class PagesMovies_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 156, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(254, 50, false);
#line 17 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 56, false);
#line 20 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(416, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(472, 50, false);
#line 23 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Genre));

#line default
#line hidden
            EndContext();
            BeginContext(522, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(578, 50, false);
#line 26 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(628, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
 foreach (var item in Model.Movie) {

#line default
#line hidden
            BeginContext(752, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(801, 40, false);
#line 35 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(841, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(897, 46, false);
#line 38 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(943, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(999, 40, false);
#line 41 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1095, 40, false);
#line 44 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1210, "\"", 1233, 1);
#line 47 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
WriteAttributeValue("", 1225, item.ID, 1225, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1234, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1286, "\"", 1309, 1);
#line 48 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
WriteAttributeValue("", 1301, item.ID, 1301, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1310, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1364, "\"", 1387, 1);
#line 49 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
WriteAttributeValue("", 1379, item.ID, 1379, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1388, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1438, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.PagesMovies.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.PagesMovies.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.PagesMovies.IndexModel>)PageContext?.ViewData;
        public RazorPagesMovie.PagesMovies.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591