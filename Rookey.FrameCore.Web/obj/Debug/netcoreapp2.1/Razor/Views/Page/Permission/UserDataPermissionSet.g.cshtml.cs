#pragma checksum "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserDataPermissionSet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58503f183cf8f0a3b8b0f3ce33c8084847409f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Permission_UserDataPermissionSet), @"mvc.1.0.view", @"/Views/Page/Permission/UserDataPermissionSet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Permission/UserDataPermissionSet.cshtml", typeof(AspNetCore.Views_Page_Permission_UserDataPermissionSet))]
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
#line 1 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserDataPermissionSet.cshtml"
using System.Web;

#line default
#line hidden
#line 5 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserDataPermissionSet.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 6 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserDataPermissionSet.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58503f183cf8f0a3b8b0f3ce33c8084847409f5", @"/Views/Page/Permission/UserDataPermissionSet.cshtml")]
    public class Views_Page_Permission_UserDataPermissionSet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserDataPermissionSet.cshtml"
  
    ViewBag.Title = "UserDataPermissionSet";

#line default
#line hidden
#line 7 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserDataPermissionSet.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   string moduleName = HttpUtility.UrlDecode(this.Context.Request.Query["moduleName"].ObjToStr());
   Guid userId = this.Context.Request.Query["userId"].ObjToGuid();
   int type = this.Context.Request.Query["type"].ObjToInt();

#line default
#line hidden
            BeginContext(450, 77, false);
#line 11 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserDataPermissionSet.cshtml"
Write(Html.Raw(frameFactory.GetUserDataPermissionSetHTML(moduleName, userId, type)));

#line default
#line hidden
            EndContext();
            BeginContext(527, 2, true);
            WriteLiteral("\r\n");
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
