#pragma checksum "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\ForgetPwd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc3e10913f73cbd7b922fe036d205d5c6e3dfd81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ForgetPwd), @"mvc.1.0.view", @"/Views/User/ForgetPwd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ForgetPwd.cshtml", typeof(AspNetCore.Views_User_ForgetPwd))]
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
#line 1 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\ForgetPwd.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc3e10913f73cbd7b922fe036d205d5c6e3dfd81", @"/Views/User/ForgetPwd.cshtml")]
    public class Views_User_ForgetPwd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\ForgetPwd.cshtml"
  
    Layout = null;
    string webName = WebConfigHelper.GetCurrWebName();

#line default
#line hidden
            BeginContext(112, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(137, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b20885ff0243e7a392f6dff7817f60", async() => {
                BeginContext(143, 95, true);
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n\r\n    <title>忘记密码 | ");
                EndContext();
                BeginContext(239, 7, false);
#line 11 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\ForgetPwd.cshtml"
             Write(webName);

#line default
#line hidden
                EndContext();
                BeginContext(246, 87, true);
                WriteLiteral("</title>\r\n    <link rel=\"stylesheet\" href=\"/Scripts/login/login.css\" type=\"text/css\">\r\n");
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
            BeginContext(340, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(342, 2490, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2038e95759af4e619c92ff43f9fcfe12", async() => {
                BeginContext(348, 128, true);
                WriteLiteral("\r\n    <canvas id=\"bg-canvas\" width=\"1366\" height=\"605\"></canvas>\r\n    <div class=\"page-con\">\r\n        <div><span id=\"logo-text\">");
                EndContext();
                BeginContext(477, 7, false);
#line 17 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\User\ForgetPwd.cshtml"
                             Write(webName);

#line default
#line hidden
                EndContext();
                BeginContext(484, 2341, true);
                WriteLiteral(@"<label>v1.0<span class=""logo-dot rotate""></span></label></span></div>
        <div>
            <div style=""margin-top: 25px; position: relative;"">
                <input name=""username"" id=""username"" value="""" class=""txt"" type=""text"" placeholder=""用户名"">
                <div class=""success-tip""></div>
                <div class=""error-tip"" id=""error-tip""></div>
                <input type=""hidden"" id=""forget_input"">
            </div>
            <div style=""margin-top: 20px;"">
                <span id=""resetpwd_btn"" onclick=""ForgetPwd();"" class=""button"">重置密码</span>
            </div>
        </div>
        <div class=""signup""><a href=""/User/Reg.html"">注册</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href=""/User/Login.html"">登录</a></div>
    </div>
    <script src=""/Scripts/jquery/jquery-1.8.0.min.js"" charset=""UTF-8"" type=""text/javascript""></script>
    <script type=""text/javascript"">
        //重置密码后向用户发送修改密码链接
        function ForgetPwd() {
            var username = $('#username').val();
            if (use");
                WriteLiteral(@"rname == """") {
                $('.error-tip').text(""用户不能为空！"");
                setTimeout(function () { $("".error-tip"").html("""") }, 3000);
                return;
            }
            $('.success-tip').hide();
            $.ajax({
                type: 'post',
                dataType: 'json',
                url: '/User/UserForgetPwd.html',
                data: { username: username },
                success: function (result) {
                    if (!result) {
                        $('.error-tip').text('服务器无响应，请重试！');
                        setTimeout(function () { $("".error-tip"").html("""") }, 3000);
                        return;
                    }
                    if (!result.Success) {
                        $('.error-tip').text(result.Message);
                        setTimeout(function () { $("".error-tip"").html("""") }, 3000);
                    } else {
                        $('.success-tip').show();
                        $('.success-tip').text('已经发送重置密码邮件 ");
                WriteLiteral(@"请查收');
                    }
                },
                error: function (err) {
                    $('.error-tip').text('服务器无响应，请重试！');
                    setTimeout(function () { $("".error-tip"").html("""") }, 3000);
                }
            });
        }
    </script>
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
            BeginContext(2832, 11, true);
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
