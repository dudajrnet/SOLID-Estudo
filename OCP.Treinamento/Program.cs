

using Microsoft.Extensions.DependencyInjection;
using Refatoracao;

var services = new ServiceCollection();

services.AddTransient<Refatoracao.DiscountCalculator, RegularDiscount>();
services.AddTransient<Refatoracao.DiscountCalculator, PremiumDiscount>();
services.AddTransient<Refatoracao.DiscountCalculator, EmployeeDiscount>();
services.AddTransient<ViewDiscount>();
services.AddTransient<DiscountProcessor>();

using var serviceProvider = services.BuildServiceProvider();
serviceProvider.GetRequiredService<DiscountProcessor>().Process(100m);
