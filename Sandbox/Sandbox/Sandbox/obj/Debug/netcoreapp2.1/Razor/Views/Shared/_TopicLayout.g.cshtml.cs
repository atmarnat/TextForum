#pragma checksum "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_TopicLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb9a5dc75da45537765e6c5d8dc3d09c2e57acf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TopicLayout), @"mvc.1.0.view", @"/Views/Shared/_TopicLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TopicLayout.cshtml", typeof(AspNetCore.Views_Shared__TopicLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb9a5dc75da45537765e6c5d8dc3d09c2e57acf1", @"/Views/Shared/_TopicLayout.cshtml")]
    public class Views_Shared__TopicLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylesInput.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/menu.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pictures/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80px;height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 319, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "288e1a4b866540588356abf7a82993b1", async() => {
                BeginContext(33, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>");
                EndContext();
                BeginContext(121, 13, false);
#line 6 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_TopicLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(134, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 153, "\"", 196, 1);
#line 7 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_TopicLayout.cshtml"
WriteAttributeValue("", 160, Url.Content("~/css/stylesMenu.css"), 160, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(197, 42, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    ");
                EndContext();
                BeginContext(239, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6371dee440c4a0b837aceba835bd68f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(293, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(299, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c876603f5444580a53ee74ba1fd21cc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(335, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(346, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(348, 5443, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd4f9d57abe409189a308f6a37af117", async() => {
                BeginContext(354, 206, true);
                WriteLiteral("\r\n    <!-- Beginning of the header for all files -->\r\n    <div class=\"menuContainer\">\r\n        <div class=\"menuBlock\">\r\n            <!-- button gotten from W3Schools -->\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(560, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0357d2031e9d481292ff134ac6e29229", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(627, 527, true);
                WriteLiteral(@"
            </div>
            <div>
                <button onclick=""document.getElementById('id01').style.display='block'"" style=""width:auto;"">Login</button>

                <div id=""id01"" class=""modal"">

                    <form class=""modal-content animate"" action=""/action_page.php"">
                        <div class=""imgcontainer"">
                            <span onclick=""document.getElementById('id01').style.display='none'"" class=""close"" title=""Close Modal"">&times;</span>
                            ");
                EndContext();
                BeginContext(1154, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3cfdfb2e09a8406a9e3bb159b7fa0ddb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1215, 1481, true);
                WriteLiteral(@"
                        </div>

                        <div class=""container"">
                            <label for=""uname""><b>Username</b></label>
                            <input type=""text"" placeholder=""Enter Username"" name=""uname"" style=""width: 100%;padding: 12px 20px;margin: 8px 0;display: inline-block;border: 1px solid #ccc;box-sizing: border-box;"" required>

                            <label for=""psw""><b>Password</b></label>
                            <input type=""password"" placeholder=""Enter Password"" name=""psw"" style=""width: 100%;padding: 12px 20px;margin: 8px 0;display: inline-block;border: 1px solid #ccc;box-sizing: border-box;"" required>

                            <button type=""submit"">Login</button>
                            <label>
                                <input type=""checkbox"" checked=""checked"" name=""remember""> Remember me
                            </label>
                        </div>

                        <div class=""container"" style=""background-colo");
                WriteLiteral(@"r:#f1f1f1"">
                            <button type=""button"" onclick=""document.getElementById('id01').style.display='none'"" class=""cancelbtn"">Cancel</button>
                            <span class=""psw"">Forgot <a href=""#"">password?</a></span>
                        </div>
                    </form>
                </div>
                <!-- End of button-->
            </div>


        </div>
        <div class=""menuBlock"">
            ");
                EndContext();
                BeginContext(2697, 31, false);
#line 56 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_TopicLayout.cshtml"
       Write(RenderSection("pageName", true));

#line default
#line hidden
                EndContext();
                BeginContext(2728, 2126, true);
                WriteLiteral(@"
        </div>
        <div class=""menuBlock"">
            <!-- Start of menu-->
            <div class=""dropdown"" style=""float:right;"">
                <button class=""dropbtn"">Right</button>
                <div class=""dropdown-content"">
                    <a href=""#"">Link 1</a>
                    <a href=""#"">Link 2</a>
                    <a href=""#"">Link 3</a>
                </div>
            </div>
            <!-- end of menu -->
        </div>
    </div>

    <!-- End of the header for all files -->
    <!-- Begin messsagebox input -->
    <div style=""text-align: center""> Create Message</div>
    <form action=""/action_page.php"">
        <table width=""30%"" align=""center"" border=""1"">
            <tr>
                <td width=""25%"">Name</td>
                <td width=""75%""><input type=""text"" name=""fullname""><input type=""submit"" value=""Submit""><br></td>
            </tr>
            <tr>
                <td width=""25%"">namebox</td>
                <td width=""75%"">
         ");
                WriteLiteral(@"           <textarea rows=""4"" cols=""30""></textarea>
                </td>
            </tr>
            <tr>
                <td width=""25%"">files</td>
                <td width=""75%""><input type=""file""></td>
            </tr>
        </table>
    </form>
    <br />
    <!-- End messagebox input -->
    <!-- subsection top -->
    <hr />

    <div class=""ssContainer"">
        <div class=""ssHalf"" style=""text-align: left;"">
            <div class=""pagination"">
                <a href=""#"">&laquo;</a>
                <a href=""#"" class=""active"">1</a>
                <a href=""#"">2</a>
                <a href=""#"">3</a>
                <a href=""#"">4</a>
                <a href=""#"">5</a>
                <a href=""#"">&raquo;</a>
            </div>
        </div>
        <div class=""ssHalf"" style=""text-align: right;"">
            <input type=""textBar"" name=""search"" placeholder=""Search.."">
        </div>
    </div>

    <hr />
    <!-- end subsection -->
    <!-- Begin body content -->

");
                WriteLiteral("    <div class=\"containerBody\">\r\n        <div class=\"blockBody\">\r\n            ");
                EndContext();
                BeginContext(4855, 12, false);
#line 121 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Shared\_TopicLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4867, 917, true);
                WriteLiteral(@"
        </div>
    </div>

    <!-- End body content -->
    <!-- subsection bottom -->
    <hr />

    <div class=""ssContainer"">
        <div class=""ssHalf"" style=""text-align: left;"">
            <div class=""pagination"">
                <a href=""#"">&laquo;</a>
                <a href=""#"" class=""active"">1</a>
                <a href=""#"">2</a>
                <a href=""#"">3</a>
                <a href=""#"">4</a>
                <a href=""#"">5</a>
                <a href=""#"">&raquo;</a>
            </div>
        </div>
        <div class=""ssHalf"" style=""text-align: right;"">
            <button id=""deleteButton"">Delete</button>
            <button id=""reportButton"">Report</button>
        </div>
    </div>

    <hr />
    <!-- end subsection -->
    <!-- begin footer content -->
    <div align=""center""><button id=""myButton"">Home</button></div>

    <!-- End footer content -->
");
                EndContext();
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
            EndContext();
            BeginContext(5791, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
