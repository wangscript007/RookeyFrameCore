#pragma checksum "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\EditForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa258dd6564514044200123ed119a513daa06352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Common_EditForm), @"mvc.1.0.view", @"/Views/Page/Common/EditForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Common/EditForm.cshtml", typeof(AspNetCore.Views_Page_Common_EditForm))]
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
#line 1 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\EditForm.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 2 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\EditForm.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa258dd6564514044200123ed119a513daa06352", @"/Views/Page/Common/EditForm.cshtml")]
    public class Views_Page_Common_EditForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\EditForm.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   Guid moduleId = UIOperate.GetModuleIdByRequest(this.Context.Request);
   Guid? id = this.Context.Request.Query["id"].ObjToGuidNull();
   string gridId = this.Context.Request.Query["gridId"].ObjToStr();
   Guid? copyId = this.Context.Request.Query["copyId"].ObjToGuidNull(); //复制时被复制记录Id
   bool showTip = this.Context.Request.Query["tip"].ObjToInt() == 1;
   Guid? todoTaskId = this.Context.Request.Query["todoId"].ObjToGuidNull(); //待办任务ID
   Guid? formId = this.Context.Request.Query["formId"].ObjToGuidNull(); //表单ID

#line default
#line hidden
#line 12 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\EditForm.cshtml"
  
    ViewBag.Title = "EditForm";

#line default
#line hidden
            BeginContext(719, 119, false);
#line 15 "D:\.NET CORE\MyCode\OneDll\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\EditForm.cshtml"
Write(Html.Raw(frameFactory.GetEditFormHTML(moduleId, id, gridId, copyId, showTip, todoTaskId, formId, this.Context.Request)));

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
