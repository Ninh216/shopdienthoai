#pragma checksum "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Views\Chitietdonhangs\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5b81e710f525496821a0eab6a7e617f235911d46f17ad33c4ab5548b36473d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chitietdonhangs_Create), @"mvc.1.0.view", @"/Views/Chitietdonhangs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5b81e710f525496821a0eab6a7e617f235911d46f17ad33c4ab5548b36473d26", @"/Views/Chitietdonhangs/Create.cshtml")]
    #nullable restore
    public class Views_Chitietdonhangs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopPhone.Models.Chitietdonhang>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Views\Chitietdonhangs\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Chitietdonhang</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""MaSanPham"" class=""control-label""></label>
                <select asp-for=""MaSanPham"" class =""form-control"" asp-items=""ViewBag.MaSanPham""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""MaDon"" class=""control-label""></label>
                <select asp-for=""MaDon"" class =""form-control"" asp-items=""ViewBag.MaDon""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""SoLuong"" class=""control-label""></label>
                <input asp-for=""SoLuong"" class=""form-control"" />
                <span asp-validation-for=""SoLuong"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DonGia"" class=""");
            WriteLiteral(@"control-label""></label>
                <input asp-for=""DonGia"" class=""form-control"" />
                <span asp-validation-for=""DonGia"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 46 "C:\Users\PC\OneDrive\Desktop\MÃ NGUỒN MỞ\shopdienthoai-main\Views\Chitietdonhangs\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopPhone.Models.Chitietdonhang> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
