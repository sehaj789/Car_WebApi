#pragma checksum "C:\Users\atind\Downloads\Web_API_Car-master\Web_API_Car-master\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db49253f2213de4e6991eb330ba9da812df995f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(AspNetCore.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db49253f2213de4e6991eb330ba9da812df995f", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(10, 60, true);
            WriteLiteral("<!DOCTYPE html>\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
            EndContext();
            BeginContext(70, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abf118dcb444443d829c010c087ca825", async() => {
                BeginContext(76, 241, true);
                WriteLiteral("\n    <title>Cars</title>\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
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
            BeginContext(324, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(325, 9548, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21091e801e914c6481246d1aeeafa0c8", async() => {
                BeginContext(331, 9535, true);
                WriteLiteral(@"

    <div>
        <h2 style=""text-align:center"">Welcome to Car Information</h2>

    
        <div class=""container"">
            <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#createCar"">Add New Car</button>
            <div class=""row"" id=""cars"">
            </div>
        </div>
    </div>
    <script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.templates/beta1/jquery.tmpl.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
    <script>
        var uri = 'api/Cars';

        $(document).ready(function () {
            // Get All ");
                WriteLiteral(@"Cars
            $.getJSON(uri)
                .done(function (data) {

                    $(""#cardTemplate"").tmpl(data).appendTo(""#cars"");
                });
        });



        function getAllCars() {

               $.getJSON(uri)
                   .done(function (data) {

                       $(""#cars"").text("""");

                    $(""#cardTemplate"").tmpl(data).appendTo(""#cars"");
                });

        }

        function addCar() {
            var carMake = $('#make').val();
            var carModel = $('#model').val();
            var carYear = $('#year').val();
            var carPrice = $('#price').val();


            var car = {
                make: carMake,
                model: carModel,
                year: carYear,
                price: carPrice


            };

            $.ajax({
                type: ""POST"",
                url: uri,
                data: JSON.stringify(car),
                contentType: ""application/json; charset=utf-8""
            }).done(function (re");
                WriteLiteral(@"sponse) {
                $(""#result"").html(""Success"");
                getAllCars();
            }).fail(function (jqXHR, textStatus) {
                          $(""#result"").html(""An error occured. The Car was not added. Please check whether all the fields are present."");
               });




        }





        function updateCar() {
            var carMake = $('#carMake').val();
            var carModel = $('#carModel').val();
            var carYear = $('#carYear').val();
            var carPrice = $('#carPrice').val();
            var carId = $('#carId').val();


            var car = {
                make: carMake,
                model: carModel,
                year: carYear,
                price: carPrice,
                 id: carId


            };

            $.ajax({
                type: ""PUT"",
                url: uri+""/""+ $('#carId').val(),
                data: JSON.stringify(car),
                contentType: ""application/json; charset=utf-8""
            }).done(function (response) {");
                WriteLiteral(@"
                $(""#resultUpdate"").html(""Success"");
                getAllCars();
            }).fail(function (jqXHR, textStatus) {
                          $(""#resultUpdate"").html(""An error occured. The Car was not added. Please check whether all the fields are present."");
               });;




        }



        function remove(id) {


          var yes =  confirm(""Are you sure you want to delete this car?"");

            if (yes) {
                $.ajax({
                    type: ""DELETE"",
                    url: uri + ""/"" + id,

                }).done(function (response) {

                    getAllCars();
                });

            }


        }




        function showUpdateCarModal(id) {

             $.ajax({
                type: ""GET"",
                url: uri+""/""+id,
               contentType: ""application/json""
             }).done(function (response) {


                 $('#carMake').val(response.make) ;
                 $('#carModel').val(response.model);
              $('#c");
                WriteLiteral(@"arYear').val(response.year)
                 $('#carPrice').val(response.price);
                    $('#carId').val(response.id) ;

               
            });


        }
    </script>



    <script id=""cardTemplate"" type=""text/x-jquery-tmpl"">
        <div class=""col-lg-4"">
            <div class=""card border-secondary mb-3"">
                <img src="""" class=""card-img-top"" alt="""">
                <div class=""card-body"">
                    <h5 class=""card-title"">Year ${year}</h5>
                    <h5 class=""card-text"">Make ${make}</h5>
                    <h5 class=""card-text"">Model ${model}</h5>
                    <p class=""card-text"">Price $ ${price}</p>
                    <button  class=""btn btn-primary"" onclick=""showUpdateCarModal('${id}')"" data-toggle=""modal"" data-target=""#updateCar"">Edit</button>
                    <a href=""#"" class=""btn btn-danger"" onclick=""remove('${id}')"">Delete</a>
                </div>
            </div>
        </div>
    </script>



    <div class=""modal"" tabindex");
                WriteLiteral(@"=""-1"" role=""dialog"" id=""createCar"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Add New Car</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <form>
                        <div class=""form-group"">
                            <label for=""make"">Make</label>
                            <input type=""text"" class=""form-control"" id=""make"" aria-describedby=""emailHelp"" placeholder=""Make"">

                        </div>
                        <div class=""form-group"">
                            <label for=""model"">Model</label>
                            <input type=""text"" class=""form-control"" id=""model"" aria-describedby=""emailHelp"" placeholder=""Model"">

    ");
                WriteLiteral(@"                    </div>
                        <div class=""form-group"">
                            <label for=""year"">Year</label>
                            <input type=""number"" class=""form-control"" id=""year"" aria-describedby=""emailHelp"" placeholder=""Year"">

                        </div>
                        <div class=""form-group"">
                            <label for=""price"">Price</label>
                            <input type=""number"" class=""form-control"" id=""price"" aria-describedby=""emailHelp"" placeholder=""Year"">

                        </div>

                        <div class=""form-group"" id=""result"">


                        </div>
                        <button type=""button"" onclick=""addCar()"" class=""btn btn-primary"">Submit</button>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                </div>
            </div>
        </div>
");
                WriteLiteral(@"    </div>




    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""updateCar"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Update Car</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <form>

                        <div class=""form-group"">
                            
                            <input type=""hidden"" class=""form-control"" id=""carId"" aria-describedby=""emailHelp"" placeholder=""Make"">

                        </div>
                        <div class=""form-group"">
                            <label for=""make"">Make</label>
                            <input type=""text"" class=""form-control"" id=""carMake"" aria-describedby=""emailHelp"" placeho");
                WriteLiteral(@"lder=""Make"">

                        </div>
                        <div class=""form-group"">
                            <label for=""model"">Model</label>
                            <input type=""text"" class=""form-control"" id=""carModel"" aria-describedby=""emailHelp"" placeholder=""Model"">

                        </div>
                        <div class=""form-group"">
                            <label for=""year"">Year</label>
                            <input type=""number"" class=""form-control"" id=""carYear"" aria-describedby=""emailHelp"" placeholder=""Year"">

                        </div>
                        <div class=""form-group"">
                            <label for=""price"">Price</label>
                            <input type=""number"" class=""form-control"" id=""carPrice"" aria-describedby=""emailHelp"" placeholder=""Price"">

                        </div>

                        <div class=""form-group"" id=""resultUpdate"">


                        </div>
                        <button type=""button"" onclick=""u");
                WriteLiteral(@"pdateCar()"" class=""btn btn-primary"">Submit</button>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                </div>
            </div>
        </div>
    </div>
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
            BeginContext(9873, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
