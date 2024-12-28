using ProjectE.Entities;
using ProjectE.Services;

// Cria os clientes
Client client = new Client("Alice", "Urban");
Client client2 = new Client("Teste", "Urban");
Client client3 = new Client("Carlos", "Rural");

// Cria os pedidos
Order order = new Order(1, client, 500.0);
Order order2 = new Order(2, client2, 500.0);
Order order3 = new Order(3, client3, 500.0);

// Cria o DeliveryServiceFactory para obter o tipo correto de serviço de entrega
DeliveryServiceFactory deliveryServiceFactory = new DeliveryServiceFactory();

// Cria o serviço de entrega de acordo com a localização do cliente
IDeliveryService deliveryService = deliveryServiceFactory.GetDeliveryServiceByLocation(client);

// Cria o OrderService com o serviço de entrega para o primeiro cliente
OrderService orderService = new OrderService(deliveryService);

// Processa o pedido com o serviço de entrega inicial
orderService.ProcessOrder(order);  // Isso vai calcular a taxa de entrega
Console.WriteLine($"Order 1 (Alice - Urban) Delivery Fee: {order.DeliveryFee:C}");

// Troca o serviço de entrega para o segundo cliente
deliveryService = deliveryServiceFactory.GetDeliveryServiceByLocation(client2);
orderService = new OrderService(deliveryService);  // Recria o OrderService com o novo serviço de entrega

// Processa o pedido com o novo serviço de entrega
orderService.ProcessOrder(order2);  // Isso vai recalcular a DeliveryFee
Console.WriteLine($"Order 2 (Teste - Urban) Delivery Fee: {order2.DeliveryFee:C}");

// Troca o serviço de entrega para o terceiro cliente
deliveryService = deliveryServiceFactory.GetDeliveryServiceByLocation(client3);
orderService = new OrderService(deliveryService);  // Recria o OrderService novamente

// Processa o pedido com o novo serviço de entrega
orderService.ProcessOrder(order3);  // Isso vai recalcular a DeliveryFee para o terceiro pedido
Console.WriteLine($"Order 3 (Carlos - Rural) Delivery Fee: {order3.DeliveryFee:C}");