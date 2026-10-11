using Microsoft.Extensions.DependencyInjection;
using Refatoracao;

var services = new ServiceCollection();
services.AddTransient<Validation>();
services.AddTransient<Calculator>();
services.AddTransient<Repository>();
services.AddTransient<Email>();
services.AddTransient<Receipt>();
services.AddTransient<OrderProcessor>();

using var serviceProvider = services.BuildServiceProvider();

var order = new Order
{
    CustomerEmail="joao@teste.com",
    Discount = 20,
    Subtotal = 200
};

var processorOrder = serviceProvider.GetRequiredService<Refatoracao.OrderProcessor>();

processorOrder.Process(order);