#pragma checksum "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3dc6477f6953dc16afe615a114dda1bbf2afe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Index), @"mvc.1.0.view", @"/Views/Branches/Index.cshtml")]
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
#line 1 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3dc6477f6953dc16afe615a114dda1bbf2afe2", @"/Views/Branches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85771d2b7276b2da9518a094c9e5d2f1d0585e62", @"/Views/_ViewImports.cshtml")]
    public class Views_Branches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
  
    var Branches = (List<BranchModel>)ViewData["Branches"];
    string searchId = (string)ViewBag.address;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
Write(searchId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<h1>This Branch Index</h1>
<h1>This is index Branches !! </h1>
<table border=""1"">
    <thead>
        <tr>
            <td>ID</td>
            <td>Address</td>
            <td>Name</td>
            <td>Area</td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
         foreach (var b in Branches)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\hiro1\Downloads\CodeFirstApp-main\CodeFirstApp-main\CodeFirstApp\Views\Branches\Index.cshtml"
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
