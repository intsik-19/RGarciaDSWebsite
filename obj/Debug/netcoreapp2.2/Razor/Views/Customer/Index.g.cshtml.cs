#pragma checksum "C:\Users\user\Desktop\RGarciaDSWebsite\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fec6030af325c4452d943a3b14a9166087ae732"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "C:\Users\user\Desktop\RGarciaDSWebsite\Views\_ViewImports.cshtml"
using RGarciaDSWebsite;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\RGarciaDSWebsite\Views\_ViewImports.cshtml"
using RGarciaDSWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fec6030af325c4452d943a3b14a9166087ae732", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10439c06a26349a792f8e17c4e1da9a007cbcbbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\Desktop\RGarciaDSWebsite\Views\Customer\Index.cshtml"
  
    ViewData ["titles"] = "Client Information";

#line default
#line hidden
            BeginContext(56, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(63, 18, false);
#line 5 "C:\Users\user\Desktop\RGarciaDSWebsite\Views\Customer\Index.cshtml"
Write(ViewData["titles"]);

#line default
#line hidden
            EndContext();
            BeginContext(81, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            BeginContext(90, 1235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fec6030af325c4452d943a3b14a9166087ae7323796", async() => {
                BeginContext(96, 1222, true);
                WriteLiteral(@"
    <div class = ""form-group"">
        <input type=""text"" name=""firstName"" class=""form-control"" placeholder = ""First Name"" required>
    </div>
    <div class = ""form-group"">
        <input type=""text"" name=""lastName"" class=""form-control"" placeholder = ""Last Name"" required>
    </div>
    <div class = ""form-group"">
        <input type=""number"" name=""houseNumber"" class=""form-control"" placeholder = ""House Number"" required>
    </div>
    <div class = ""form-group"">
        <input type=""text"" name=""street"" class=""form-control"" placeholder = ""Street"" required>
    </div>
    <div class = ""form-group"">
        <input type=""text"" name=""city"" class=""form-control"" placeholder = ""City"" required>
    </div>
    <div class = ""form-group"">
        <input type=""text"" name=""province"" class=""form-control"" placeholder = ""Province"" required>
    </div>
    <div class = ""form-group"">
        <input type=""text"" name=""phone"" class=""form-control"" placeholder = ""Phone Number"" required>
    </div>
    <div cla");
                WriteLiteral("ss = \"form-group\">\r\n        <input type=\"text\" name=\"email\" class=\"form-control\" placeholder = \"email address\" required>\r\n    </div>\r\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Save\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
