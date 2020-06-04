#pragma checksum "C:\Users\apgov\workspace\kubernetes-workshop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f54a75b4230652d3164424eea6dcc70631cda4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\apgov\workspace\kubernetes-workshop\Views\_ViewImports.cshtml"
using kubernetes_workshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apgov\workspace\kubernetes-workshop\Views\_ViewImports.cshtml"
using kubernetes_workshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f54a75b4230652d3164424eea6dcc70631cda4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14a1149f8e9d9d47eb478d2bd6e11459ba453a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\apgov\workspace\kubernetes-workshop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Kubernetes Workshop Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to Kubernetes Workshop </h1>\r\n    <p>Learn about <a href=\"https://kubernetes-workshop.education.pivotal.io/index.html\">building & deploying kubernetes Apps </a>.</p>\r\n</div>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f54a75b4230652d3164424eea6dcc70631cda43671", async() => {
                WriteLiteral("\r\n<style>\r\ntable {\r\n  font-family: arial, sans-serif;\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}\r\n\r\ntd, th {\r\n  border: 1px solid #dddddd;\r\n  text-align: left;\r\n  padding: 8px;\r\n}\r\n\r\ntr:nth-child(even) {\r\n  background-color: #dddddd;\r\n}\r\n</style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f54a75b4230652d3164424eea6dcc70631cda44923", async() => {
                WriteLiteral(@"

<h2>Kubernetes</h2>

<table>
  <tr>
    <th>Topics  </th>

  </tr>
  <tr>
    <td>Operational Kubernetes</td>
    <td><a href=""https://kubernetes-workshop.education.pivotal.io/index.html"">slides </a></td>
    <td>Lab</td>
  </tr>
     <tr>
    <td>Your First Container</td>
    <td><a href=""https://kubernetes-workshop.education.pivotal.io/index.html"">Slides </a></td>
    <td><a href=""https://kubernetes.io/"">Lab </a></td>
  </tr>
    <tr>
    <td>Declarative Configuration & Service</td>
    <td><a href=""https://kubernetes-workshop.education.pivotal.io/index.html"">slides </a></td>
    <td>Lab</td>
  </tr>
    <tr>
    <td>PKS & PAS - Separate Abstractions Working in Harmony</td>
    <td><a href=""https://kubernetes-workshop.education.pivotal.io/index.html"">Slides </a></td>
    <td>Lab</td>
  </tr>
    <tr>
    <td>PKS  - Supporting .NET workloads</td>
    <td><a href=""https://kubernetes-workshop.education.pivotal.io/index.html"">Slides </a></td>
    <td>Lab</td>
  </tr>
    <tr>");
                WriteLiteral(@"
    <td>Introducing State & External Configuration</td>
    <td><a href=""https://kubernetes-workshop.education.pivotal.io/index.html"">Slides </a></td>
    <td>Lab</td>
  </tr>
    </tr>
    <tr>
    <td>App Operations: Scaling, Metrics, and Logs</td>
    <td><a href=""https://kubernetes-workshop.education.pivotal.io/index.html"">Slides </a></td>
    <td>Lab</td>
  </tr>
</table>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
