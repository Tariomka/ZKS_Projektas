#pragma checksum "C:\Users\Karolis\Desktop\Web\Cinema\Cinema\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d890222d86e343c9caed9754510aeca604664d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Projektas.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace Projektas.Pages.Shared
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
#line 1 "C:\Users\Karolis\Desktop\Web\Cinema\Cinema\Pages\_ViewImports.cshtml"
using Projektas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d890222d86e343c9caed9754510aeca604664d28", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d4637922306045accfac549a2df32f582c923e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d890222d86e343c9caed9754510aeca604664d285802", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\Karolis\Desktop\Web\Cinema\Cinema\Pages\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Projektas</title>\r\n");
                WriteLiteral(@"    <!-- Bootstrap -->
    <link href=""./bootstrap/css/bootstrap.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Animate.css -->
    <link href=""./animate.css/animate.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Font Awesome iconic font -->
    <link href=""./fontawesome/css/fontawesome-all.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Magnific Popup -->
    <link href=""./magnific-popup/magnific-popup.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Slick carousel -->
    <link href=""./slick/slick.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Fonts -->
    <link href='https://fonts.googleapis.com/css?family=Oswald:300,400,500,700' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700' rel='stylesheet' type='text/css'>
    <!-- Theme styles -->
    <link href=""./css/dot-icons.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""./css/theme.css"" rel=""stylesheet"" type=""text/css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d890222d86e343c9caed9754510aeca604664d288203", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    <header class=\"header header-horizontal header-view-pannel\" style=\"background-color: #ffcb08\">\r\n        <div class=\"container\">\r\n            <nav class=\"navbar\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d890222d86e343c9caed9754510aeca604664d288697", async() => {
                    WriteLiteral("\r\n                    <img src=\"./images/parts/forum-logo.png\" alt=\"Logo\">\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"">
                    <span class=""th-dots-active-close th-dots th-bars"">
                        <span></span>
                        <span></span>
                        <span></span>
                    </span>
                </button>
                <div class=""navbar-collapse"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item nav-item-arrow-down nav-hover-show-sub"">
                            <a class=""nav-link"" href=""#"">Homepage</a>
                            <div class=""nav-arrow""><i class=""fas fa-chevron-down""></i></div>
                            <ul class=""collapse nav"">
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""homepage-1.html"">Homepage 1</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""homepage-");
                WriteLiteral(@"2.html"">Homepage 2</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""homepage-3.html"">Homepage 3</a>
                                </li>
                            </ul>
                        </li>
                        <li class=""nav-item nav-item-arrow-down nav-hover-show-sub"">
                            <a class=""nav-link"" href=""#"" data-role=""nav-toggler"">Pages</a>
                            <div class=""nav-arrow""><i class=""fas fa-chevron-down""></i></div>
                            <ul class=""collapse nav"">
                                <li class=""nav-item nav-item-arrow-down nav-hover-show-sub"">
                                    <a class=""nav-link"" href=""#"" data-role=""nav-toggler"">Movies</a>
                                    <div class=""nav-arrow""><i class=""fas fa-chevron-down""></i></div>
                                    <ul class=""collapse nav"">
                   ");
                WriteLiteral(@"                     <li class=""nav-item"">
                                            <a class=""nav-link"" href=""movies-blocks.html"">Blocks - No Sidebar</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""movies-blocks-sidebar-right.html"">Blocks - Sidebar right</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""movies-posters.html"">Posters - No Sidebar</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""movies-posters-sidebar-right.html"">Posters - Sidebar right</a>
                                        </li>
                                        <li class=""nav-item"">
                                          ");
                WriteLiteral(@"  <a class=""nav-link"" href=""movies-list.html"">List - No Sidebar</a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""movie-info-sidebar-right.html"">Movie info</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""gallery.html"">Gallery</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""news-blocks-sidebar-right.html"">News</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""article-sidebar-right.html"">Article</a>
                                </li>
                                <li class=""na");
                WriteLiteral(@"v-item"">
                                    <a class=""nav-link"" href=""about-us.html"">About us</a>
                                </li>
                                <li class=""nav-item nav-item-arrow-down nav-hover-show-sub"">
                                    <a class=""nav-link"" href=""#"" data-role=""nav-toggler"">User pages</a>
                                    <div class=""nav-arrow""><i class=""fas fa-chevron-down""></i></div>
                                    <ul class=""collapse nav"">
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""sign-in.html"">Sign in</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""sign-up.html"">Sign up</a>
                                        </li>
                                    </ul>
                                </li>
                        ");
                WriteLiteral(@"        <li class=""nav-item nav-item-arrow-down nav-hover-show-sub"">
                                    <a class=""nav-link"" href=""#"" data-role=""nav-toggler"">Status pages</a>
                                    <div class=""nav-arrow""><i class=""fas fa-chevron-down""></i></div>
                                    <ul class=""collapse nav"">
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""under-construction.html"">Under construction</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""coming-soon.html"">Coming soon</a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""404-1.html"">404 - 1</a>
                                        </li>
                                 ");
                WriteLiteral(@"       <li class=""nav-item"">
                                            <a class=""nav-link"" href=""404-2.html"">404 - 2</a>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""movies-blocks.html"">Movies</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""contact-us.html"">Contact us</a>
                        </li>
                    </ul>
                    <div class=""navbar-extra"">
                        <a class=""btn-theme btn"" href=""#""><i class=""fas fa-ticket-alt""></i>&nbsp;&nbsp;Buy Ticket</a>
                    </div>
                </div>
            </nav>
        </div>
    </header>

    <div class=""container"">
        <main role=""main"" class=""pb-3"">
      ");
                WriteLiteral("      ");
#nullable restore
#line 168 "C:\Users\Karolis\Desktop\Web\Cinema\Cinema\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2021 - Projektas - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d890222d86e343c9caed9754510aeca604664d2818123", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </footer>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d890222d86e343c9caed9754510aeca604664d2819593", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d890222d86e343c9caed9754510aeca604664d2820693", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d890222d86e343c9caed9754510aeca604664d2821793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 180 "C:\Users\Karolis\Desktop\Web\Cinema\Cinema\Pages\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 182 "C:\Users\Karolis\Desktop\Web\Cinema\Cinema\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591