global using BlazorApp1.Shared;
global using System.Net.Http.Json;
global using BlazorApp1.Client.Services.ProductService;
global using BlazorApp1.Client.Services.CategoryService;
global using Microsoft.AspNetCore.Components.Web;
global using BlazorApp1.Client.Services.CartService;
global using BlazorApp1.Client.Services.AuthService;
global using BlazorApp1.Client.Services.OrderService;
global using BlazorApp1.Client.Services.PaymentService;
global using Microsoft.AspNetCore.Components.Authorization;
using BlazorApp1.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();
