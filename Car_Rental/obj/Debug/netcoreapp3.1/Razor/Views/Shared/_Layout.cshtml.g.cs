#pragma checksum "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f4146df0e8f537ec0f5e9c49582a949cea11406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f4146df0e8f537ec0f5e9c49582a949cea11406", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"136adde21f9a8b4f42e59c109d24c0cc29ce27a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f4146df0e8f537ec0f5e9c49582a949cea114063321", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width-device-width, initial-scale=1.0"" />
    <!--Bootstrap-->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl"" crossorigin=""anonymous"">
    <!-- Font Awesome CSS -->
    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css'>
    <title>Home</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f4146df0e8f537ec0f5e9c49582a949cea114064831", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color: #548b97;\">\r\n            <div class=\"container-fluid\">\r\n                <!--Navigation bar logo-->\r\n                <a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=", 828, "", 862, 1);
#nullable restore
#line 19 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 834, Url.Action("Index", "Home"), 834, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <img src=\"\\Pictures\\Logo\\car_rent_logo.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 928, "\"", 934, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                         width=""40"" height=""40"" class=""d-inline-block align-top"">
                    <span class=""text""
                          style=""font-family: 'Niconne', cursive;font-weight: bold; text-shadow: 2px 2px 4px #000000;"">
                        Car
                        Rental
                    </span>
                </a>

                <!--NavBar items-->
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"" style=""font-weight: bold;"">
                    <li class=""nav-item active"">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=", 1514, "", 1559, 1);
#nullable restore
#line 32 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1520, Url.Action("Listing", "CarCategories"), 1520, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Cars</a>\r\n                    </li>\r\n                    <li class=\"nav-item active\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 1690, "\"", 1732, 1);
#nullable restore
#line 35 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1697, Url.Action("Listing", "Locations"), 1697, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Locations</a>
                    </li>
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">About Us</a>
                    </li>
                    <li class=""nav-item active"">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2013, "\"", 2020, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-bs-toggle=""modal"" data-bs-target=""#contactModal"">Contact Us</a>
                    </li>
                </ul>

                <!--Login/Welcome-->
                <div class=""nav-item dropdown"" style=""padding-right: 7%;"">
                    <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavDarkDropdown""
                            aria-controls=""navbarNavDarkDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse"" id=""navbarNavDarkDropdown"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDarkDropdownMenuLink"" role=""button""
                                   data-bs-toggle=""dropdown"" aria-expanded=""false"">
                               ");
                WriteLiteral(@"     <span>User</span>
                                </a>
                                <ul class=""dropdown-menu"" aria-labelledby=""navbarDarkDropdownMenuLink"">
                                    <li><a class=""dropdown-item"" href=""Profile.html""><i class=""fa fa-user""></i> Profile</a></li>
                                    <li>
                                        <a class=""dropdown-item"" href=""#"">
                                            <img src=""\Pictures\SVGs\rent_logo.svg"">
                                            Reservations
                                        </a>
                                    </li>
                                    <li><a class=""dropdown-item"" href=""Settings.html""><i class=""fa fa-sliders""></i> Settings</a></li>
                                    <div class=""dropdown-divider""></div>
                                    <li><a href=""#"" class=""dropdown-item""><i class=""fa fa-sign-out""></i> Logout</a></li>
                                </ul>
      ");
                WriteLiteral("                      </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 79 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <!--Footer-->
    <footer class=""footer mt-auto py-3"" style=""background-color: #548b97;"">
        <div class=""container-fluid"" style=""color: white;"">
            &copy;
            <span id=""copyright"">
                <script>document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))</script>
            </span>
            Cojocaru Ion
        </div>
    </footer>

    <!--Modal contact us container-->
    <div class=""modal fade"" id=""contactModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""contactModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""form"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""contactModalLabel"" style=""font-size: 16pt;font-weight: bold;"">
                        Contact Us
                    </h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""");
                WriteLiteral(@"modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <!--Contact details list-->
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item"">
                            <strong>Email: </strong>
                            <a href=""mailto:kojocaru.ivan@gmail.com"" style=""text-decoration: none;"">&nbsp; kojocaru.ivan@gmail.com</a>
                        </li>
                        <li class=""list-group-item"">
                            <strong> Phone:</strong><span>&nbsp; 0-785-423-572</span>
                        </li>
                        <li class=""list-group-item"">
                            <strong>Address:</strong>
                            <span>&nbsp; Craiova, Romania</span>
                        </li>
                    </ul><br>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-s");
                WriteLiteral("econdary\" data-bs-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 128 "C:\Users\kojoc\Source\Repos\OutofSkills\CarRental---Web-APP\Car_Rental\Views\Shared\_Layout.cshtml"
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
