#pragma checksum "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Termsandconditions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86efe960620451a3036c2ae7fe1cc6df55b5c03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Termsandconditions), @"mvc.1.0.view", @"/Views/Home/Termsandconditions.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Termsandconditions.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Termsandconditions.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86efe960620451a3036c2ae7fe1cc6df55b5c03", @"/Views/Home/Termsandconditions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf626cbe0a966078192d4fadd540454e36c07af", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Termsandconditions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Termsandconditions.cshtml"
  
    ViewBag.Title = "Termsandconditions";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
   // Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    p {\r\n        text-align: justify;\r\n    }\r\n    .heading {\r\n        margin: 0px auto 20px;\r\n    }\r\n\r\n    .spdt {\r\n        padding-top: 100px;\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 498px) and (max-width: 850px) {\r\n        svg {\r\n            vertical-align: middle;\r\n            margin-left: 136px !important;\r\n            margin-top: -62px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 200px) and (max-width: 497px) {\r\n        svg {\r\n            vertical-align: middle;\r\n            margin-left: 171px;\r\n            margin-top: -67px;\r\n            margin-right: 113px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 1000px) {
        img.weblogo {
            margin: 0px 0px -15px 0px !important;
            width: 89px;
        }
    }
   
</style>
<main id=""main"" class=""site-main"">
    <div class=""site-content pt0 pb0"">
        <section class=""section spdt"">
            <div class=""container"">
                <div class=""heading align-center"">
                    <h2 class=""heading-title size-l"" style=""color: #f06117;"">Terms & Conditions</h2>
                </div>
                <div class=""block-icon-box layout-01"">
                    <div class=""row"">

                        <p id=""contentpage""></p>

                    </div>
                </div>
            </div>
        </section>
       
    </div>
</main>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        getHometermcontentlist()\r\n        function getHometermcontentlist() {\r\n            $.ajax(\r\n                {\r\n                    url: \"");
#nullable restore
#line 73 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Termsandconditions.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/Termsandconditions/GetTermsandconditions"",
                    type: ""GET"",
                    success: function (data) {

                        for (var i = 0; i < data.data.length;i++) {
                            var textcontent = data.data[i][""termsandconditionText""];
                        }
                        $('#contentpage').html(textcontent);

                    },

                    error: function (err) {
                        console.log(err);

                    }
                }
            );

        }
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
