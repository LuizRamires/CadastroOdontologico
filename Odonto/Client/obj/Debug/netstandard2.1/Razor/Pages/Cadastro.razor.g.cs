#pragma checksum "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378b29e1ae4bdb42c6f1ab1f1c0d2cfe789285be"
// <auto-generated/>
#pragma warning disable 1591
namespace Odonto.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Odonto.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Odonto.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\_Imports.razor"
using Odonto.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cadastro")]
    public partial class Cadastro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Cadastro</h1>\r\n");
            __builder.OpenComponent<Blazorise.Row>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Column>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.Card>(7);
                    __builder3.AddAttribute(8, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 5 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                      Margin.Is4.OnY

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(10, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.CardHeader>(11);
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(13, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.CardTitle>(14);
                            __builder5.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(16, "Cliente");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(17, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.CardBody>(19);
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(21, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Field>(22);
                            __builder5.AddAttribute(23, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(25, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldLabel>(26);
                                __builder6.AddAttribute(27, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 11 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                            ColumnSize.Is2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(29, "Nome");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(30, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldBody>(31);
                                __builder6.AddAttribute(32, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 12 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                           ColumnSize.Is10

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(34, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.TextEdit>(35);
                                    __builder7.AddAttribute(36, "Placeholder", "Insira o nome do cliente");
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(37, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(38, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(39, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Field>(40);
                            __builder5.AddAttribute(41, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(43, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldLabel>(44);
                                __builder6.AddAttribute(45, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 17 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                            ColumnSize.Is2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(47, "Telefone");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(48, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldBody>(49);
                                __builder6.AddAttribute(50, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 18 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                           ColumnSize.Is10

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(52, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.TextEdit>(53);
                                    __builder7.AddAttribute(54, "Placeholder", "Insira o numero do cliente");
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(55, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(57, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Field>(58);
                            __builder5.AddAttribute(59, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(61, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldLabel>(62);
                                __builder6.AddAttribute(63, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 23 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                            ColumnSize.Is2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(65, "Email");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(66, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldBody>(67);
                                __builder6.AddAttribute(68, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 24 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                           ColumnSize.Is10

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(70, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.TextEdit>(71);
                                    __builder7.AddAttribute(72, "Role", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.TextRole>(
#nullable restore
#line 25 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                        TextRole.Email

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(73, "Placeholder", "email");
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(74, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(75, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(76, "\r\n\r\n                ");
                            __builder5.OpenComponent<Blazorise.Field>(77);
                            __builder5.AddAttribute(78, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(80, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldLabel>(81);
                                __builder6.AddAttribute(82, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 30 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                            ColumnSize.Is2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(84, "Sintomas");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(85, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldBody>(86);
                                __builder6.AddAttribute(87, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 31 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                           ColumnSize.Is10

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(89, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.MemoEdit>(90);
                                    __builder7.AddAttribute(91, "Rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 32 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                        5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(92, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(93, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(94, "\r\n\r\n                ");
                            __builder5.OpenComponent<Blazorise.Field>(95);
                            __builder5.AddAttribute(96, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(98, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldLabel>(99);
                                __builder6.AddAttribute(100, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 37 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                            ColumnSize.Is2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(102, "Data");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(103, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldBody>(104);
                                __builder6.AddAttribute(105, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 38 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                           ColumnSize.Is10

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(107, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.DateEdit<DateTime?>>(108);
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(109, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(110, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Field>(112);
                            __builder5.AddAttribute(113, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(115, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldLabel>(116);
                                __builder6.AddAttribute(117, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 43 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                            ColumnSize.Is2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(119, "Hora");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(120, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.FieldBody>(121);
                                __builder6.AddAttribute(122, "ColumnSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentColumn>(
#nullable restore
#line 44 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                           ColumnSize.Is10

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(124, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.TimeEdit<TimeSpan?>>(125);
                                    __builder7.AddAttribute(126, "TimeChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TimeSpan?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TimeSpan?>(this, 
#nullable restore
#line 45 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                                                    (v)=>Console.WriteLine(v)

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(127, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(128, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(129, "\r\n\r\n                ");
                            __builder5.OpenComponent<Blazorise.Button>(130);
                            __builder5.AddAttribute(131, "style", "float:right;");
                            __builder5.AddAttribute(132, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 49 "C:\Users\Typhon\Documents\Comp2020\PI4\Code\CadastroOdontologico\Odonto\Client\Pages\Cadastro.razor"
                                                    Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(134, "Salvar");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(135, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(136, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
