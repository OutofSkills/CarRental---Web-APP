#pragma checksum "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb61e61279226b14778fe97f5554a45a4c3d628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Security_Settings), @"mvc.1.0.view", @"/Views/Security/Settings.cshtml")]
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
#line 1 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\_ViewImports.cshtml"
using Car_Rental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\_ViewImports.cshtml"
using Car_Rental.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb61e61279226b14778fe97f5554a45a4c3d628", @"/Views/Security/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"136adde21f9a8b4f42e59c109d24c0cc29ce27a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Security_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("psw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("ChangeSettings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex flex-column min-vh-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb61e61279226b14778fe97f5554a45a4c3d6287034", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <!-- Font Awesome CSS -->
    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css'>
    <!--JQUERY-->
    <script src=""http://code.jquery.com/jquery-1.10.2.min.js""></script>
    <!--local CSS-->
    <link rel=""stylesheet"" href=""\css\SettingsStyle.css"">

    <title>User Settings</title>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb61e61279226b14778fe97f5554a45a4c3d6288471", async() => {
                WriteLiteral(@"
    <!--User Settings-->
    <div class=""container-fluid"" style=""padding-left: 12%;padding-top: 5%;"">
        <div class=""row gx-3 gy-3"">
            <!--User picture card-->
            <div class=""col-xl-4 col-lg-4 col-md-12 col-sm-12 col-12"">
                <div class=""card h-100"">
                    <div class=""card-body"">
                        <div class=""account-settings"">
                            <div class=""user-profile"">
                                <div class=""user-avatar"">
");
#nullable restore
#line 26 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                     if (Model.Image == null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img src=\"\\Pictures\\Avatars\\User_avatar_V2.png\"\r\n                                             alt=\"User\">\r\n");
#nullable restore
#line 30 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img class=\"rounded-circle\"");
                BeginWriteAttribute("src", " src=\"", 1483, "\"", 1559, 1);
#nullable restore
#line 33 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
WriteAttributeValue("", 1489, Url.Action("GetImage", "Customer", new { username = Model.UserName }), 1489, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                             alt=\"User\">\r\n");
#nullable restore
#line 35 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                                <h5 class=\"user-name\">");
#nullable restore
#line 37 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                                 Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <h6 class=\"user-email\">");
#nullable restore
#line 38 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                            </div>
                            <div class=""about"">
                                <h5>About</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--Settings card-->
            <div class=""col-md-6"">
                <div class=""card h-100"">
                    <div class=""card-body"">
                        <div class=""card-title"">Settings</div>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb61e61279226b14778fe97f5554a45a4c3d62812196", async() => {
                    WriteLiteral("\r\n                            <div class=\"container\">\r\n                                <div class=\"form-group\">\r\n");
#nullable restore
#line 55 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                     if (ViewBag.EditStatus == 1)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <div class=\"alert alert-success\">\r\n                                            ");
#nullable restore
#line 58 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 60 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                    }
                                    else if (ViewBag.EditStatus == 0)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <div class=\"alert alert-danger\">\r\n                                            ");
#nullable restore
#line 64 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 66 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                </div>
                                <div class=""row mb-2"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""email"">Email</label>
                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bbb61e61279226b14778fe97f5554a45a4c3d62814815", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 72 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""row mb-2"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""password"">Current Password</label>
                                            <input type=""password"" class=""form-control"" id=""password"" name=""currPassword"" placeholder=""Enter current password""
                                                   required>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row mb-2"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""psw"">Password</label>
           ");
                    WriteLiteral("                                 ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bbb61e61279226b14778fe97f5554a45a4c3d62818330", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 89 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Security\Settings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""row mb-2"">
                                    <div class=""col"">
                                        <div class=""form-group"">
                                            <label for=""confirmPass"">Confirm password</label>
                                            <input type=""password"" class=""form-control"" id=""confirm_psw"" placeholder=""Confirm password""
                                                   required>
                                        </div>
                                    </div>
                                </div>
                                <!--Submit/Cancel buttons-->
                                <div class=""row mb-2"">
                                    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
                                        <div class=""text-center"">
    ");
                    WriteLiteral(@"                                        <button type=""button"" id=""cancel"" name=""Cancel"" class=""btn btn-secondary"">Cancel</button>
                                            <button type=""submit"" id=""update"" name=""submit"" class=""btn btn-primary"">Update</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var password = document.getElementById(""psw"")
            , confirm_password = document.getElementById(""confirm_psw"");

        function validatePassword() {
            if (password.value != confirm_password.value) {
                confirm_password.setCustomValidity(""Passwords Don't Match"");
            } else {
                confirm_password.setCustomValidity('');
            }
        }

        password.onchange = validatePassword;
        confirm_password.onkeyup = validatePassword;
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591