#pragma checksum "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserFieldPermissionSet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2440ac7bf8b27edd58cef35e66e1a59a00aecb0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Permission_UserFieldPermissionSet), @"mvc.1.0.view", @"/Views/Page/Permission/UserFieldPermissionSet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Permission/UserFieldPermissionSet.cshtml", typeof(AspNetCore.Views_Page_Permission_UserFieldPermissionSet))]
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
#line 1 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserFieldPermissionSet.cshtml"
using System.Web;

#line default
#line hidden
#line 5 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserFieldPermissionSet.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 6 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserFieldPermissionSet.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2440ac7bf8b27edd58cef35e66e1a59a00aecb0b", @"/Views/Page/Permission/UserFieldPermissionSet.cshtml")]
    public class Views_Page_Permission_UserFieldPermissionSet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserFieldPermissionSet.cshtml"
  
    ViewBag.Title = "UserFieldPermissionSet";

#line default
#line hidden
#line 7 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserFieldPermissionSet.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   string moduleName = HttpUtility.UrlDecode(this.Context.Request.Query["moduleName"].ObjToStr());
   Guid userId = this.Context.Request.Query["userId"].ObjToGuid();
   int type = this.Context.Request.Query["type"].ObjToInt();

#line default
#line hidden
            BeginContext(451, 78, false);
#line 11 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Permission\UserFieldPermissionSet.cshtml"
Write(Html.Raw(frameFactory.GetUserFieldPermissionSetHTML(moduleName, userId, type)));

#line default
#line hidden
            EndContext();
            BeginContext(529, 2, true);
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
