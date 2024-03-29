#pragma checksum "C:\Users\Mojtaba\Desktop\TestLocalStorage\TestSavedData\Views\Vue\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16addff70d29290c5f9ce2bd0a3379483aeb6f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vue_Create), @"mvc.1.0.view", @"/Views/Vue/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vue/Create.cshtml", typeof(AspNetCore.Views_Vue_Create))]
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
#line 1 "C:\Users\Mojtaba\Desktop\TestLocalStorage\TestSavedData\Views\_ViewImports.cshtml"
using TestSavedData;

#line default
#line hidden
#line 2 "C:\Users\Mojtaba\Desktop\TestLocalStorage\TestSavedData\Views\_ViewImports.cshtml"
using TestSavedData.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16addff70d29290c5f9ce2bd0a3379483aeb6f85", @"/Views/Vue/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5517eee8e34c8cd7022419e8a020708324d403f", @"/Views/_ViewImports.cshtml")]
    public class Views_Vue_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5122, true);
            WriteLiteral(@"<div id=""app"">


    <button class=""btn btn-primary"" v-on:click=""showNewBugModal"">Add New Bug ... </button>

    <table class=""table"">
        <thead>
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Description</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr v-for=""(bug,index) in bugs"">
                <td>{{index+1}}</td>
                <td>{{bug.name}}</td>
                <td>{{bug.description}}</td>
                <td>
                    <button class=""btn btn-danger"" v-on:click=""ShowDeleteBugModal(bug,index)"">Remove</button>
                    <button class=""btn btn-warning"" v-on:click=""showeditmodal(bug,index)"">Edit</button>

                </td>
            </tr>
        </tbody>
    </table>


    <div class=""modal fade"" id=""AddBugModal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
               ");
            WriteLiteral(@" <div class=""modal-header"">
                    <h5 class=""modal-title"">Add New Bug</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""Name"">Name</label>
                        <input v-model=""name"" type=""text"" class=""form-control"" style=""width:100%"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""Description"">Description</label>
                        <input v-model=""description"" type=""text"" class=""form-control"" style=""width:100%"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
               ");
            WriteLiteral(@"     <button type=""button"" v-on:click=""addBugs"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""EditBugModal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Edit Bug</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""Name"">Name</label>
                        <input v-model=""name"" type=""text"" class=""form-control"" style=""width:100%"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""Descripti");
            WriteLiteral(@"on"">Description</label>
                        <input v-model=""description"" type=""text"" class=""form-control"" style=""width:100%"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" v-on:click=""editBugs"" class=""btn btn-primary"">Save Edited Feilds</button>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""DeleteBugModal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Delete Bug</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
    ");
            WriteLiteral(@"            <div class=""modal-body"">
                    <p class=""text-info"">Are You Sure Want To Delete This Record ?</p>
                    <div class=""form-group"">
                        <label for=""Name"">Name</label>
                        <input v-model=""name"" disabled=""disabled"" type=""text"" class=""form-control"" style=""width:100%"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""Description"">Description</label>
                        <input v-model=""description"" disabled=""disabled"" type=""text"" class=""form-control"" style=""width:100%"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" v-on:click=""removeBug(bug,index)"" class=""btn btn-primary"">Yes Delete It</button>
                </div>
            </div>
        </div>
    </div>
</di");
            WriteLiteral("v>");
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
