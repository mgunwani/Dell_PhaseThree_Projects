#pragma checksum "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110bb59649c83ce65a3dfe457e73c716fe115b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\_ViewImports.cshtml"
using coreDatabaseFirstApproachDemonstrations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\_ViewImports.cshtml"
using coreDatabaseFirstApproachDemonstrations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110bb59649c83ce65a3dfe457e73c716fe115b2e", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe185cccf4a80ec809382691dd8cf0c36368b550", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Author Details</h2>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Author Id</th>\r\n            <th>Author Name</th>\r\n            <th>Author age</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\Author\Index.cshtml"
         foreach(var item in ViewBag.Authors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\Author\Index.cshtml"
               Write(item.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\Author\Index.cshtml"
               Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\Author\Index.cshtml"
               Write(item.AuthorAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\BhawnaGunwani\source\repos\SessionFour_EntityFrameworkCore_Projects\coreDatabaseFirstApproachDemonstrations\Views\Author\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591