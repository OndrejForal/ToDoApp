#pragma checksum "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d3bc412643694e7e4c215730f780d6e3d2d7571"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditInDatabase), @"mvc.1.0.view", @"/Views/Home/EditInDatabase.cshtml")]
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
#line 1 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
using FirstDbExercise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3bc412643694e7e4c215730f780d6e3d2d7571", @"/Views/Home/EditInDatabase.cshtml")]
    public class Views_Home_EditInDatabase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
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
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d3bc412643694e7e4c215730f780d6e3d2d75713015", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d3bc412643694e7e4c215730f780d6e3d2d75714445", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
#nullable restore
#line 14 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
           Write(Html.ActionLink("Return to Todo list", "List", "Home", null, new { @class = "btn btn-info btn-large" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <h1 style=\"text-align:center\">Please provide information which work need to be edit and change </h1>\r\n");
#nullable restore
#line 18 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
         using (Html.BeginForm("SaveEditInDatabase", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <form class=""border border-secondary"">
        <div class=""form-group row"">
            <label for=""name"" class=""col-2 col-form-label""> To do work to edit: </label>
            <div class=""col-10"">
                <input type=""text"" name=""title"" id=""name""");
                BeginWriteAttribute("value", " value=\"", 1286, "\"", 1311, 1);
#nullable restore
#line 24 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
WriteAttributeValue("", 1294, Model.Todo.Title, 1294, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
        </div>

        <div class=""form-group row"">
            <label for=""description"" class=""col-2 col-form-label""> Description of work to edit: </label>
            <div class=""col-10"">
                <input type=""text"" name=""Description"" id=""description""");
                BeginWriteAttribute("value", " value=\"", 1603, "\"", 1634, 1);
#nullable restore
#line 31 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
WriteAttributeValue("", 1611, Model.Todo.Description, 1611, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
        </div>


        <label for=""urgent""> Is it urgent?: </label>
        <input type=""checkbox"" name=""IsUrgent"" id=""urgent"" value=""true"" /><br />

        <label for=""done""> Is it done?: </label>
        <input type=""checkbox"" name=""IsDone"" id=""done"" value=""true"" />

        <input type=""hidden"" name=""Id""");
                BeginWriteAttribute("value", " value=\"", 1980, "\"", 2002, 1);
#nullable restore
#line 42 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
WriteAttributeValue("", 1988, Model.Todo.Id, 1988, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        <h2>Who will do this Work?</h2>\r\n\r\n        <label for=\"worker\"> Add worker: </label>\r\n        <select name=\"AsigneeId\" id=\"AsigneeId\" asp-for=\"AsigneeId\">\r\n");
#nullable restore
#line 48 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
             foreach (var worker in Model.Asignees)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <option");
                BeginWriteAttribute("value", " value=\"", 2265, "\"", 2283, 1);
#nullable restore
#line 50 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
WriteAttributeValue("", 2273, worker.Id, 2273, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
                                      Write(worker.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 51 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </select>\r\n        <div class=\"form-group row\">\r\n            <div class=\"col-10\">\r\n\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit\" />\r\n                </div>\r\n            </div>\r\n    </form>\r\n");
#nullable restore
#line 61 "C:\Users\karol\Desktop\Repos\OndrejForal\week-08\day-01\FirstDbExercise\Views\Home\EditInDatabase.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
        <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    </div>
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
