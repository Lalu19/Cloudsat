#pragma checksum "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b77f3c086b2510b2636ee799205fc4d6f6d41e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\_ViewImports.cshtml"
using insiderwebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\_ViewImports.cshtml"
using insiderwebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Registration.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Registration.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b77f3c086b2510b2636ee799205fc4d6f6d41e3", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf626cbe0a966078192d4fadd540454e36c07af", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5 Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5-20 Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20-50 Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50-200 Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "250 Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Registration.cshtml"
  
    ViewBag.Title = "Registration";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .site-main {\r\n        min-height: 472px;\r\n        margin-top: 57px;\r\n    }\r\n\r\n    input[type=submit] {\r\n        background-color: #ffdd0f;\r\n        color: #000;\r\n        padding: 0 28px;\r\n        width: auto;\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 498px) and (max-width: 850px) {\r\n        svg {\r\n            vertical-align: middle;\r\n            margin-left: 136px !important;\r\n            margin-top: -62px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 200px) and (max-width: 497px) {\r\n        svg {\r\n            vertical-align: middle;\r\n            margin-left: 171px;\r\n            margin-top: -67px;\r\n            margin-right: 113px;\r\n        }\r\n    }\r\n  \r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 1000px) {
        img.weblogo {
            margin: 0px 0px -15px 0px !important;
            width: 89px;
        }
    }
</style>



<main id=""main"" class=""site-main"">
    <section class=""page-title layout-02"">
        <div class=""container"">
            <div class=""inner align-center"">
                <h1 class=""title"">Registration</h1>

            </div>
        </div>
    </section><!-- PAGE TITLE -->
    <div class=""site-content"">
        <div class=""container"">
            
                <div class=""field-input"">
                    <label for=""first_name"">First name*</label>
                    <input type=""text"" name=""first_name"" id=""first_name""");
            BeginWriteAttribute("value", " value=\"", 1662, "\"", 1670, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"First name\">\r\n                </div>\r\n                <div class=\"field-input\">\r\n                    <label for=\"last_name\">Last name*</label>\r\n                    <input type=\"text\" name=\"last_name\" id=\"last_name\"");
            BeginWriteAttribute("value", " value=\"", 1899, "\"", 1907, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Last name\">\r\n                </div>\r\n                <div class=\"field-input\">\r\n                    <label for=\"email\">Email*</label>\r\n                    <input type=\"text\" name=\"email\" id=\"email\"");
            BeginWriteAttribute("value", " value=\"", 2119, "\"", 2127, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Email\">\r\n                </div>\r\n                <div class=\"field-input\">\r\n                    <label for=\"password\">Phone Number*</label>\r\n                    <input type=\"text\" name=\"PhoneNumber\" id=\"PhoneNumber\"");
            BeginWriteAttribute("value", " value=\"", 2357, "\"", 2365, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Phone Number\">\r\n\r\n                </div>\r\n                <div class=\"field-input\">\r\n                    <label for=\"Country\">Country*</label>\r\n                    <input type=\"text\" name=\"Country\" id=\"Country\"");
            BeginWriteAttribute("value", " value=\"", 2590, "\"", 2598, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Country\">\r\n\r\n                </div>\r\n                <div class=\"field-input\">\r\n                    <label for=\"Company name\">Company Name*</label>\r\n                    <input type=\"text\" name=\"Company Name\" id=\"CompanyName\"");
            BeginWriteAttribute("value", " value=\"", 2837, "\"", 2845, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Company Name"">

                </div>
                <div class=""field-input"">

                    <label for=""Company size"">Company size*</label>
                    <select class=""form-control"" id=""Companysize"" type=""text"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b77f3c086b2510b2636ee799205fc4d6f6d41e39769", async() => {
                WriteLiteral("--Choose--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b77f3c086b2510b2636ee799205fc4d6f6d41e311267", async() => {
                WriteLiteral(" < 5 Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b77f3c086b2510b2636ee799205fc4d6f6d41e312458", async() => {
                WriteLiteral("5-20 Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b77f3c086b2510b2636ee799205fc4d6f6d41e313649", async() => {
                WriteLiteral("20-50 Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b77f3c086b2510b2636ee799205fc4d6f6d41e314841", async() => {
                WriteLiteral("50-200 Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b77f3c086b2510b2636ee799205fc4d6f6d41e316034", async() => {
                WriteLiteral(" >250 Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""field-input field-checkbox"">
                    <input type=""checkbox"" value=""yes"" id=""terms"" name=""terms"">
                    <label for=""terms"">I agree to the <a href=""#"" title=""Terms & conditions"">Terms & conditions</a></label>
                </div>
                <div class=""field-submit"">
                    <input type=""submit"" name=""submit"" id=""btn_save"" value=""Register"">
                </div>
            
        </div>
    </div><!-- SITE CONTENT -->
</main>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <script>\r\n       // var apps = \"");
#nullable restore
#line 118 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Registration.cshtml"
                 Write(ViewBag.apps);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n       // var terms = \"");
#nullable restore
#line 119 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Registration.cshtml"
                  Write(ViewBag.terms);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""

        $(""#btn_save"").click(function (e) {

            if ($(""#terms"").is("":checked"")) {

                var model = {
                    firstName: $.trim($(""#first_name"").val()),
                    lastName: $.trim($(""#last_name"").val()),
                    email: $.trim($(""#email"").val()),
                    phoneNumber: $.trim($(""#PhoneNumber"").val()),
                    country: $.trim($(""#Country"").val()),
                    companyName: $.trim($(""#CompanyName"").val()),
                    companysize: $.trim($(""#Companysize"").val()),
                   // term: Monthely,
                  //  applictions: apps,
                  //  termsAndconditions: False,


                }
               // console.log(model);
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 142 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Registration.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/SubscriptionAppliction/CreateSubscriptionAppliction"",
                    data: JSON.stringify(model),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        if (xhr.status === 200) {
                          //  console.log(data);
                            sweetAlert({
                                html: true,
                                title: ""Thank You"",
                                text: ""Thank You For Your Interst We Will Get Back TO Soon ..!"",
                                type: ""success""
                            }).then(function () {
                                window.location.href = ""/Home/Index"";
                            });
                        } else if (data.status === ""duplicate"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else if (data.");
                WriteLiteral(@"status === ""error"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else {
                            sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                        }
                    },
                    error: function (data) {
                        if (data.status == 401) {
                            window.location.replace('/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        } else if (data.status == 400) {
                            sweetAlert(""Validation Alert!"", ""Please check input data!"", ""warning"");
                        }
                    }

                });
            } else {
                alert(""Please Select Terms & conditions"");
            }

        });



    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
