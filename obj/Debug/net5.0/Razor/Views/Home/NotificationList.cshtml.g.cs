#pragma checksum "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b201a5faba0c4cb3291b1cbeafffb03a127c3d92"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b201a5faba0c4cb3291b1cbeafffb03a127c3d92", @"/Views/Home/NotificationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0366b0c6193dc70b2f06ea88f401a3238d6bfe66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NotificationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tirkhanti_R12.Models.StudentReport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\n\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 9 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
               Write(Html.DisplayNameFor(model => model.ReportDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 12 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentComment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 15 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
               Write(Html.DisplayNameFor(model => model.AssignedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 18 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
               Write(Html.DisplayNameFor(model => model.CompleteDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 21 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
               Write(Html.DisplayNameFor(model => model.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 24 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
               Write(Html.DisplayNameFor(model => model.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 30 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 34 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.ReportDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 37 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.StudentComment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 40 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.AssignedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 43 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.CompleteDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 46 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 49 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
   Write(Html.DisplayFor(modelItem => item.IsComplete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b201a5faba0c4cb3291b1cbeafffb03a127c3d927708", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
                               WriteLiteral(item.ReportID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 54 "C:\Users\nicod\source\repos\Tirkhanti_R12\Tirkhanti_R12\Views\Home\NotificationList.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tirkhanti_R12.Models.StudentReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
