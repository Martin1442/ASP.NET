#pragma checksum "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\User\InProgress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9526ca3dd1b9fd434910ed557412eeb8bcc2f6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_InProgress), @"mvc.1.0.view", @"/Views/User/InProgress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/InProgress.cshtml", typeof(AspNetCore.Views_User_InProgress))]
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
#line 1 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\_ViewImports.cshtml"
using ToDoApplication.Models.DomainModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9526ca3dd1b9fd434910ed557412eeb8bcc2f6b", @"/Views/User/InProgress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6495ab74950df7410147d8f0326e4eaa020faf", @"/Views/_ViewImports.cshtml")]
    public class Views_User_InProgress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tasks>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\User\InProgress.cshtml"
  
    ViewData["Title"] = "InProgress";

#line default
#line hidden
            BeginContext(60, 39, true);
            WriteLiteral("\r\n<h2> Your task is in progress </h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tasks> Html { get; private set; }
    }
}
#pragma warning restore 1591
