#pragma checksum "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9057149b48d8c00a9ef3d45f680398aad44136e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowAsignedList), @"mvc.1.0.view", @"/Views/Home/ShowAsignedList.cshtml")]
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
#line 1 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
using FirstDbExercise;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9057149b48d8c00a9ef3d45f680398aad44136e1", @"/Views/Home/ShowAsignedList.cshtml")]
    public class Views_Home_ShowAsignedList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDo>>
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
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9057149b48d8c00a9ef3d45f680398aad44136e12938", async() => {
                WriteLiteral(@"
    <title>To Do</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9057149b48d8c00a9ef3d45f680398aad44136e14362", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col\">\n                ");
#nullable restore
#line 13 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
           Write(Html.ActionLink("Return to Todo list", "List", "Home", null, new { @class = "btn btn-info btn-large" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
        <h1 style=""text-align:center"">List of Works</h1>

        <table class=""table table-striped"">
            <thead>
                <tr>

                    <th scope=""col"">Title</th>
                    <th scope=""col"">Descrition</th>
                    <th scope=""col"">Is it urgent?</th>
                    <th scope=""col"">Is it done?</th>

                </tr>
            </thead>

");
#nullable restore
#line 30 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
             foreach (var todo in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tbody>\n                    <tr>\n                        <th scope=\"row\">");
#nullable restore
#line 34 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
                                   Write(todo.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                        <td>");
#nullable restore
#line 35 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
                       Write(todo.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 36 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
                       Write(todo.IsUrgent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 37 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
                       Write(todo.IsDone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    </tr>\n                </tbody>\n");
#nullable restore
#line 40 "C:\Users\User\Desktop\test.Net\ToDoApp\Views\Home\ShowAsignedList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </table>
    </div>
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
