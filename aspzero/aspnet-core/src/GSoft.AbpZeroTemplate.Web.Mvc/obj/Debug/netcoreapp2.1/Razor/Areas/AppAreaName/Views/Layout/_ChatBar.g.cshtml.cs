#pragma checksum "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90f6817045db8a88e609ef45927d98ed62552590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Layout__ChatBar), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Layout/_ChatBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Layout/_ChatBar.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Layout__ChatBar))]
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
#line 1 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
using GSoft.AbpZeroTemplate.Chat;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f6817045db8a88e609ef45927d98ed62552590", @"/Areas/AppAreaName/Views/Layout/_ChatBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Layout__ChatBar : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("chatMessageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chatMessageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UserFriendTemplate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("x-tmpl-mustache"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UserChatMessageTemplate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 293, true);
            WriteLiteral(@"
<!-- begin::Quick Sidebar -->
<div id=""m_quick_sidebar"" class=""m-quick-sidebar m-quick-sidebar--tabbed m-quick-sidebar--skin-light"">
    <div class=""m-quick-sidebar__content m--hide"">
        <a href=""#"" id=""m_quick_sidebar_back"" class=""d-none"">
            <i class=""la la-arrow-circle-left""");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 327, "\"", 350, 1);
#line 7 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 340, L("Back"), 340, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(351, 116, true);
            WriteLiteral("></i>\n        </a>\n        <a href=\"javascript:;\" class=\"page-quick-sidebar-pinner\">\n            <i class=\"icon-pin\"");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 467, "\"", 489, 1);
#line 10 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 480, L("Pin"), 480, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(490, 126, true);
            WriteLiteral("></i>\n        </a>\n        <span id=\"m_quick_sidebar_close\" class=\"m-quick-sidebar__close\">\n            <i class=\"la la-close\"");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 616, "\"", 640, 1);
#line 13 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 629, L("Close"), 629, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(641, 398, true);
            WriteLiteral(@"></i>
        </span>
        <div class=""m-messenger m-messenger-friends m-messenger--skin-light"">
            <div class=""row"">
                <div class=""col-md-12"" style=""padding-top: 30px; margin: 5px; padding-right: 25px;"">
                    <div class=""m-input-icon m-input-icon--right"">
                        <input type=""text"" id=""ChatUserSearchUserName"" class=""form-control input-sm""");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1039, "\"", 1074, 1);
#line 19 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 1053, L("FilterOrAddUser"), 1053, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 275, true);
            WriteLiteral(@">
                        <span class=""m-input-icon__icon m-input-icon__icon--right"">
                            <span>
                                <i id=""InterTenantChatHintIcon"" class=""la la-info-circle"" data-toggle=""m-popover"" data-placement=""bottom"" data-html=""true""");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1350, "\"", 1383, 1);
#line 22 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 1358, L("ChatUserSearch_Hint"), 1358, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1384, 315, true);
            WriteLiteral(@"></i>
                            </span>
                        </span>
                    </div>
                </div>
                <div class=""col-md-12"" style=""margin: 5px; padding-right: 25px;"">
                    <button id=""SearchChatUserButton"" type=""button"" class=""btn btn-block btn-success d-none"">");
            EndContext();
            BeginContext(1700, 14, false);
#line 28 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                                                                                                        Write(L("AddFriend"));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 235, true);
            WriteLiteral("</button>\n                </div>\n            </div>\n            <div class=\"m-list-search\">\n                <div class=\"m-list-search__results\">\n                    <span class=\"m-list-search__result-category\">\n                        ");
            EndContext();
            BeginContext(1950, 12, false);
#line 34 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                   Write(L("Friends"));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 132, true);
            WriteLiteral("\n                    </span>\n                    <div id=\"friendListFriends\"></div>\n                    <p id=\"EmptyFriendListInfo\">");
            EndContext();
            BeginContext(2095, 25, false);
#line 37 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                                           Write(L("YouDontHaveAnyFriend"));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 230, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n            <div class=\"m-list-search\">\n                <div class=\"m-list-search__results\">\n                    <span class=\"m-list-search__result-category\">\n                        ");
            EndContext();
            BeginContext(2351, 17, false);
#line 43 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                   Write(L("BlockedUsers"));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 140, true);
            WriteLiteral("\n                    </span>\n                    <div id=\"friendListBlockeds\"></div>\n                    <p id=\"EmptyBlockedFriendListInfo\">");
            EndContext();
            BeginContext(2509, 32, false);
#line 46 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                                                  Write(L("YouDontHaveAnyBlockedFriend"));

#line default
#line hidden
            EndContext();
            BeginContext(2541, 785, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <div class=""m-scrollable m-messenger-conversation"" style=""display: none;"">
            <div class=""selected-chat-user"">
                <div class=""selected-chat-user-image"">
                    <img id=""selectedChatUserImage"" class=""media-object"">
                    <span id=""selectedChatUserStatus"" class=""contact-status2""></span>
                </div>
                <h6 id=""selectedChatUserName""></h6>
                <div class=""actions"">
                    <a class=""btn btn-metal m-btn m-btn--icon m-btn--icon-only m-btn--pill m-btn--air"" href=""javascript:;"" data-toggle=""dropdown"" data-hover=""dropdown"" data-close-others=""true"" aria-expanded=""false"">
                        <i class=""fa fa-angle-down""");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 3326, "\"", 3351, 1);
