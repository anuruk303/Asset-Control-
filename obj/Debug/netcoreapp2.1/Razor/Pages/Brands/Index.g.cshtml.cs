#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c964ad6edefec8cae4c1d7aac3c1ca63eb4e1f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Brands.Pages_Brands_Index), @"mvc.1.0.razor-page", @"/Pages/Brands/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Brands/Index.cshtml", typeof(tbkk_AC.Pages.Brands.Pages_Brands_Index), null)]
namespace tbkk_AC.Pages.Brands
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\_ViewImports.cshtml"
using tbkk_AC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c964ad6edefec8cae4c1d7aac3c1ca63eb4e1f4", @"/Pages/Brands/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Brands_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modal-create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modal-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/alpacca2.jpg style="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("brandimage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("model-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 1429, true);
            WriteLiteral(@"
<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Asset Control</a>
            </li>
            <li class=""breadcrumb-item active"">Managment</li>
            <li class=""breadcrumb-item active"">Brand</li>
        </ol>
        <!-- DataTables Example -->
        <div class=""card mb-3"">
            <div class=""card-header"">
                <div class=""dataTable_length"">
                    <i class=""fas fa-table""> Brand</i>
                    <div style=""float: right"">
                        <button type=""button"" class=""btn btn-primary brands-modal"" data-toggle=""modal"" data-target=""#createBrandsModal"">
                            Create
                        </button>
                        <!--<a class=""btn btn-info"" asp-page=""Create"">Create New</a>-->
                        <button type=""button"" class=""btn btn-info"">Import data</butt");
            WriteLiteral(@"on>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>
                                    ");
            EndContext();
            BeginContext(1520, 52, false);
#line 38 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Brand[0].BrandID));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1688, 54, false);
#line 41 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Brand[0].BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1858, 50, false);
#line 44 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Brand[0].Image));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 383, true);
            WriteLiteral(@"
                                </th>
                                <th>
                                    Edit
                                </th>
                                <th>
                                    Delete
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 55 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                             foreach (var item in Model.Brand)
                            {

#line default
#line hidden
            BeginContext(2386, 136, true);
            WriteLiteral("                                <tr>\r\n                                    <td id=\"c1\" class=\"brands-modal\" data-toggle=\"modal\" data-id=\"");
            EndContext();
            BeginContext(2523, 12, false);
#line 58 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                                                                             Write(item.BrandID);

#line default
#line hidden
            EndContext();
            BeginContext(2535, 77, true);
            WriteLiteral("\" data-target=\"#detailBrandsModal\">\r\n                                        ");
            EndContext();
            BeginContext(2613, 42, false);
#line 59 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BrandID));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 143, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td id=\"c1\" class=\"brands-modal\" data-toggle=\"modal\" data-id=\"");
            EndContext();
            BeginContext(2799, 12, false);
#line 61 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                                                                             Write(item.BrandID);

#line default
#line hidden
            EndContext();
            BeginContext(2811, 77, true);
            WriteLiteral("\" data-target=\"#detailBrandsModal\">\r\n                                        ");
            EndContext();
            BeginContext(2889, 44, false);
#line 62 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(2933, 143, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td id=\"c1\" class=\"brands-modal\" data-toggle=\"modal\" data-id=\"");
            EndContext();
            BeginContext(3077, 12, false);
#line 64 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                                                                             Write(item.BrandID);

#line default
#line hidden
            EndContext();
            BeginContext(3089, 77, true);
            WriteLiteral("\" data-target=\"#detailBrandsModal\">\r\n                                        ");
            EndContext();
            BeginContext(3167, 40, false);
#line 65 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(3207, 270, true);
            WriteLiteral(@"
                                    </td>
                                    <td width=""5%"">
                                        <button  type=""button"" class=""btn btn-secondary btn-block brands-modal"" data-toggle=""modal"" data-target=""#editBrandsModal"" data-id=""");
            EndContext();
            BeginContext(3478, 12, false);
#line 68 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                                                                                                                                                       Write(item.BrandID);

#line default
#line hidden
            EndContext();
            BeginContext(3490, 276, true);
            WriteLiteral(@""">Edit</button>
                                    </td>
                                    <td width=""5%"">
                                        <button type=""button"" class=""btn btn-secondary brands-modal"" data-toggle=""modal"" data-target=""#deleteBrandsModal"" data-id=""");
            EndContext();
            BeginContext(3767, 12, false);
#line 71 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                                                                                                                                                              Write(item.BrandID);

#line default
#line hidden
            EndContext();
            BeginContext(3779, 101, true);
            WriteLiteral("\">Delete</button>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Anuruk\Desktop\tbkk-AC000\Pages\Brands\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3911, 992, true);
            WriteLiteral(@"                        </tbody>

                    </table>
                </div>
            </div>

        </div>
    </div>

    <footer class=""sticky-footer"">
        <div class=""container my-auto"">
            <div class=""copyright text-center my-auto"">
                <span>Copyright © Your Website 2019</span>
            </div>
        </div>
    </footer>
    <div></div>
</div>

<!--modal create-->
<div class=""modal fade"" id=""createBrandsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""createBrandsModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createBrandsModalLabel"">Create</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(4903, 900, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f088ad6bcc5b48cbaad7cf871cfdf167", async() => {
                BeginContext(4927, 869, true);
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Brand Name</label>
                        <input type=""text"" class=""form-control"" id=""createBrandName"" placeholder=""Enter Name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleFormControlFile1"">Example Image input</label>
                        <input type=""file"" class=""form-control-file"" id=""createBrandimage"">
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"" id=""createSave"">Save</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5803, 631, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<!--end modal create-->
<!--modal edit-->
<div class=""modal fade"" id=""editBrandsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""editBrandsModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editBrandsModalLabel"">Edit</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(6434, 1131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e7a44e31134b40be1ad8e86a6db1a5", async() => {
                BeginContext(6456, 1102, true);
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Brand ID</label>
                        <input readonly type=""text"" class=""form-control BrandedID"" id=""BrandedID"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Brand Name</label>
                        <input type=""text"" class=""form-control"" id=""BrandedName"" placeholder=""Enter Name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleFormControlFile1"">Example Image input</label>
                        <input type=""file"" class=""form-control-file"" id=""image"">
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn bt");
                WriteLiteral("n-primary\" id=\"assetsSave\">Save</button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7565, 640, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<!--end modal edit-->
<!--modal detail-->
<div class=""modal fade"" id=""detailBrandsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""detailBrandsModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""detailBrandsModalLabel"">details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(8205, 1007, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfc9366922b403ba394c2494ca0db8a", async() => {
                BeginContext(8230, 615, true);
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""row "">
                        <div class=""col-7"">
                            <label for=""assetIdLabel"">Brand ID</label>
                            <p class="" BrandedID"" id=""brandid""></p>
                            <br>
                            <label for=""assetNameLabel"">Asset Name</label>
                            <p id=""brandname""></p>
                        </div>
                        <div class=""col-3"">
                            <label for=""assetImgLabel"">Example Image</label>
                            ");
                EndContext();
                BeginContext(8845, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85f58ffc881547b1af056c89bbfcc467", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("width:", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("200px;", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("height:", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("200px;", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8930, 275, true);
                WriteLiteral(@"
                        </div>
                    </div>


                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9212, 1036, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<!--end modal detail-->
<!--modal del-->
<div class=""modal fade"" id=""deleteBrandsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""deleteBrandsModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""deleteBrandsModalLabel"">Edit</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ต้องการจะลบข้อมูลไหม
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""submit"" class=""btn btn-primary"" id=""brandsDelete"">Save</button>
            </div>
        </div>
    </div>
</div>
<!--end moda");
            WriteLiteral("l del-->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10266, 3593, true);
                WriteLiteral(@"
    <script>

        $(document).on(""click"", "".brands-modal"", function () {
            let id = $(this).data('id');
            $.get('/api/Brands/' + id, {}, (response) => {
                $("".modal-body #BrandedID"").val(id);
                $("".modal-body #BrandedName"").val(response.brandName);
                $("".modal-body #BrandedImage"").val(response.image);
                $(""#brandid"").text(id);
                $(""#brandname"").text(response.brandName);
                $(""#brandimage"").text(response.image);
            });
        });


        $(document).on(""submit"", ""#createBrandsModal #modal-create"", function (e) {
            e.preventDefault();
            var data = {
                BrandName: $("".modal-body #createBrandName"").val(),
                Image: $("".modal-body #createBrandimage"").val(),
            };

            $.ajax({
                type: 'POST',
                url: '/api/Brands',
                contentType: 'application/json',
                da");
                WriteLiteral(@"ta: JSON.stringify(data), // access in body
            }).done(function () {
                console.log('SUCCESS');
                location.reload();
            }).fail(function (msg) {
                console.log(data)
                console.log(msg);
                alert('FAIL');
            });

        });//create

        $(document).on(""submit"", ""#detailBrandsModal #model-details"", function (e) {
            e.preventDefault();

            var id = $("".modal-body #BrandedID"").val();
            var data = {
                BrandID: id,
                BrandName: $("".modal-body #BrandedName"").val(),
                Image: $("".modal-body #BrandedImage"").val(),
            };
            console.log('aaa');
            $.ajax({
                type: 'GET',
                url: '/api/Brands/' + id,
                contentType: 'application/json',
                data: JSON.stringify(data), // access in body
            }).done(function () {
                console.log('SUC");
                WriteLiteral(@"CESS');
                location.reload();
            }).fail(function (msg) {
                console.log('FAIL');
                alert('FAIL');
            });

        });//details


        $(document).on(""submit"", ""#editBrandsModal #modal-edit"", function (e) {
            e.preventDefault();

            var id = $("".modal-body #BrandedID"").val();
            var data = {
                BrandID: id,
                BrandName: $("".modal-body #BrandedName"").val(),
                Image: $("".modal-body #BrandedImage"").val(),
            }; console.log(data);

            $.ajax({
                type: 'PUT',
                url: '/api/Brands/' + id,
                contentType: 'application/json',
                data: JSON.stringify(data), // access in body
            }).done(function () {
                console.log('SUCCESS');
                location.reload();
            }).fail(function (msg) {
                console.log('FAIL');
                alert('FAIL');
     ");
                WriteLiteral(@"       });

        });//edit

        $(document).on(""click"", ""#brandsDelete"", function () {
            let id = $("".modal-body #BrandedID"").val();
            $.ajax({
                type: 'DELETE',
                url: '/api/Brands/' + id,
            }).done(function () {
                console.log('SUCCESS');
                location.reload();
            }).fail(function (msg) {
                console.log(msg);
                alert('FAIL');
            });
        });//del
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Brands.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Brands.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Brands.IndexModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Brands.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591