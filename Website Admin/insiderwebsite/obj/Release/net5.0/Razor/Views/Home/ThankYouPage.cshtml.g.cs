#pragma checksum "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\ThankYouPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f6954b7026608be38e6076baee1547532b4110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ThankYouPage), @"mvc.1.0.view", @"/Views/Home/ThankYouPage.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\ThankYouPage.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\ThankYouPage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f6954b7026608be38e6076baee1547532b4110", @"/Views/Home/ThankYouPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf626cbe0a966078192d4fadd540454e36c07af", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ThankYouPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\ThankYouPage.cshtml"
  
    ViewBag.Title = "Privacy Policy";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
    string ImageUrl = Configuration.GetValue<string>("WebImage");
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n            ");
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
