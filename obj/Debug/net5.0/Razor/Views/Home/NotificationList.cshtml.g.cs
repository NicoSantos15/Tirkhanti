#pragma checksum "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ac9c7855088f9a17b06955e01b6849ef3bf172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NotificationList), @"mvc.1.0.view", @"/Views/Home/NotificationList.cshtml")]
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
#line 1 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\_ViewImports.cshtml"
using Tirkhanti_R12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\_ViewImports.cshtml"
using Tirkhanti_R12.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ac9c7855088f9a17b06955e01b6849ef3bf172", @"/Views/Home/NotificationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0366b0c6193dc70b2f06ea88f401a3238d6bfe66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NotificationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Tirkhanti_R12.Models.StudentReport>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                <p>Is Complete</p>
            </th>
            <th>
                <p>Feeling Today</p>
            </th>
            <th>
                <p>Comment</p>
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 24 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 27 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.SelectedEmotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 30 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.StudentComment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>\n");
#nullable restore
#line 33 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Tirkhanti_R12.Models.StudentReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
