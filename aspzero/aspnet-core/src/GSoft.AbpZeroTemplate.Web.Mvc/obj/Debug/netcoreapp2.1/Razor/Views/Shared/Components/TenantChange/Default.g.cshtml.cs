#pragma checksum "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f09fd7621d46c90791575d792f9cb54835e1ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TenantChange_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TenantChange/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TenantChange/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TenantChange_Default))]
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
#line 1 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Resources;

#line default
#line hidden
#line 2 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Views.Shared.Components.TenantChange;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f09fd7621d46c90791575d792f9cb54835e1ca2", @"/Views/Shared/Components/TenantChange/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TenantChange_Default : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<TenantChangeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
  
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Views/Shared/Components/TenantChange/Default.js");

#line default
#line hidden
            BeginContext(312, 43, true);
            WriteLiteral("<span class=\"tenant-change-component\">\n    ");
            EndContext();
            BeginContext(356, 18, false);
#line 9 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
Write(L("CurrentTenant"));

#line default
#line hidden
            EndContext();
            BeginContext(374, 3, true);
            WriteLiteral(":\n\n");
            EndContext();
#line 11 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
     if (Model.Tenant != null)
    {

#line default
#line hidden
            BeginContext(414, 13, true);
            WriteLiteral("        <span");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 427, "\"", 453, 1);
#line 13 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
WriteAttributeValue("", 435, Model.Tenant.Name, 435, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(454, 9, true);
            WriteLiteral("><strong>");
            EndContext();
            BeginContext(464, 24, false);
#line 13 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
                                            Write(Model.Tenant.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(488, 17, true);
            WriteLiteral("</strong></span>\n");
            EndContext();
#line 14 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(526, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(541, 16, false);
#line 17 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
         Write(L("NotSelected"));

#line default
#line hidden
            EndContext();
            BeginContext(557, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 18 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(571, 18, true);
            WriteLiteral("\n    (<a href=\"#\">");
            EndContext();
            BeginContext(590, 11, false);
#line 20 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
            Write(L("Change"));

#line default
#line hidden
            EndContext();
            BeginContext(601, 13, true);
            WriteLiteral("</a>)\n</span>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebResourceManager WebResourceManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TenantChangeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