#line 59 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 3339, L("Expand"), 3339, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3352, 279, true);
            WriteLiteral(@"></i>
                    </a>
                    <ul class=""dropdown-menu pull-right"">
                        <li id=""liBanChatUser"">
                            <a href=""javascript:;"">
                                <i class=""fa fa-ban""></i>
                                ");
            EndContext();
            BeginContext(3632, 14, false);
#line 65 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                           Write(L("BlockUser"));

#line default
#line hidden
            EndContext();
            BeginContext(3646, 258, true);
            WriteLiteral(@"
                            </a>
                        </li>
                        <li id=""liUnbanChatUser"">
                            <a href=""javascript:;"">
                                <i class=""fa fa-check""></i>
                                ");
            EndContext();
            BeginContext(3905, 16, false);
#line 71 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                           Write(L("UnblockUser"));

#line default
#line hidden
            EndContext();
            BeginContext(3921, 412, true);
            WriteLiteral(@"
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <hr />
            <div class=""m-messenger m-messenger--message-arrow m-messenger--skin-light"">
                <div class=""m-messenger__messages"" id=""UserChatMessages"">
                </div>
                <div class=""m-messenger__seperator""></div>
                ");
            EndContext();
            BeginContext(4333, 3272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e69153bb51f44e481f685c5ae413870", async() => {
                BeginContext(4395, 247, true);
                WriteLiteral("\n                    <div id=\"files\" class=\"files\"></div>\n                    <div class=\"col-md-12\" style=\"margin: 5px; padding-right: 25px;\">\n                        <button id=\"UnblockUserButton\" type=\"button\" class=\"btn btn-block btn-success\">");
                EndContext();
                BeginContext(4643, 16, false);
#line 85 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                                                                                                  Write(L("UnblockUser"));

#line default
#line hidden
                EndContext();
                BeginContext(4659, 567, true);
                WriteLiteral(@"</button>
                    </div>

                    <div class=""col-md-12 chat-progress-bar"">
                        <div id=""chatFileUploadProgress"" class=""progress"">
                            <div class=""progress-bar progress-bar-success""></div>
                        </div>
                    </div>

                    <div class=""m-messenger__form"" id=""ChatMessageWrapper"">
                        <div class=""m-messenger__form-controls"">
                            <input id=""ChatMessage"" type=""text"" name=""message"" class=""m-messenger__form-input""");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 5226, "\"", 5262, 1);
#line 96 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 5240, L("TypeAMessageHere"), 5240, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5263, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 5272, "\"", 5313, 1);
#line 96 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 5284, ChatMessage.MaxMessageLength, 5284, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5314, 328, true);
                WriteLiteral(@" />
                        </div>
                        <div class=""m-messenger__form-tools"">
                            <a id=""chatDropdownToggle"" href="""" class=""m-messenger__form-attachment select-media"" data-toggle=""dropdown"" tabindex=""-1"" aria-expanded=""false"">
                                <i class=""la la-paperclip""");
                EndContext();
                BeginWriteAttribute("aria-label", " aria-label=\"", 5642, "\"", 5667, 1);
#line 100 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
WriteAttributeValue("", 5655, L("Attach"), 5655, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5668, 438, true);
                WriteLiteral(@"></i>
                            </a>
                            <ul class=""dropdown-menu pull-right bottom-up"" role=""menu"">
                                <li>
                                    <a href=""javascript:;"">
                                        <span class=""fileinput-button"">
                                            <i class=""fa fa-camera"" aria-hidden=""true""></i>
                                            <span>");
                EndContext();
                BeginContext(6107, 10, false);
#line 107 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                                             Write(L("Image"));

#line default
#line hidden
                EndContext();
                BeginContext(6117, 658, true);
                WriteLiteral(@"</span>
                                            <!-- The file input field used as target for the file upload widget -->
                                            <input id=""chatImageUpload"" type=""file"" name=""files"">
                                        </span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:;"">
                                        <span class=""fileinput-button"">
                                            <i class=""fa fa-file"" aria-hidden=""true""></i>
                                            <span>");
                EndContext();
                BeginContext(6776, 9, false);
#line 117 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                                             Write(L("File"));

#line default
#line hidden
                EndContext();
                BeginContext(6785, 595, true);
                WriteLiteral(@"</span>
                                            <!-- The file input field used as target for the file upload widget -->
                                            <input id=""chatFileUpload"" type=""file"" name=""files"">
                                        </span>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:;"" id=""btnLinkShare"">
                                        <i class=""fa fa-link"" aria-hidden=""true""></i>
                                        <span>");
                EndContext();
                BeginContext(7381, 22, false);
#line 126 "C:\Users\USER\Desktop\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Layout\_ChatBar.cshtml"
                                         Write(L("LinkToCurrentPage"));

#line default
#line hidden
                EndContext();
                BeginContext(7403, 195, true);
                WriteLiteral("</span>\n                                    </a>\n                                </li>\n                            </ul>\n                        </div>\n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7605, 82, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n<!-- end::Quick Sidebar -->\n\n");
            EndContext();
            BeginContext(7687, 1012, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee0582cb4f5c4a5a87d7925573a1379b", async() => {
                BeginContext(7742, 948, true);
                WriteLiteral(@"
    {{#.}}
    <a href=""#"" class=""m-list-search__result-item"" data-friend-tenant-id=""{{friendTenantId}}"" data-friend-user-id=""{{friendUserId}}"">
        <span class=""m-list-search__result-item-pic"">
            <img class=""m--img-rounded"" src=""{{profilePicturePath}}"" title="""">
        </span>
        <span class=""m-list-search__result-item-text"">
            {{shownUserName}}
        </span>

        {{#unreadMessageCount}}
        <span class=""m-badge m-badge--warning"">
            {{unreadMessageCount}}
        </span>
        {{/unreadMessageCount}}

        {{^unreadMessageCount}}
        <span class=""m-badge m-badge--warning d-none"">
            {{unreadMessageCount}}
        </span>
        {{/unreadMessageCount}}

        {{#isOnline}}
        <span class=""contact-status1 online""></span>
        {{/isOnline}}

        {{^isOnline}}
        <span class=""contact-status1 offline""></span>
        {{/isOnline}}
    </a>
    {{/.}}
");
                EndContext();
            }
            );
            __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
            __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8699, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(8701, 881, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7007c18a9f834d339db4091cfd3f7d5a", async() => {
                BeginContext(8761, 812, true);
                WriteLiteral(@"
    {{#.}}
    <div class=""m-messenger__message {{cssClass}}"">
        {{#isIn}}
        <div class=""m-messenger__message-pic"">
            <img src=""{{profilePicturePath}}"" alt="""" class=""mCS_img_loaded"">
        </div>
        {{/isIn}}
        <div class=""m-messenger__message-body"">
            <div class=""m-messenger__message-arrow""></div>
            <div class=""m-messenger__message-content"">
                <div class=""m-messenger__message-username"">
                    <span>{{shownUserName}}</span>
                    <time class=""timeago"" datetime=""{{creationTime}}""></time> {{{readStateCheck}}}
                </div>
                <div class=""m-messenger__message-text"">
                    {{{formattedMessage}}}
                </div>
            </div>
        </div>
    </div>
    {{/.}}
");
                EndContext();
            }
            );
            __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
            __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
