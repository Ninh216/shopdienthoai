#pragma checksum "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0400bd8b07d7875a3f893a78ec07d4af77898255426faea59ccc7cfd0d027cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
using ShopPhone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
using ShopPhone;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0400bd8b07d7875a3f893a78ec07d4af77898255426faea59ccc7cfd0d027cf4", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("vertical-layout vertical-menu 2-columns   menu-expanded fixed-navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-open", new global::Microsoft.AspNetCore.Html.HtmlString("click"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-menu", new global::Microsoft.AspNetCore.Html.HtmlString("vertical-menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-color", new global::Microsoft.AspNetCore.Html.HtmlString("bg-chartbg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-col", new global::Microsoft.AspNetCore.Html.HtmlString("2-columns"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
  
    var json = Context.Session.GetString("admin");
    Nhanvien nv = null;
    if (json != null)
        nv = JsonConvert.DeserializeObject<Nhanvien>(json);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
 if (Context.Session.GetString("admin") != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!DOCTYPE html>\n    <html class=\"loading\" lang=\"en\" data-textdirection=\"ltr\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0400bd8b07d7875a3f893a78ec07d4af77898255426faea59ccc7cfd0d027cf46628", async() => {
                WriteLiteral(@"
        <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
        <meta name=""description"" content=""Chameleon Admin is a modern Bootstrap 4 webapp &amp; admin dashboard html template with a large number of components, elegant design, clean and organized code."">
        <meta name=""keywords"" content=""admin template, Chameleon admin template, dashboard template, gradient admin template, responsive admin template, webapp, eCommerce dashboard, analytic dashboard"">
        <meta name=""author"" content=""ThemeSelect"">
        <title>Dashboard - Chameleon Admin - Modern Bootstrap 4 WebApp & Dashboard HTML Template + UI Kit</title>
        <link rel=""apple-touch-icon"" href=""/Data/theme-assets/images/ico/apple-icon-120.png"">
        <link rel=""shortcut icon"" type=""image/x-icon"" href=""/Data/theme-assets/images/ico/favicon.ico"">
       ");
                WriteLiteral(@" <link href=""https://fonts.googleapis.com/css?family=Muli:300,300i,400,400i,600,600i,700,700i%7CComfortaa:300,400,700"" rel=""stylesheet"">
        <link href=""https://maxcdn.icons8.com/fonts/line-awesome/1.1/css/line-awesome.min.css"" rel=""stylesheet"">
        <!-- BEGIN VENDOR CSS-->
        <link rel=""stylesheet"" type=""text/css"" href=""/Data/theme-assets/css/vendors.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""/Data/theme-assets/vendors/css/charts/chartist.css"">
        <!-- END VENDOR CSS-->
        <!-- BEGIN CHAMELEON  CSS-->
        <link rel=""stylesheet"" type=""text/css"" href=""/Data/theme-assets/css/app-lite.css"">
        <!-- END CHAMELEON  CSS-->
        <!-- BEGIN Page Level CSS-->
        <link rel=""stylesheet"" type=""text/css"" href=""/Data/theme-assets/css/core/menu/menu-types/vertical-menu.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""/Data/theme-assets/css/core/colors/palette-gradient.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""/Data/theme-assets/css/pages/dash");
                WriteLiteral("board-ecommerce.css\">\n        <!-- END Page Level CSS-->\n        <!-- BEGIN Custom CSS-->\n        <!-- END Custom CSS-->\n    ");
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
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0400bd8b07d7875a3f893a78ec07d4af77898255426faea59ccc7cfd0d027cf49943", async() => {
                WriteLiteral(@"

        <!-- fixed-top-->
        <nav class=""header-navbar navbar-expand-md navbar navbar-with-menu navbar-without-dd-arrow fixed-top navbar-semi-light"">
            <div class=""navbar-wrapper"">
                <div class=""navbar-container content"">
                    <div class=""collapse navbar-collapse show"" id=""navbar-mobile"">
                        <ul class=""nav navbar-nav mr-auto float-left"">
                            <li class=""nav-item d-block d-md-none""><a class=""nav-link nav-menu-main menu-toggle hidden-xs"" href=""#""><i class=""ft-menu""></i></a></li>
                            <li class=""nav-item d-none d-md-block""><a class=""nav-link nav-link-expand"" href=""#""><i class=""ficon ft-maximize""></i></a></li>
                            <li class=""nav-item dropdown navbar-search"">
                                <a class=""nav-link dropdown-toggle hide"" data-toggle=""dropdown"" href=""#""><i class=""ficon ft-search""></i></a>
                                <ul class=""dropdown-menu"">
                        ");
                WriteLiteral(@"            <li class=""arrow_box"">
                                        <form>
                                            <div class=""input-group search-box"">
                                                <div class=""position-relative has-icon-right full-width"">
                                                    <input class=""form-control"" id=""search"" type=""text"" placeholder=""Search here..."">
                                                    <div class=""form-control-position navbar-search-close""><i class=""ft-x"">   </i></div>
                                                </div>
                                            </div>
                                        </form>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <ul class=""nav navbar-nav float-right"">
                            <li class=""dropdown dropdown-language nav-item"">
                                <a class=""dro");
                WriteLiteral(@"pdown-toggle nav-link"" id=""dropdown-flag"" href=""#"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""flag-icon flag-icon-us""></i><span class=""selected-language""></span></a>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdown-flag"">
                                    <div class=""arrow_box""><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-us""></i> English</a><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-cn""></i> Chinese</a><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-ru""></i> Russian</a><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-fr""></i> French</a><a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-es""></i> Spanish</a></div>
                                </div>
                            </li>
                        </ul>
                        <ul class=""nav navbar-nav float-right"">
                            <li class=""dropdown dropdown-notification nav-item"">
");
                WriteLiteral(@"                                <a class=""nav-link nav-link-label"" href=""#"" data-toggle=""dropdown""><i class=""ficon ft-mail"">             </i></a>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <div class=""arrow_box_right""><a class=""dropdown-item"" href=""#""><i class=""ft-book""></i> Read Mail</a><a class=""dropdown-item"" href=""#""><i class=""ft-bookmark""></i> Read Later</a><a class=""dropdown-item"" href=""#""><i class=""ft-check-square""></i> Mark all Read       </a></div>
                                </div>
                            </li>
                            <li class=""dropdown dropdown-user nav-item"">
                                <a class=""dropdown-toggle nav-link dropdown-user-link"" href=""#"" data-toggle=""dropdown"">             <span class=""avatar avatar-online""><img src=""/Data/theme-assets/images/portrait/small/avatar-s-19.png"" alt=""avatar""><i></i></span></a>
                                <div class=""dropdown-menu dropdown-menu-righ");
                WriteLiteral("t\">\n                                    <div class=\"arrow_box_right\">\n                                        <a class=\"dropdown-item\" href=\"#\">");
#nullable restore
#line 90 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                                     Write(nv.TenNv);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                        <div class=""dropdown-divider""></div><a class=""dropdown-item"" href=""#""><i class=""ft-user""></i> Edit Profile</a><a class=""dropdown-item"" href=""#""><i class=""ft-mail""></i> My Inbox</a><a class=""dropdown-item"" href=""#""><i class=""ft-check-square""></i> Task</a><a class=""dropdown-item"" href=""#""><i class=""ft-message-square""></i> Chats</a>
                                        <div class=""dropdown-divider""></div><a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 7548, "\"", 7585, 1);
#nullable restore
#line 92 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7555, Url.Action("Logout", "Admin"), 7555, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""ft-power""></i> Logout</a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </nav>

        <!-- ////////////////////////////////////////////////////////////////////////////-->


        <div class=""main-menu menu-fixed menu-light menu-accordion    menu-shadow "" data-scroll-to-active=""true"" data-img=""/Data/theme-assets/images/backgrounds/02.jpg"">
            <div class=""navbar-header"">
                <ul class=""nav navbar-nav flex-row"">
                    <li class=""nav-item mr-auto"">
                        <a class=""navbar-brand"" href=""index.html"">
                            <img class=""brand-logo"" alt=""Chameleon admin logo"" src=""/Data/theme-assets/images/logo/logo.png"" />
                            <h3 class=""brand-text"">Chameleon</h3>
                        </a>
                    </li>
                    <li class=""n");
                WriteLiteral(@"av-item d-md-none""><a class=""nav-link close-navbar""><i class=""ft-x""></i></a></li>
                </ul>
            </div>
            <div class=""main-menu-content"">
                <ul class=""navigation navigation-main"" id=""main-menu-navigation"" data-menu=""menu-navigation"">
                    <li class=""active"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 8953, "\"", 8988, 1);
#nullable restore
#line 120 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8960, Url.Action("Home", "Admin"), 8960, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"ft-home\"></i><span class=\"menu-title\" data-i18n=\"\">Dashboard</span></a>\n                    </li>\n                    <li class=\" nav-item\">\n                        <a");
                BeginWriteAttribute("href", " href=\"", 9167, "\"", 9208, 1);
#nullable restore
#line 123 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9174, Url.Action("GetSanpham", "Admin"), 9174, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"ft-pie-chart\"></i><span class=\"menu-title\" data-i18n=\"\">Sản phẩm</span></a>\n                    </li>\n                    <li class=\" nav-item\">\n                        <a");
                BeginWriteAttribute("href", " href=\"", 9391, "\"", 9432, 1);
#nullable restore
#line 126 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9398, Url.Action("GetDonhang", "Admin"), 9398, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"ft-layers\"></i><span class=\"menu-title\" data-i18n=\"\">Đơn hàng</span></a>\n                    </li>\n                    <li class=\" nav-item\">\n                        <a");
                BeginWriteAttribute("href", " href=\"", 9612, "\"", 9655, 1);
#nullable restore
#line 129 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9619, Url.Action("GetKhachhang", "Admin"), 9619, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"ft-box\"></i><span class=\"menu-title\" data-i18n=\"\">Khách hàng</span></a>\n                </ul>\n                <div class=\"navigation-background\"></div>\n            </div>\n        </div>\n\n        ");
#nullable restore
#line 135 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!-- BEGIN VENDOR JS-->
        <script src=""/Data/theme-assets/vendors/js/vendors.min.js"" type=""text/javascript""></script>
        <!-- BEGIN VENDOR JS-->
        <!-- BEGIN PAGE VENDOR JS-->
        <script src=""/Data/theme-assets/vendors/js/charts/chartist.min.js"" type=""text/javascript""></script>
        <!-- END PAGE VENDOR JS-->
        <!-- BEGIN CHAMELEON  JS-->
        <script src=""/Data/theme-assets/js/core/app-menu-lite.js"" type=""text/javascript""></script>
        <script src=""/Data/theme-assets/js/core/app-lite.js"" type=""text/javascript""></script>
        <!-- END CHAMELEON  JS-->
        <!-- BEGIN PAGE LEVEL JS-->
        <script src=""/Data/theme-assets/js/scripts/pages/dashboard-lite.js"" type=""text/javascript""></script>
        <!-- END PAGE LEVEL JS-->
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </html>\n");
#nullable restore
#line 152 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\Shared\_Layout.cshtml"
}
else
    RenderBody();

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
