#pragma checksum "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Pricing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e58015bc7a744d548594f50a798a7b4cf9dac34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pricing), @"mvc.1.0.view", @"/Views/Home/Pricing.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Pricing.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Pricing.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e58015bc7a744d548594f50a798a7b4cf9dac34", @"/Views/Home/Pricing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf626cbe0a966078192d4fadd540454e36c07af", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Pricing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Pricing.cshtml"
  
    ViewBag.Title = "Pricing";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .full-plan .colspan-full {
        font-weight: 600;
        text-transform: uppercase;
        font-size: 18px;
    }

    .button.fullfield.priceing {
        height: 30px;
        border: 2px solid #0057fc;
        padding: 2px 28px;
        font-size: 13px;
        line-height: 1.5;
        border-radius: 30px;
        transition: all 0.3s;
        font-weight: 700;
    }

    tfoot#pricefooter {
        display: normal;
    }

    .full-plan .colspan-full:before {
        width: 18px;
        height: 18px;
        background-color: var(--sala-primary-navy, #0057fc);
    }
     ");
            WriteLiteral(@"@media (max-width: 1000px) {
        table .table-responsive td {
            display: block;
            text-align: center;
            position: relative;
            padding-left: 181px;
            font-size: small;
            white-space: initial;
        }

       

        div#roebutton {
            display: normal !important;
        }
    }

    ");
            WriteLiteral("@media (min-width: 1001px) and (max-width: 3900px) {\r\n        div#roebutton {\r\n            display: none !important;\r\n        }\r\n\r\n        img.weblogo {\r\n            margin: 0 0 0 80px !important;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 576px) {
        .container1 {
            margin-top: 0;
        }

       /* .full-plan tr.odd {
            background-color: #ffff;
        }*/

        .checkbox {
            margin-left: 0;
            margin-right: 0;
            height: 23px;
            width: auto;
            margin-top: -5px;
        }

        .pricing-box .badge-popular {
            font-size: 20px;
            line-height: 1.5;
            font-weight: 600;
            padding: 2px 20px;
            border-radius: 15px;
            background-color: #2555dd;
            color: var(--sala-alway-dark, #111111);
            text-transform: none;
            margin-left: 10px;
        }

        

        input.radiobutton {
            height: 23px;
            line-height: 16px;
            padding: 0;
            background-color: var(--sala-shade-background, #F8F9FC);
            color: var(--sala-neutral-dark, #111111);
            border: 0;
            cursor: pointe");
            WriteLiteral(@"r;
            border-radius: 3px;
            width: 8%;
        }

        table th,
        table td {
            padding: 10px 15px;
            font-weight: 600;
            white-space: nowrap;
        }

        .checkbutton {
            text-align: center;
            margin-bottom: 25px;
        }

        div#rbg {
            text-align: center;
            margin: 0;
        }

        .full-plan i {
            font-size: 20px;
        }

        .pricing-box .list li::before {
            font-size: 20px;
            margin-right: 10px;
        }
    }
   
</style>
<style>
    .container1 {
        margin-top: -117px;
    }

    

    .checkbox {
        margin-left: -180px;
        margin-right: -100px;
        height: 23px;
        width: -1px;
        margin-top: -5px;
    }

    .pricing-box .badge-popular {
        font-size: 29px;
        line-height: 1.5;
        font-weight: 600;
        padding: 2px 89px;
        -webkit-border-radi");
            WriteLiteral(@"us: 15px;
        -moz-border-radius: 15px;
        border-radius: 15px;
        background-color: #2555dd;
        color: var(--sala-alway-dark, #111111);
        text-transform: none;
        margin-left: 10px;
    }

    
    .priborder {
        border-bottom: 1px #111111 solid;
    }

    .page-title .title {
        font-size: 48px;
        line-height: 1.3;
        margin-top: 75px;
    }

    input.radiobutton {
        height: 23px;
        line-height: 16px;
        padding: 0px 0px;
        background-color: var(--sala-shade-background, #F8F9FC);
        color: var(--sala-neutral-dark, #111111);
        border: 0;
        cursor: pointer;
        border-radius: 3px;
        width: 4%;
    }

    table th, table td {
        padding: 16px 37px;
        font-weight: 600;
        white-space: nowrap;
    }

    .checkbutton {
        text-align: center;
        margin-bottom: 35px;
    }

    div#rbg {
        text-align: center;
        margin: 0px 0 40px ");
            WriteLiteral(@"0px;
    }

    .full-plan i {
        font-size: 24px;
        color: #020000;
    }

    .pricing-box .list li::before {
        content: ""\f00d"";
        font-family: ""Line Awesome Free"";
        font-weight: 900;
        color: #f8f9fc;
        font-size: 24px;
        margin-right: 16px;
    }
      /* Small screens */
    ");
            WriteLiteral(@"@media (max-width: 576px) {
        .container1 {
            margin-top: 0;
        }

        .checkbox {
            margin-left: 0;
            margin-right: 0;
            margin-top: 0;
        }

        .pricing-box .badge-popular {
            padding: 2px 20px;
            font-size: 20px;
        }

        .page-title .title {
            font-size: 48px;
            line-height: 1.3;
            margin-top: 75px;
        }

        input.radiobutton {
            /*width: 100%;*/
        }

        table th, table td {
            padding: 10px 20px;
            white-space: inherit;
        }
        .checkbutton {
            margin-bottom: 20px;
        }

        div#rbg {
            margin: 0;
        }
    }

    /* Medium screens */
    ");
            WriteLiteral(@"@media (min-width: 577px) and (max-width: 991px) {
        .container1 {
            margin-top: -50px;
        }

        .pricing-box .badge-popular {
            padding: 2px 40px;
            font-size: 24px;
        }

        .page-title .title {
            font-size: 48px;
            line-height: 1.3;
            margin-top: 75px;
        }

        table th,
        table td {
            padding: 12px 30px;
        }
    }

    /* Large screens */
    ");
            WriteLiteral(@"@media (min-width: 992px) {
        .container1 {
            margin-top: -117px;
        }

        .pricing-box .badge-popular {
            padding: 2px 89px;
            font-size: 29px;
        }

        .page-title .title {
            font-size: 48px;
            line-height: 1.3;
            margin-top: 75px;
        }
    }
</style>

<style>
    .text-nowrap {
        white-space: nowrap !important;
        font-weight: 600;
    }

    .btn-outline-primary {
        font-weight: 600;
        border-color: #0d6efd !important;
    }

    .btn {
        border-width: 2px;
        border-radius: 1.4rem;
    }

    .tm-feature-item {
        padding-top: 1rem;
        padding-bottom: 1rem;
    }

    input, textarea {
        height: 16px;
        line-height: 48px;
        padding: 0 16px;
        background-color: var(--sala-shade-background, #F8F9FC);
        color: var(--sala-neutral-dark, #111111);
        border: 0;
        -webkit-border-radius: 3px;
");
            WriteLiteral(@"        -moz-border-radius: 3px;
        border-radius: 3px;
        width: 100%;
    }

    .align-self-start {
        align-self: flex-start !important;
        padding-left: 17px;
        color: black;
    }

    .spdt {
        padding-top: 1px;
    }

    .page-title .title {
        font-size: 48px;
        line-height: 1.3;
        margin-top: 75px;
    }

    
    /* Small screens */
    ");
            WriteLiteral("@media (max-width: 576px) {\r\n        .page-title .title {\r\n            font-size: 48px;\r\n            line-height: 1.3;\r\n            margin-top: 75px;\r\n        }\r\n    }\r\n\r\n    \r\n    /* Medium screens */\r\n    ");
            WriteLiteral(@"@media (min-width: 577px) and (max-width: 991px) {
        .page-title .title {
            font-size: 48px;
            line-height: 1.3;
            margin-top: 75px;
        }

        element.style {
        }

        .table-responsive {
            overflow-x: auto;
            -webkit-overflow-scrolling: touch;
        }

        table {
            width: 100%;
        }
    }

    /* Large screens */
    ");
            WriteLiteral("@media (min-width: 992px) {\r\n        .page-title .title {\r\n            font-size: 48px;\r\n            line-height: 1.3;\r\n            margin-top: 75px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 200px) and (max-width: 1000px) {\r\n        table th, table td {\r\n            padding: 16px 37px;\r\n            font-weight: 600;\r\n            \r\n        }\r\n    }\r\n     ");
            WriteLiteral("@media (max-width: 576px) {\r\n        table th,\r\n        table td {\r\n            padding: 10px;\r\n            font-size: small;\r\n        }\r\n    }\r\n\r\n    /* Medium screens */\r\n    ");
            WriteLiteral("@media (min-width: 577px) and (max-width: 991px) {\r\n        table th,\r\n        table td {\r\n            padding: 10px;\r\n            font-size: small;\r\n        }\r\n    }\r\n\r\n    /* Large screens */\r\n    ");
            WriteLiteral(@"@media (min-width: 992px) {
        table th
         {
            padding: 10px;
            font-size: small;
        }

       
        table {
            width: 100%;
        }

        .full-plan thead tr .price {
            font-size: 16px;
            line-height: 1.5;
            font-weight: 400;
            color: var(--sala-neutral-normal, #555555);
            text-transform: none;
            margin-top: 4px;
        }

        table th {
            text-transform: uppercase;
            font-size: 18px;
            line-height: 1.44;
            font-weight: 500;
            border-bottom: 1px solid var(--sala-border-line, #eeeeee);
            color: var(--sala-neutral-dark, #111111);
        }
    }

    ");
            WriteLiteral("@media (min-width: 498px) and (max-width: 850px) {\r\n        svg {\r\n            vertical-align: middle;\r\n            margin-left: 136px !important;\r\n            margin-top: -62px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 200px) and (max-width: 497px) {\r\n        svg {\r\n            vertical-align: middle;\r\n            margin-left: 171px;\r\n            margin-top: -67px;\r\n            margin-right: 113px;\r\n        }\r\n    }\r\n\r\n \r\n    \r\n    ");
            WriteLiteral(@"@media (min-width: 200px) and (max-width: 497px) {
      .full-plan thead tr .price {
          font-size: 16px;
          line-height: 1.5;
          font-weight: 400;
          color: var(--sala-neutral-normal, #555555);
          text-transform: none;
          margin-top: 4px;
      }

       
        table th {
            text-transform: uppercase;
            font-size: 18px;
            line-height: 1.44;
            font-weight: 500;
            border-bottom: 1px solid var(--sala-border-line, #eeeeee);
            color: var(--sala-neutral-dark, #111111);
        }
    }
     
    ");
            WriteLiteral(@"@media (max-width: 992px){
        table.table-responsive thead {
            border: none;
            clip: rect(0 0 0 0);
            height: 1px;
            margin: -1px;
            overflow: hidden;
            padding: 0;
                    position: inherit;
                    width: 1px;
        }
    table.table-responsive {
            overflow-x: auto;
            -webkit-overflow-scrolling: touch;
        }

        table {
            width: 100%;
        }
        tr:nth-child(even){background-color: #f2f2f2}
        table th,
        table td {
            white-space: nowrap;
        }
            table.table-responsive tr {
                display: revert;
                margin-bottom: 0.625em;
            }

        table.table-responsive td {
            display: revert;
            text-align: inherit;
            position: initial;
            padding-left: 51px;
        }
    }
    ");
            WriteLiteral("@media (max-width: 1000px){\r\n      img.weblogo {\r\n          margin: 0px 0px -15px 0px !important;\r\n          width: 89px;\r\n      }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 992px) {
        table.table-responsive {
            overflow-x: auto;
            -webkit-overflow-scrolling: touch;
            display: inline-block;
        }
    }
</style>


<main id=""main"" class=""site-main"">
    <section class=""page-title"">
        <div class=""container"">
            <div class=""inner align-center"">
                <h1 class=""title"">
                    Behavior Analysis for
                    Insider Threat & Business Optimization
                </h1>

            </div>
        </div>
    </section><!-- PAGE TITLE -->
    <div class=""site-content"">

        <section class=""section-table spdt"">
            <div class=""container"">
                <div class=""heading align-center"">

                    <p class=""heading-desc"">Easy to switch, upgrade, or cancel at any time.</p>
                </div>
                
                <div id=""monthchange""></div>
                <table class=""full-plan table-responsive"">
              ");
            WriteLiteral(@"      <thead>
                        <tr id=""pricingFeatures"">
                        </tr>
                    </thead>
                    <tbody id=""pricingTab"">
                    </tbody>
                    <tfoot id=""pricefooter"">
                    </tfoot>
                </table>
            </div>
        </section>

    </div><!-- SITE CONTENT -->
</main>
<!-- END SITE MAIN -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            getPricing();
        });
    </script>

    <script>
        function changeSeq(seq) {
            var x = '';

            if (seq == 'monthly') {
                x = x + '<div id=""rbg""> <input type=""radio"" class=""radiobutton"" value=""\'monthly\'""  checked onclick=""changeSeq(\'monthly\')"" name=""seq"" ><span id=""monthly"" class=""text"">Monthly</span> <input  name=""seq"" type=""radio"" class=""radiobutton"" onclick=""changeSeq(\'quaterly\')""  value=""\'quaterly\'"" ><span id=""monthly"" class=""text"">Quarterly</span> <input  name=""seq"" type=""radio"" class=""radiobutton""   onclick=""changeSeq(\'halfyearly\')"" value=""\'halfyearly\'"" ><span id=""monthly"" class=""text"">Half Yearly</span><input  name=""seq"" type=""radio"" class=""radiobutton"" value=""\'yearLy\'"" onclick=""changeSeq(\'yearLy\')""  ><span id=""monthly"" class=""text"">Yearly</span></div>';
            } else if (seq == 'quaterly') {
                x = x + '<div id=""rbg""> <input type=""radio"" class=""");
                WriteLiteral(@"radiobutton"" value=""\'monthly\'""   onclick=""changeSeq(\'monthly\')"" name=""seq"" ><span id=""monthly"" class=""text"">Monthly</span> <input  name=""seq"" type=""radio"" checked class=""radiobutton"" onclick=""changeSeq(\'quaterly\')""  value=""\'quaterly\'"" ><span id=""monthly"" class=""text"">Quarterly</span> <input  name=""seq"" type=""radio"" class=""radiobutton""   onclick=""changeSeq(\'halfyearly\')"" value=""\'halfyearly\'"" ><span id=""monthly"" class=""text"">Half Yearly</span><input  name=""seq"" type=""radio"" class=""radiobutton"" value=""\'yearLy\'"" onclick=""changeSeq(\'yearLy\')""  ><span id=""monthly"" class=""text"">Yearly</span></div>';
            } else if (seq == 'halfyearly') {
                x = x + '<div id=""rbg""> <input type=""radio"" class=""radiobutton"" value=""\'monthly\'""   onclick=""changeSeq(\'monthly\')"" name=""seq"" ><span id=""monthly"" class=""text"">Monthly</span> <input  name=""seq"" type=""radio""  class=""radiobutton"" onclick=""changeSeq(\'quaterly\')""  value=""\'quaterly\'"" ><span id=""monthly"" class=""text"">Quarterly</span> <input ");
                WriteLiteral(@" name=""seq"" checked type=""radio"" class=""radiobutton""   onclick=""changeSeq(\'halfyearly\')"" value=""\'halfyearly\'"" ><span id=""monthly"" class=""text"">Half Yearly</span><input  name=""seq"" type=""radio"" class=""radiobutton"" value=""\'yearLy\'"" onclick=""changeSeq(\'yearLy\')""  ><span id=""monthly"" class=""text"">Yearly</span></div>';
            } else if (seq == 'yearLy') {
                x = x + '<div id=""rbg""> <input type=""radio"" class=""radiobutton"" value=""\'monthly\'""   onclick=""changeSeq(\'monthly\')"" name=""seq"" ><span id=""monthly"" class=""text"">Monthly</span> <input  name=""seq"" type=""radio""  class=""radiobutton"" onclick=""changeSeq(\'quaterly\')""  value=""\'quaterly\'"" ><span id=""monthly"" class=""text"">Quarterly</span> <input  name=""seq"" type=""radio"" class=""radiobutton""   onclick=""changeSeq(\'halfyearly\')"" value=""\'halfyearly\'"" ><span id=""monthly"" class=""text"">Half Yearly</span><input  name=""seq"" type=""radio"" class=""radiobutton"" value=""\'yearLy\'"" checked onclick=""changeSeq(\'yearLy\')""  ><span id=""monthly"" class=""");
                WriteLiteral(@"text"">Yearly</span></div>';
            }

            $('#monthchange').html(x);

            $.ajax({
                url: '/Home/Nodes',
                type: 'GET',
                dataType: 'json',
                success: function (response) {
                    $.ajax({
                        url: """);
#nullable restore
#line 606 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Pricing.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/PlanningAndApplication/GetPlanWisePricingForPricingPage"",
                        type: ""GET"",
                        success: function (data) {
                            var header = '<th>Features</th>';
                            for (var i = 0; i < data.length; i++) {
                                header = header + '<th><div class=""name"">' + data[i].planName + '</div><div class=""price"">₹' + data[i][seq] + ' / month</div></th>';
                            }
                            header = header + '<th><div class=""name"">Customize</div><div class=""price"">as you go / month</div></th>';
                            $('#pricingFeatures').html(header);

                            var htmlTab = '';
                            for (var h = 0; h < response.length; h++) {
                                htmlTab = htmlTab + '<tr class=""priborder""><td colspan=""' + data.length + '"" class=""colspan-full"">' + response[h].appName + '</td></tr>';
                                for (var t = 0; ");
                WriteLiteral(@"t < response[h].child.length; t++) {
                                    htmlTab = htmlTab + '<tr class=""odd""><td class=""title"" data-title=""Features"">' + response[h].child[t].appName + '</td>';
                                    for (var i = 0; i < data.length + 1; i++) {
                                        if (i == data.length) {
                                            htmlTab = htmlTab + '<td class=""is-active"" data-title=""Free""><i class=""las la-check""></i></td>';
                                        } else {
                                            var tr = 0;
                                            for (var j = 0; j < data[i]['applicationsPricings'].length; j++) {
                                                if (data[i]['applicationsPricings'][j]['applicationName'] == response[h].child[t].appName && data[i]['applicationsPricings'][j]['isAvailable'] == true) {
                                                    tr = 1;
                                                }
      ");
                WriteLiteral(@"                                      }
                                            if (tr == 1) {
                                                htmlTab = htmlTab + '<td class=""is-active""data-title=' + data[i].planName + '><i class=""las la-check""></i></td>';
                                            } else {
                                                htmlTab = htmlTab + '<td data-title=' + data[i].planName + '><i class=""las la-times""></i></td>';
                                            }
                                        }
                                    }
                                    htmlTab = htmlTab + '</tr>';
                                }
                            }
                            $('#pricingTab').html(htmlTab);
                        },
                        error: function (err) {
                            console.log(err);
                        }
                    });
                },
                error: function (xhr, stat");
                WriteLiteral(@"us, error) {
                    console.error(error);
                }
            });
        }

        function getPricing() {
            var x = '';

            x = x + '<div id=""rbg""> <input type=""radio"" class=""radiobutton"" value=""\'monthly\'""  checked onclick=""changeSeq(\'monthly\')"" name=""seq"" ><span id=""monthly"" class=""text"">Monthly</span> <input  name=""seq"" type=""radio"" class=""radiobutton"" onclick=""changeSeq(\'quaterly\')""  value=""\'quaterly\'"" ><span id=""monthly"" class=""text"">Quarterly</span> <input  name=""seq"" type=""radio"" class=""radiobutton""   onclick=""changeSeq(\'halfyearly\')"" value=""\'halfyearly\'"" ><span id=""monthly"" class=""text"">Half Yearly</span><input  name=""seq"" type=""radio"" class=""radiobutton"" value=""\'yearLy\'"" onclick=""changeSeq(\'yearLy\')""  ><span id=""monthly"" class=""text"">Yearly</span></div>';
            $('#monthchange').html(x);

            $.ajax({
                url: '/Home/Nodes',
                type: 'GET',
                dataType: 'json',
             ");
                WriteLiteral("   success: function (response) {\r\n                    $.ajax({\r\n                        url: \"");
#nullable restore
#line 666 "C:\Users\HP\OneDrive\Desktop\Deepak\cloudsat\Website Admin\insiderwebsite\Views\Home\Pricing.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/PlanningAndApplication/GetPlanWisePricingForPricingPage"",
                        type: ""GET"",
                        success: function (data) {
                            var header = '<th>Features</th>';
                            var footer = '<th></th>';
                            var fot = '<tr><td></td>';
                            for (var i = 0; i < data.length; i++) {
                                header = header + '<th><div class=""name"">' + data[i].planName + '</div><div class=""price"">₹' + data[i].monthly + ' / month</div></th>';
                                fot = fot + '<td><div class=""button-wrap""><a href=""../Home/Registration"" class=""button fullfield priceing"" title=""Get Started"">Start</a></div></td>';
                            }
                            fot = fot + '<td><div class=""button-wrap""><a href=""../Home/Coustmize"" class=""button fullfield priceing"" title=""Get Started"">Start</a></div></td></tr>';
                            $('#pricefooter').html(fot);
     ");
                WriteLiteral(@"                       header = header + '<th><div class=""name"">Customize</div><div class=""price"">as you go / month</div></th>';
                            $('#tfp').html(footer);
                            $('#pricingFeatures').html(header);

                            var htmlTab = '';
                            for (var h = 0; h < response.length; h++) {
                                htmlTab = htmlTab + '<tr class=""priborder""><td colspan=""' + (data.length + 1) + '"" class=""colspan-full"">' + response[h].appName + '</td></tr>';
                                for (var t = 0; t < response[h].child.length; t++) {
                                    htmlTab = htmlTab + '<tr class=""odd""><td class=""title"" data-title=""Features""><div class=""row""><div class=""col-md-6"">' + response[h].child[t].appName + '</div><div class=""col-md-6""></div></div></td>';
                                    for (var i = 0; i < data.length + 1; i++) {
                                        if (i == data.length) {
        ");
                WriteLiteral(@"                                    htmlTab = htmlTab + '<td class=""is-active"" data-title=""custom""><i class=""las la-check""></i></td>';
                                        } else {
                                            var tr = 0;
                                            for (var j = 0; j < data[i]['applicationsPricings'].length; j++) {
                                                if (data[i]['applicationsPricings'][j]['applicationName'] == response[h].child[t].appName && data[i]['applicationsPricings'][j]['isAvailable'] == true) {
                                                    tr = 1;
                                                }
                                            }
                                            if (tr == 1) {
                                                htmlTab = htmlTab + '<td class=""is-active"" data-title=' + data[i].planName + '><i class=""las la-check""></i></td>';
                                            } else {
                             ");
                WriteLiteral(@"                   htmlTab = htmlTab + '<td data-title=' + data[i].planName + '><i class=""las la-times""></i></td>';
                                                // $('#pricefooter').hide();
                                            }
                                        }
                                    }
                                    htmlTab = htmlTab + '</tr>';
                                }
                            }
                            $('#pricingTab').html(htmlTab);
                        },
                        error: function (err) {
                            console.log(err);
                        }
                    });
                },
                error: function (xhr, status, error) {
                    console.error(error);
                }
            });
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