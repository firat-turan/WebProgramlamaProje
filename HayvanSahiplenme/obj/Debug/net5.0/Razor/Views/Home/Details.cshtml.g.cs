#pragma checksum "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd6ce21a35ea4bf3e34571b83bfd22f0515f686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\_ViewImports.cshtml"
using HayvanSahiplenme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\_ViewImports.cshtml"
using HayvanSahiplenme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd6ce21a35ea4bf3e34571b83bfd22f0515f686", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3cc5d40e25f0a932fed647f4ee39b1c982b348", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HayvanSahiplenme.Models.Ilan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""page"">

    <div class=""colorlib-product"">
        <div class=""container"">
            <div class=""row row-pb-lg product-detail-wrap"">
                <div class=""col-sm-6"">
                    <div>
                        <div class=""item"">
                            <div class=""product-entry border"">

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dd6ce21a35ea4bf3e34571b83bfd22f0515f6864166", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                               WriteLiteral("/image/"+ Model.Fotograf);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
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
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"product-desc\">\r\n                        <h3>");
#nullable restore
#line 30 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                       Write(Html.DisplayFor(model => model.İlanBaslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n\r\n                        <table>\r\n                            <tr>\r\n                                <th><h5>İlan Tarihi :</h5></th>\r\n                                <th><h6>");
#nullable restore
#line 37 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Tarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th><h5>Tür :</h5></th>\r\n                                <th><h6>");
#nullable restore
#line 41 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Cins));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th><h5>Cins :</h5></th>\r\n                                <th><h6>");
#nullable restore
#line 45 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Cins));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th><h5>Yaş :</h5></th>\r\n                                <th><h6>");
#nullable restore
#line 49 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Yas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th><h5>Cinsiyet :</h5></th>\r\n                                <th><h6>");
#nullable restore
#line 53 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Cinsiyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></th>\r\n                            </tr>\r\n                            <tr>\r\n                                <th><h5>Aşı Durumu :</h5></th>\r\n                                <th><h6>");
#nullable restore
#line 57 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.AsiDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6></th>
                            </tr>
                        </table>


                        <div class=""row"">
                            <div class=""col-sm-12 text-center"">
                                <p class=""addtocart""><a href=""cart.html"" class=""btn btn-primary btn-addtocart""><i class=""icon-shopping-cart""></i> Add to Cart</a></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""row"">
                        <div class=""col-md-12 pills"">
                            <div class=""bd-example bd-example-tabs"">
                                <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">

                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" id=""pills-description-tab"" data-toggle=""pill"" href=""#pills-desc");
            WriteLiteral(@"ription"" role=""tab"" aria-controls=""pills-description"" aria-expanded=""true"">Açıklama</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" id=""pills-manufacturer-tab"" data-toggle=""pill"" href=""#pills-manufacturer"" role=""tab"" aria-controls=""pills-manufacturer"" aria-expanded=""true"">İlan Sahibi Bilgileri</a>
                                    </li>
                                </ul>

                                <div class=""tab-content"" id=""pills-tabContent"">
                                    <div class=""tab-pane border fade show active"" id=""pills-description"" role=""tabpanel"" aria-labelledby=""pills-description-tab"">
                                        <p>
                                            ");
#nullable restore
#line 89 "C:\Users\firat\Documents\GitHub\WebProgramlamaProje\HayvanSahiplenme\Views\Home\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>

                                    </div>

                                    <div class=""tab-pane border fade"" id=""pills-manufacturer"" role=""tabpanel"" aria-labelledby=""pills-manufacturer-tab"">
                                        <table>
                                            <tr>
                                                <th><h5>İlan Tarihi :</h5></th>
                                                <th><h6>01.01.2021</h6></th>
                                            </tr>
                                            <tr>
                                                <th><h5>Tür :</h5></th>
                                                <th><h6> Köpek</h6></th>
                                            </tr>
                                            <tr>
                                                <th><h5>Cins :</h5></th>
                                                <th><h6> Pekingese</h6></th>
                ");
            WriteLiteral(@"                            </tr>
                                            <tr>
                                                <th><h5>Yaş :</h5></th>
                                                <th><h6> 01.01.2021</h6></th>
                                            </tr>
                                            <tr>
                                                <th><h5>Cinsiyet :</h5></th>
                                                <th><h6> 01.01.2021</h6></th>
                                            </tr>
                                            <tr>
                                                <th><h5>Aşı Durumu :</h5></th>
                                                <th><h6> 01.01.2021</h6></th>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                ");
            WriteLiteral("    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HayvanSahiplenme.Models.Ilan> Html { get; private set; }
    }
}
#pragma warning restore 1591
