#pragma checksum "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\Checkout\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1a10ffce844825dabdca8bb3ee843382ef5280"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_index), @"mvc.1.0.view", @"/Views/Checkout/index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\A\Documents\Portfolio\newProjects\وظيفة برمجة الويب\backend\ProductsShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1a10ffce844825dabdca8bb3ee843382ef5280", @"/Views/Checkout/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8de1cb8153c7cb0704e85ceac043e38668028b", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BethanysPieShop.ViewModels.PieListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Continue to checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn fw-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #C87D52;color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/thanks"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
body {
  font-family: Arial;
  font-size: 17px;
  
}
#Checkout-form
{
  text-align: center;
}

* {
  box-sizing: border-box;
}

.row {
  display: -ms-flexbox; /* IE10 */
  display: flex;
  -ms-flex-wrap: wrap; /* IE10 */
  flex-wrap: wrap;
  margin: 0 -16px;
}

.col-25 {
  -ms-flex: 25%; /* IE10 */
  flex: 25%;
}

.col-50 {
  -ms-flex: 50%; /* IE10 */
  flex: 50%;
}

.col-75 {
  -ms-flex: 75%; /* IE10 */
  flex: 75%;
}

.col-25,
.col-50,
.col-75 {
  padding: 0 16px;
}

/*.container {
  background-color: #f2f2f2;
  padding: 5px 20px 15px 20px;*/
  /*border: 1px solid lightgrey;
  border-radius: 3px;*/
/*}*/

input[type=text] {
  width: 100%;
  margin-bottom: 20px;
  padding: 12px;/*
  border: 1px solid #ccc;
  border-radius: 20px;*/
}
input[type=email] {
  width: 100%;
  margin-bottom: 20px;
  padding: 12px;
  /*border: 1px solid #ccc;
  border-radius: 20px;*/
}
label {
  margin-bottom: 10px;
  display: block;
}

.icon-container {
 ");
            WriteLiteral(@" margin-bottom: 20px;
  padding: 7px 0;
  font-size: 24px;
}

.btn {
  background-color: #04AA6D;
  color: white;
  padding: 12px;
  margin: 10px 0;
  border: none;
  width: 100%;
  /*border-radius: 3px;*/
  cursor: pointer;
  font-size: 17px;
}

.btn:hover {
  background-color: #45a049;
}


hr {
  border: 1px solid lightgrey;
}

span.price {
  float: right;
  color: grey;
}

</style>
<div>
    <h1>Checkout Page</h1>
    <p>Your order has been received.</p>

    <div class=""d-flex justify-content-start flex-column gap-5"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e1a10ffce844825dabdca8bb3ee843382ef52807567", async() => {
                WriteLiteral(@"

            <div class=""row"">
                <div class=""col-50"">
                    <h3>Billing Address</h3>
                    <label for=""fname""><i class=""fa fa-user""></i> Full Name</label>
                    <input type=""text"" id=""fname"" name=""firstname"" placeholder=""John M. Doe"" required>
                    <label for=""email""><i class=""fa fa-envelope""></i> Email</label>
                    <input type=""email"" id=""email"" name=""email"" placeholder=""john@example.com"" required>
                    <label for=""adr""><i class=""fa fa-address-card-o""></i> Address</label>
                    <input type=""text"" id=""adr"" name=""address"" placeholder=""542 W. 15th Street"" required>
                    <label for=""city""><i class=""fa fa-institution""></i> City</label>
                    <input type=""text"" id=""city"" name=""city"" placeholder=""New York"" required>

                    <div class=""row"">
                        <div class=""col-50"">
                            <label for=""state"">State</label");
                WriteLiteral(@">
                            <input type=""text"" id=""state"" name=""state"" placeholder=""NY"" required>
                        </div>
                        <div class=""col-50"">
                            <label for=""zip"">Zip</label>
                            <input type=""text"" id=""zip"" name=""zip"" placeholder=""10001"" required>
                        </div>
                    </div>
                </div>

                <div class=""col-50"">
                    <h3>Payment</h3>
                    <label for=""fname"">Accepted Cards</label>
                    <div class=""icon-container"">
                        <i class=""fa fa-cc-visa"" style=""color:navy;""></i>
                        <i class=""fa fa-cc-amex"" style=""color:blue;""></i>
                        <i class=""fa fa-cc-mastercard"" style=""color:red;""></i>
                        <i class=""fa fa-cc-discover"" style=""color:orange;""></i>
                    </div>
                    <label for=""cname"">Name on Card</label>
             ");
                WriteLiteral(@"       <input type=""text"" id=""cname"" name=""cardname"" placeholder=""John More Doe"" required>
                    <label for=""ccnum"">Credit card number</label>
                    <input type=""text"" id=""ccnum"" name=""cardnumber"" placeholder=""1111-2222-3333-4444"" required>
                    <label for=""expmonth"">Exp Month</label>
                    <input type=""text"" id=""expmonth"" name=""expmonth"" placeholder=""September"">
                    <div class=""row"">
                        <div class=""col-50"">
                            <label for=""expyear"">Exp Year</label>
                            <input type=""text"" id=""expyear"" name=""expyear"" placeholder=""2018"">
                        </div>
                        <div class=""col-50"">
                            <label for=""cvv"">CVV</label>
                            <input type=""text"" id=""cvv"" name=""cvv"" placeholder=""352"">
                        </div>
                    </div>
                </div>

            </div>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e1a10ffce844825dabdca8bb3ee843382ef528011117", async() => {
                    WriteLiteral("\r\n                Continue to checkout\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BethanysPieShop.ViewModels.PieListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
