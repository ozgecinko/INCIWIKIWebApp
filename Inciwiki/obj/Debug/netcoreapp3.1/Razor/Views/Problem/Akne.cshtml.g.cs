#pragma checksum "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e0722077c6f20d4ec519bfa56773ba71ef4256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Problem_Akne), @"mvc.1.0.view", @"/Views/Problem/Akne.cshtml")]
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
#line 1 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\_ViewImports.cshtml"
using Inciwiki;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\_ViewImports.cshtml"
using Inciwiki.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e0722077c6f20d4ec519bfa56773ba71ef4256", @"/Views/Problem/Akne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be25498e2a493b2c5421ae0405af30f89690769", @"/Views/_ViewImports.cshtml")]
    public class Views_Problem_Akne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inciwiki.Models.IhtiyacIcerik>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
  
    ViewData["Title"] = "Akne Karşıtı";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- ======= Services Section ======= -->\r\n<section id=\"services\" class=\"services section-bg\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"section-title\">\r\n            <h2>Akne Karşıtı</h2>\r\n        </div>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
             if (item.Ihtiyac.IhtiyacAdi == "Akne Karşıtı")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n\r\n                    <div class=\"col\">\r\n\r\n\r\n                        <div class=\"icon-box\">\r\n                            <div class=\"icon\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8e0722077c6f20d4ec519bfa56773ba71ef42564667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
                                            WriteLiteral(Url.Content(item.Icerik.IcerikResmi));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                            <h4 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 773, "\"", 780, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 26 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Icerik.IcerikAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <p class=\"description\">");
#nullable restore
#line 27 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Icerik.Aciklamasi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Akne.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section><!-- End Services Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inciwiki.Models.IhtiyacIcerik>> Html { get; private set; }
    }
}
#pragma warning restore 1591
