#pragma checksum "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\BatchEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6480272fa566b4b0e244c56398b3410468bcc6a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Common_BatchEdit), @"mvc.1.0.view", @"/Views/Page/Common/BatchEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Common/BatchEdit.cshtml", typeof(AspNetCore.Views_Page_Common_BatchEdit))]
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
#line 4 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\BatchEdit.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 5 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\BatchEdit.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6480272fa566b4b0e244c56398b3410468bcc6a6", @"/Views/Page/Common/BatchEdit.cshtml")]
    public class Views_Page_Common_BatchEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\BatchEdit.cshtml"
  
    ViewBag.Title = "BatchEdit";

#line default
#line hidden
#line 6 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\BatchEdit.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   Guid moduleId = UIOperate.GetModuleIdByRequest(this.Context.Request);
   int selectRecords = this.Context.Request.Query["selectRecords"].ObjToInt();
   int pageRecords = this.Context.Request.Query["pageRecords"].ObjToInt();

#line default
#line hidden
            BeginContext(418, 75, false);
#line 10 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\BatchEdit.cshtml"
Write(Html.Raw(frameFactory.GetBatchEditHTML(moduleId,selectRecords,pageRecords)));

#line default
#line hidden
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
