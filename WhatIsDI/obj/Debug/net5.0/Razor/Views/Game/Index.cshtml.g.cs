#pragma checksum "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d8374c57a1282dcc09911934d6d9bc40627d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
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
#line 1 "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\_ViewImports.cshtml"
using WhatIsDI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\_ViewImports.cshtml"
using WhatIsDI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d8374c57a1282dcc09911934d6d9bc40627d03", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f269bb076aaeaba2fc63e3b28f043b07e238767", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Game>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div>\r\n");
            WriteLiteral("\t<h1>List of Games</h1>\r\n\t<hr />\r\n\t<table>\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Id</th>\r\n\t\t\t\t<th>Name</th>\r\n\t\t\t\t<th>List Price</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n");
#nullable restore
#line 17 "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\Game\Index.cshtml"
         foreach (var g in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
#nullable restore
#line 20 "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\Game\Index.cshtml"
               Write(g.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 21 "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\Game\Index.cshtml"
               Write(g.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td><b>(");
#nullable restore
#line 22 "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\Game\Index.cshtml"
                   Write(g.ListPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</b></td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 24 "C:\Users\Islim\source\repos\GelecegeGiris\WhatIsDI\Views\Game\Index.cshtml"
		}	

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
