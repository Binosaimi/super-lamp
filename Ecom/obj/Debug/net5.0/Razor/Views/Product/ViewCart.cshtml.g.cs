#pragma checksum "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4efda721d4ee3c5b34d7322a62aa0529de298592"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ViewCart), @"mvc.1.0.view", @"/Views/Product/ViewCart.cshtml")]
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
#line 1 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/_ViewImports.cshtml"
using Ecom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/_ViewImports.cshtml"
using Ecom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4efda721d4ee3c5b34d7322a62aa0529de298592", @"/Views/Product/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c3fadc31313ce652e39d438410c6f9fa4e2ac4", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Database.Entities.ProductCart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
   ViewData["Title"] = "Products Cart"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    table {
        font-family: arial, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

    td, th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #dddddd;
    }

    .table thead th {
        width: 10%;
    }
</style>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.css"" integrity=""sha512-3pIirOrwegjM6erE5gPSwkUzO+3cTjpnV9lexlNZqvupR64iZBnOOTiiLPb9M36zpMScbmUNIcHUqKD47M719g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />


<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <h4 class=""text-center"">Your Cart</h4>
        </div>
    </div>
    <br />

    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""table-responsive"">
                <table class=""table table-responsive table-condensed table-hover"">
                    <thead>
                        <tr>
          ");
            WriteLiteral(@"                  <th scope=""col"">Product Name</th>
                            <th scope=""col"">Product Price</th>
                            <th scope=""col"">Qty</th>
                            <th scope=""col"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 49 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                          decimal totalBill = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                         foreach (var item in Model)
                        {
                            { totalBill = totalBill + (item.ProductPrice * item.qty); }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 54 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 55 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                           Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 56 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                           Write(item.qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1937, "\"", 1983, 2);
            WriteAttributeValue("", 1944, "/Product/RemoveCartItem/", 1944, 24, true);
#nullable restore
#line 58 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
WriteAttributeValue("", 1968, item.productID, 1968, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 61 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>


        </div>
        <div class=""row"">
            <div class=""col-4"">
                <a href=""/Product/CardDetails"" class=""btn btn-info"">Checkout</a>
            </div>
            <div class=""col-8"">
                <h4 class=""float-right"">Total Bill: ");
#nullable restore
#line 73 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                                               Write(totalBill);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            </div>
        </div>

    </div>
</div>




<script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js"" integrity=""sha512-VEd+nq25CkR676O+pLBnDW09R7VQX9Mdiij052gVCp5yVH3jGtH70Ho/UUv4mJDsEdTvqRCFZg0NKGiojGnUCw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>

<script>
    $(document).ready(function () {
        var errorMessage = """);
#nullable restore
#line 88 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                        Write(TempData["ErrorMessage"] as string);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n        var successMessage = \"");
#nullable restore
#line 89 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                          Write(TempData["SuccessMessage"] as string);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n        if (errorMessage !== \"\") toastr.error(errorMessage);\n        if (successMessage !== \"\") toastr.success(successMessage);\n        $(\"#orderBtn\").click(function () {\n            var totalBill = \"");
#nullable restore
#line 93 "/Users/eapplestore/Projects/Fiverr/Binosaimi/Ecom/Ecom/Views/Product/ViewCart.cshtml"
                         Write(totalBill);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n            console.log(totalBill)\n            if (totalBill > 1) {\n                location.href = \"/Product/PlaceAnOrder\";\n            }\n            else {\n                toastr.error(\'No item in cart\');\n            }\n        })\n    });\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Database.Entities.ProductCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
