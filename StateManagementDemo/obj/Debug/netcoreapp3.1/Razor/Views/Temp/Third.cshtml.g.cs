#pragma checksum "C:\Users\lioni\OneDrive\Desktop\Lab Reports\6thsem\NCC\c#files\StateManagementDemo\StateManagementDemo\Views\Temp\Third.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d51616e7befe5390c3f868ef651d5d5187d5975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Temp_Third), @"mvc.1.0.view", @"/Views/Temp/Third.cshtml")]
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
#line 1 "C:\Users\lioni\OneDrive\Desktop\Lab Reports\6thsem\NCC\c#files\StateManagementDemo\StateManagementDemo\Views\_ViewImports.cshtml"
using StateManagementDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lioni\OneDrive\Desktop\Lab Reports\6thsem\NCC\c#files\StateManagementDemo\StateManagementDemo\Views\_ViewImports.cshtml"
using StateManagementDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d51616e7befe5390c3f868ef651d5d5187d5975", @"/Views/Temp/Third.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf25e1dc18771687a64fae06f3de8e08c2207d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Temp_Third : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\lioni\OneDrive\Desktop\Lab Reports\6thsem\NCC\c#files\StateManagementDemo\StateManagementDemo\Views\Temp\Third.cshtml"
  
    ViewData["Title"] = "Third";
    var userid = TempData["userid"]?.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("User ID: ");
#nullable restore
#line 8 "C:\Users\lioni\OneDrive\Desktop\Lab Reports\6thsem\NCC\c#files\StateManagementDemo\StateManagementDemo\Views\Temp\Third.cshtml"
    Write(userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Third</h1>");
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
