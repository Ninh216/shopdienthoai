#pragma checksum "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\AdminKhachhang\EditKH.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fbb615e8e920d48d956cb0a3ea14242ff96b452ebea03180e39a89f4359646f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminKhachhang_EditKH), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminKhachhang/EditKH.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fbb615e8e920d48d956cb0a3ea14242ff96b452ebea03180e39a89f4359646f7", @"/Areas/Admin/Views/AdminKhachhang/EditKH.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminKhachhang_EditKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopPhone.Models.Khachhang>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\AdminKhachhang\EditKH.cshtml"
  
    ViewData["Title"] = "EditKH";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Sửa thông tin khách hàng</h1>

<hr />
<div class=""app-content content"">
    <div class=""content-wrapper"">
        <div class=""content-wrapper-before""></div>
        <div class=""content-header row"">
            <div class=""content-header-left col-md-4 col-12 mb-2"">
                <h3 class=""content-header-title"">Tables</h3>
            </div>
            <div class=""content-header-right col-md-8 col-12"">
                <div class=""breadcrumbs-top float-md-right"">
                    <div class=""breadcrumb-wrapper mr-1"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item"">
                                <a href=""index.html"">Home</a>
                            </li>
                            <li class=""breadcrumb-item active"">
                                Tables
                            </li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-body"">
     ");
            WriteLiteral(@"       <!-- Basic Tables start -->
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4 class=""card-title"">Thêm khách hàng mới:</h4>
                            <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                            <div class=""heading-elements"">
                                <ul class=""list-inline mb-0"">
                                    <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                                    <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                                    <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                                    <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                                </ul>
                            </div>
                        </div>
                     ");
            WriteLiteral(@"   <div class=""card-content collapse show"">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-md-4"">
                                        <form asp-action=""EditKH"">
                                            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
                                            <input type=""hidden"" asp-for=""MaKhachHang"" />
                                            <div class=""form-group"">
                                                <label asp-for=""TenKhachHang"" class=""control-label""></label>
                                                <input asp-for=""TenKhachHang"" class=""form-control"" />
                                                <span asp-validation-for=""TenKhachHang"" class=""text-danger""></span>
                                            </div>
                                            <div class=""form-group"">
                                   ");
            WriteLiteral(@"             <label asp-for=""TaiKhoanKh"" class=""control-label""></label>
                                                <input asp-for=""TaiKhoanKh"" class=""form-control"" />
                                                <span asp-validation-for=""TaiKhoanKh"" class=""text-danger""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label asp-for=""MatKhau"" class=""control-label""></label>
                                                <input asp-for=""MatKhau"" class=""form-control"" />
                                                <span asp-validation-for=""MatKhau"" class=""text-danger""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label asp-for=""Sdt"" class=""control-label""></label>
                                                <input asp-for=""Sdt"" class=""form-contr");
            WriteLiteral(@"ol"" />
                                                <span asp-validation-for=""Sdt"" class=""text-danger""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label asp-for=""DiaChi"" class=""control-label""></label>
                                                <input asp-for=""DiaChi"" class=""form-control"" />
                                                <span asp-validation-for=""DiaChi"" class=""text-danger""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label asp-for=""Email"" class=""control-label""></label>
                                                <input asp-for=""Email"" class=""form-control"" />
                                                <span asp-validation-for=""Email"" class=""text-danger""></span>
                                            </div>
    ");
            WriteLiteral(@"                                        <div class=""form-group"">
                                                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                                            </div>
                                        </form>
                                    </div>
                                </div>
                                <div>
                                    <a asp-action=""GetKhachhang"">Quay lại</a>
                                </div>
                                ");
#nullable restore
#line 96 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Areas\Admin\Views\AdminKhachhang\EditKH.cshtml"
                           Write(Html.Raw(TempData["msgcreate"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div>
                                    <a asp-action=""Index"">Back to List</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopPhone.Models.Khachhang> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
