#pragma checksum "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2f1e22a4e7519c1729dac26ff1aa2ccab07b084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.PagesMovies_Delete), @"mvc.1.0.razor-page", @"/PagesMovies/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/PagesMovies/Delete.cshtml", typeof(AspNetCore.PagesMovies_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2f1e22a4e7519c1729dac26ff1aa2ccab07b084", @"/PagesMovies/Delete.cshtml")]
    public class PagesMovies_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(99, 173, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(273, 47, false);
#line 16 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Title));

#line default
#line hidden
            EndContext();
            BeginContext(320, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(382, 43, false);
#line 19 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Title));

#line default
#line hidden
            EndContext();
            BeginContext(425, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(486, 53, false);
#line 22 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(539, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(601, 49, false);
#line 25 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Movie.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(650, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(711, 47, false);
#line 28 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(758, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(820, 43, false);
#line 31 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(863, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(924, 47, false);
#line 34 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Price));

#line default
#line hidden
            EndContext();
            BeginContext(971, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1033, 43, false);
#line 37 "C:\Users\chase\Documents\codingBootcamp\01-independent_apps\dotnet_fun\RazorPagesMovie\PagesMovies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 254, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form method=\"post\">\r\n        <input type=\"hidden\" asp-for=\"Movie.ID\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-page=\"./Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.PagesMovies.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.PagesMovies.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.PagesMovies.DeleteModel>)PageContext?.ViewData;
        public RazorPagesMovie.PagesMovies.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
