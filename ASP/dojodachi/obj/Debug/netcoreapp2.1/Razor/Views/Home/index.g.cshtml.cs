#pragma checksum "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2aabc56cf5f8742a080f90162e9b7a73e4449d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2aabc56cf5f8742a080f90162e9b7a73e4449d4", @"/Views/Home/index.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(27, 603, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1900e39c4eef4ed5a38bd374c6464cc5", async() => {
                BeginContext(33, 590, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u""
        crossorigin=""anonymous"">
        <script src=""https://code.jquery.com/jquery-3.3.1.min.js""
  integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
  crossorigin=""anonymous""></script>
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Page Title</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
");
                EndContext();
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
            EndContext();
            BeginContext(630, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(634, 1478, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040314c830d14db2a6712cb7e5c92a1a", async() => {
                BeginContext(640, 39, true);
                WriteLiteral("\r\n    <h3 class=\"text-center\">Fullness:");
                EndContext();
                BeginContext(680, 20, false);
#line 17 "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml"
                                Write(ViewBag.pal.fullness);

#line default
#line hidden
                EndContext();
                BeginContext(700, 15, true);
                WriteLiteral("  |  Happiness:");
                EndContext();
                BeginContext(716, 21, false);
#line 17 "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml"
                                                                    Write(ViewBag.pal.happiness);

#line default
#line hidden
                EndContext();
                BeginContext(737, 11, true);
                WriteLiteral("  |  Meals:");
                EndContext();
                BeginContext(749, 17, false);
#line 17 "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml"
                                                                                                     Write(ViewBag.pal.meals);

#line default
#line hidden
                EndContext();
                BeginContext(766, 12, true);
                WriteLiteral("  |  Energy:");
                EndContext();
                BeginContext(779, 18, false);
#line 17 "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml"
                                                                                                                                   Write(ViewBag.pal.energy);

#line default
#line hidden
                EndContext();
                BeginContext(797, 137, true);
                WriteLiteral(" </h3>\r\n    <div class=\"container text-center\">\r\n        <link rel=\"icon\" href=\"data:;base64,iVBORw0KGgo=\">\r\n        <h4 class=\"message\">");
                EndContext();
                BeginContext(935, 18, false);
#line 20 "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml"
                       Write(ViewBag.pal.status);

#line default
#line hidden
                EndContext();
                BeginContext(953, 19, true);
                WriteLiteral("</h4>\r\n    </div>\r\n");
                EndContext();
#line 22 "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml"
     if(ViewBag.pal.status == "your pal is dead"){

#line default
#line hidden
                BeginContext(1024, 248, true);
                WriteLiteral("        <form id=\"restart\" action=\"restart\" method=\"post\" class=\"col-md-3 text-center\">\r\n            <input type=\"submit\" name=\"restart\" class=\"btn btn-primary\">\r\n        </form>\r\n        <script>\r\n        $(\".formdiv\").hide();\r\n        </script>\r\n");
                EndContext();
#line 29 "C:\Users\zach\Desktop\ASP\dojodachi\Views\Home\index.cshtml"
    }

#line default
#line hidden
                BeginContext(1279, 826, true);
                WriteLiteral(@"    <div class=""container text-center formdiv"">
        <form  action=""action"" method=""post"" class=""col-md-3 text-center"">
            <input id=""Action"" type=""submit"" name=""action"" value=""Feed"" class=""btn btn-primary"">
        </form>
        <form  action=""action"" method=""post"" class=""col-md-3 text-center"">
            <input id=""Action"" type=""submit"" name=""action"" value=""Sleep"" class=""btn btn-primary"">
        </form>
        <form  action=""action"" method=""post"" class=""col-md-3 text-center"">
            <input id=""Action"" type=""submit"" name=""action"" value=""Work"" class=""btn btn-primary"">
        </form>
        <form  action=""action"" method=""post"" class=""col-md-3 text-center"">
            <input id=""Action"" type=""submit"" name=""action"" value=""Play"" class=""btn btn-primary"">
        </form>
    </div>
");
                EndContext();
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
            EndContext();
            BeginContext(2112, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
