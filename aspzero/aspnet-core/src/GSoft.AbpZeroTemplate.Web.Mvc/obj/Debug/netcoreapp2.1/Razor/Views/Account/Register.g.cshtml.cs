#pragma checksum "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dcd312402b6c408325a9ef959016dee600c2767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 2 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
using Abp.Extensions;

#line default
#line hidden
#line 3 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
using Abp.Json;

#line default
#line hidden
#line 4 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
using GSoft.AbpZeroTemplate.MultiTenancy;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dcd312402b6c408325a9ef959016dee600c2767", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<GSoft.AbpZeroTemplate.Web.Models.Account.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Account/Register.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-login__form m-form register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaScriptTagHelper __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaTagHelper __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                BeginContext(216, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(221, 138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eb20ce4b5804cd894efdaac0a3c4674", async() => {
                    BeginContext(229, 44, true);
                    WriteLiteral("\n        window.passwordComplexitySetting = ");
                    EndContext();
                    BeginContext(274, 70, false);
#line 9 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
                                      Write(Html.Raw(Model.PasswordComplexitySetting.ToJsonString(indented: true)));

#line default
#line hidden
                    EndContext();
                    BeginContext(344, 6, true);
                    WriteLiteral(";\n    ");
                    EndContext();
                }
                );
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(359, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(365, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c15ec2cf8920422c8acbe8e5dadb4609", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 12 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper.AppendVersion = __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(460, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(466, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha-script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e7e0cf92b63472daeea29f3c2708675", async() => {
                }
                );
                __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper = CreateTagHelper<global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaScriptTagHelper>();
                __tagHelperExecutionContext.Add(__PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(486, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(489, 111, true);
            WriteLiteral("\n<div class=\"m-login__signin\">\n    <div class=\"m-login__head\">\n        <h3 class=\"m-login__title\">\n            ");
            EndContext();
            BeginContext(601, 11, false);
#line 20 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
       Write(L("SignUp"));

#line default
#line hidden
            EndContext();
            BeginContext(612, 30, true);
            WriteLiteral("\n        </h3>\n    </div>\n    ");
            EndContext();
            BeginContext(642, 3039, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a27ac0d3eca843d7b1f97d6e3dc1e3c5", async() => {
                BeginContext(727, 2, true);
                WriteLiteral("\n\n");
                EndContext();
#line 25 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
         if (@ViewBag.ErrorMessage != null)
        {

#line default
#line hidden
                BeginContext(783, 91, true);
                WriteLiteral("            <div class=\"alert alert-danger\">\n                <i class=\"fa fa-warning\"></i> ");
                EndContext();
                BeginContext(875, 20, false);
#line 28 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(ViewBag.ErrorMessage);

#line default
#line hidden
                EndContext();
                BeginContext(895, 20, true);
                WriteLiteral("\n            </div>\n");
                EndContext();
#line 30 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
        }

#line default
#line hidden
                BeginContext(925, 52, true);
                WriteLiteral("\n        <input type=\"hidden\" name=\"IsExternalLogin\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 977, "\"", 1018, 1);
#line 32 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 985, Model.IsExternalLogin.ToString(), 985, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1019, 63, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"ExternalLoginAuthSchema\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1082, "\"", 1120, 1);
#line 33 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1090, Model.ExternalLoginAuthSchema, 1090, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1121, 52, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"SingleSignOn\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1173, "\"", 1200, 1);
#line 34 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1181, Model.SingleSignIn, 1181, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1201, 49, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"ReturnUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1250, "\"", 1274, 1);
#line 35 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1258, Model.ReturnUrl, 1258, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1275, 122, true);
                WriteLiteral(" />\n\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control placeholder-no-fix\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1397, "\"", 1421, 1);
#line 38 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1411, L("Name"), 1411, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1422, 21, true);
                WriteLiteral(" name=\"Name\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1443, "\"", 1462, 1);
#line 38 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1451, Model.Name, 1451, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1463, "\"", 1536, 1);
#line 38 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1475, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxNameLength, 1475, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1537, 136, true);
                WriteLiteral(" />\n        </div>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control placeholder-no-fix\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1673, "\"", 1700, 1);
#line 41 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1687, L("Surname"), 1687, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1701, 24, true);
                WriteLiteral(" name=\"Surname\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1725, "\"", 1747, 1);
#line 41 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1733, Model.Surname, 1733, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1748, "\"", 1824, 1);
#line 41 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1760, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxSurnameLength, 1760, 64, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1825, 137, true);
                WriteLiteral(" />\n        </div>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control placeholder-no-fix\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1962, "\"", 1994, 1);
#line 44 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1976, L("EmailAddress"), 1976, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1995, 29, true);
                WriteLiteral(" name=\"EmailAddress\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2024, "\"", 2051, 1);
#line 44 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2032, Model.EmailAddress, 2032, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2052, "\"", 2133, 1);
#line 44 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2064, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxEmailAddressLength, 2064, 69, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2134, 28, true);
                WriteLiteral(" />\n        </div>\n        \n");
                EndContext();
#line 47 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
         if (!Model.IsExternalLogin)
        {

#line default
#line hidden
                BeginContext(2209, 154, true);
                WriteLiteral("            <div class=\"form-group m-form__group\">\n                <input class=\"form-control placeholder-no-fix input-ltr\" type=\"text\" autocomplete=\"off\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2363, "\"", 2391, 1);
#line 50 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2377, L("UserName"), 2377, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2392, 16, true);
                WriteLiteral(" name=\"UserName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2408, "\"", 2431, 1);
#line 50 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2416, Model.UserName, 2416, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2432, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2441, "\"", 2518, 1);
#line 50 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2453, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxUserNameLength, 2453, 65, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2519, 193, true);
                WriteLiteral(" />\n            </div>\n            <div class=\"form-group m-form__group\">\n                <input class=\"form-control placeholder-no-fix\" type=\"password\" autocomplete=\"off\" id=\"RegisterPassword\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2712, "\"", 2740, 1);
#line 53 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2726, L("Password"), 2726, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2741, 196, true);
                WriteLiteral(" name=\"Password\" required />\n            </div>\n            <div class=\"form-group m-form__group\">\n                <input class=\"form-control placeholder-no-fix\" type=\"password\" autocomplete=\"off\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2937, "\"", 2971, 1);
#line 56 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2951, L("PasswordRepeat"), 2951, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2972, 54, true);
                WriteLiteral(" name=\"PasswordRepeat\" required />\n            </div>\n");
                EndContext();
#line 58 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
        }

#line default
#line hidden
                BeginContext(3036, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 60 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
         if (ViewBag.UseCaptcha)
        {

#line default
#line hidden
                BeginContext(3080, 59, true);
                WriteLiteral("            <p class=\"hint margin-top-20\">\n                ");
                EndContext();
                BeginContext(3140, 16, false);
#line 63 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
           Write(L("Captha_Hint"));

#line default
#line hidden
                EndContext();
                BeginContext(3156, 88, true);
                WriteLiteral("\n            </p>\n            <div class=\"form-group margin-bottom-20\">\n                ");
                EndContext();
                BeginContext(3244, 13, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66c505f0a04b498ba65894067d72787c", async() => {
                }
                );
                __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper = CreateTagHelper<global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaTagHelper>();
                __tagHelperExecutionContext.Add(__PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3257, 20, true);
                WriteLiteral("\n            </div>\n");
                EndContext();
#line 68 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
        }

#line default
#line hidden
                BeginContext(3287, 64, true);
                WriteLiteral("        \n        <div class=\"m-login__form-action\">\n            ");
                EndContext();
                BeginContext(3351, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab9d279711624a6683fd93158c481572", async() => {
                    BeginContext(3373, 110, true);
                    WriteLiteral("<button type=\"button\" id=\"register-back-btn\" class=\"btn btn-outline-primary  m-btn m-btn--pill m-btn--custom\">");
                    EndContext();
                    BeginContext(3484, 9, false);
#line 71 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
                                                                                                                                           Write(L("Back"));

#line default
#line hidden
                    EndContext();
                    BeginContext(3493, 9, true);
                    WriteLiteral("</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3506, 127, true);
                WriteLiteral("\n            <button type=\"submit\" id=\"register-submit-btn\" class=\"btn btn-primary m-btn m-btn--pill m-btn--custom m-btn--air\">");
                EndContext();
                BeginContext(3634, 11, false);
#line 72 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Register.cshtml"
                                                                                                                         Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(3645, 29, true);
                WriteLiteral("</button>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3681, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSoft.AbpZeroTemplate.Web.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
