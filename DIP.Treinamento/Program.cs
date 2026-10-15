
using Dip.Treinamento.Refatorcao;
//using Dip.Treinamento.Violacao;
using Microsoft.Extensions.DependencyInjection;

//Violacao
//var orderService = new OrderService(); //Por aqui não é possível alternar entre e-mail e sms, somente alterando a classe OrderService violando o DIP
//orderService.PlaceOrder();

//Refatoracao com injeção de dependência
var services = new ServiceCollection();

services.AddTransient<INotifier, EmailNotifier>();
//services.AddTransient<INotifier, SmsNotifier>();//realiza uma outra chamada para SMS
services.AddScoped<OrderService>();

//INotifier notifier = new EmailNotifier();//É possível trocar pela classe SmsNotifier
//var orderService = new OrderService(notifier);
//orderService.PlaceOrder();

var provider = services.BuildServiceProvider();

var service = provider.GetRequiredService<OrderService>();

service.PlaceOrder();
