#pragma checksum "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\ImportModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "966f8bf3654be388d58417ecd21b8ff536ca679b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Common_ImportModel), @"mvc.1.0.view", @"/Views/Page/Common/ImportModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Common/ImportModel.cshtml", typeof(AspNetCore.Views_Page_Common_ImportModel))]
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
#line 4 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\ImportModel.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 5 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\ImportModel.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"966f8bf3654be388d58417ecd21b8ff536ca679b", @"/Views/Page/Common/ImportModel.cshtml")]
    public class Views_Page_Common_ImportModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\ImportModel.cshtml"
  
    ViewBag.Title = "ImportModel";

#line default
#line hidden
#line 6 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\ImportModel.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   Guid moduleId = UIOperate.GetModuleIdByRequest(this.Context.Request);

#line default
#line hidden
            BeginContext(264, 51, false);
#line 8 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\ImportModel.cshtml"
Write(Html.Raw(frameFactory.GetImportModelHTML(moduleId)));

#line default
#line hidden
            EndContext();
            BeginContext(315, 2, true);
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
