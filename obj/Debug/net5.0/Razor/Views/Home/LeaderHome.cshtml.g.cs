#pragma checksum "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\LeaderHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f04bfabc61deeaf654cdf64b43a373923ff126b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LeaderHome), @"mvc.1.0.view", @"/Views/Home/LeaderHome.cshtml")]
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
#line 2 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\LeaderHome.cshtml"
using Tirkhanti_R12.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04bfabc61deeaf654cdf64b43a373923ff126b1", @"/Views/Home/LeaderHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0366b0c6193dc70b2f06ea88f401a3238d6bfe66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LeaderHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\LeaderHome.cshtml"
 foreach (Emotions item in Model.emotion)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>");
#nullable restore
#line 14 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\LeaderHome.cshtml"
  Write(item.StudentEmotion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 15 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\LeaderHome.cshtml"
}

#line default
#line hidden
#nullable disable
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
