#pragma checksum "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a422fba425bacfd3df86056baca2630c7d8fad7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Login.cshtml", typeof(AspNetCore.Views_User_Login))]
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
#line 1 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\Login.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a422fba425bacfd3df86056baca2630c7d8fad7", @"/Views/User/Login.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\Login.cshtml"
  
    Layout = null;
    string webName = WebConfigHelper.GetCurrWebName();

#line default
#line hidden
            BeginContext(112, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(137, 374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4128ffba42a740daae41a42f1a783d2a", async() => {
                BeginContext(143, 91, true);
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n    <title>登录 | ");
                EndContext();
                BeginContext(235, 7, false);
#line 10 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\Login.cshtml"
           Write(webName);

#line default
#line hidden
                EndContext();
                BeginContext(242, 262, true);
                WriteLiteral(@"</title>
    <meta name=""renderer"" content=""webkit"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0"">
    <link rel=""stylesheet"" href=""/Scripts/login/login.css"" type=""text/css"">
");
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
            BeginContext(511, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(513, 1956, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb682c4d9152486ab23b9c8a142b98b0", async() => {
                BeginContext(519, 64, true);
                WriteLiteral("\r\n    <div class=\"page-con\">\r\n        <div><span id=\"logo-text\">");
                EndContext();
                BeginContext(584, 7, false);
#line 17 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\Login.cshtml"
                             Write(webName);

#line default
#line hidden
                EndContext();
                BeginContext(591, 1871, true);
                WriteLiteral(@"<label>v1.0<span class=""logo-dot rotate""></span></label></span></div>
        <div>
            <form name=""loginform"" id=""loginform"" method=""post"">
                <div style=""margin-top: 25px; position: relative;"">
                    <input name=""txtUserName"" id=""txtUserName"" value="""" class=""txt"" type=""text"" placeholder=""用户名"">
                    <div id=""usernameTip"" class=""error-tip""></div>
                </div>
                <div class=""login-input"" style=""margin-top: 20px; position: relative;"">
                    <input name=""txtPwd"" id=""txtPwd"" class=""txt"" type=""password"" placeholder=""密码"">
                    <a href=""/User/ForgetPwd.html"">忘记密码</a>
                    <div id=""pwdTip"" class=""error-tip""></div>
                </div>
                <div style=""margin-top: 20px;"">
                    <span id=""login_btn"" onclick=""DoLogin();"" class=""button"">立即登录</span>
                </div>
            </form>
        </div>
        <div class=""signup""><a href=""/User/Reg.html"">注册</a");
                WriteLiteral(@"></div>
        <div style=""margin: 20px 24px 0px 24px;display:none;"">
            <div class=""sep"">
                <div style=""margin-top: -9px;"">
                    <label>第三方账号登录</label></div>
            </div>
            <div style=""position: relative;"">
                <span id=""weixin_login"" onclick=""login.paltform.weixin()"" class=""icons weixin""></span>&nbsp;&nbsp;
                <span onclick=""login.paltform.login(&#39;qq&#39;)"" class=""icons qq""></span>&nbsp;&nbsp;
            </div>
        </div>
    </div>
    <div class=""weixin-con"" id=""weixin_dlg"">
        <div style=""margin-top: 200px;"">加载中...</div>
    </div>
    <script src=""/Scripts/jquery/jquery-1.8.0.min.js"" charset=""UTF-8"" type=""text/javascript""></script>
    <script src=""/Scripts/login/login.js"" charset=""UTF-8"" type=""text/javascript""></script>
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
            BeginContext(2469, 11, true);
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
