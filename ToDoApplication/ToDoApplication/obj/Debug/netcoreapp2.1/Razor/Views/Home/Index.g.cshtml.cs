#pragma checksum "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f9ed1737a44f2bbf323137887b0f9afa9a39355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
using ToDoApplication;

#line default
#line hidden
#line 2 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\_ViewImports.cshtml"
using ToDoApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f9ed1737a44f2bbf323137887b0f9afa9a39355", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c445bdeba7a11e2b82cdbead924050244346a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
  
    int count = 1;
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(89, 45, true);
            WriteLiteral("<h2>Tasks that are not done:</h2>\r\n\r\n<br>\r\n\r\n");
            EndContext();
            BeginContext(135, 82, false);
#line 11 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
Write(Html.ActionLink("Add Task", "Index", "Task","", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(217, 16, true);
            WriteLiteral("\r\n\r\n<br><br>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
 foreach (var item in Model.UndoneTasks)
{

#line default
#line hidden
            BeginContext(278, 108, true);
            WriteLiteral("    <div class=\"row\" style=\"border:2px solid black\">\r\n        <div class=\"col-md-2 cols\">\r\n            Task ");
            EndContext();
            BeginContext(387, 5, false);
#line 19 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
            Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(392, 76, true);
            WriteLiteral(".\r\n        </div>\r\n        <div class=\"col-md-2 cols\">\r\n            Title: \"");
            EndContext();
            BeginContext(469, 10, false);
#line 22 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(479, 82, true);
            WriteLiteral("\"\r\n        </div>\r\n        <div class=\"col-md-4 cols\">\r\n            Description: \"");
            EndContext();
            BeginContext(562, 15, false);
#line 25 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
                     Write(item.Descripton);

#line default
#line hidden
            EndContext();
            BeginContext(577, 81, true);
            WriteLiteral("\"\r\n        </div>\r\n        <div class=\"col-md-2 cols\">\r\n            Importance: \"");
            EndContext();
            BeginContext(659, 26, false);
#line 28 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
                    Write(item.Importance.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(685, 75, true);
            WriteLiteral("\"\r\n        </div>\r\n        <div class=\"col-md-2 cols\">\r\n            Type: \"");
            EndContext();
            BeginContext(761, 20, false);
#line 31 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
              Write(item.Type.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(781, 41, true);
            WriteLiteral("\"\r\n        </div>\r\n    </div>\r\n    <br>\r\n");
            EndContext();
#line 35 "C:\Users\vitan\OneDrive\Desktop\ASP.NET\ToDoApplication\ToDoApplication\Views\Home\Index.cshtml"
    count += 1;
}

#line default
#line hidden
            BeginContext(842, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
