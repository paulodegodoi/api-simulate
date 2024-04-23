using PizzariaCSharp.Controller;
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Repository;

var bebidaController = new BebidaController(new BebidaRepository());

Console.WriteLine("All Set Up");


bebidaController.Post(new PizzariaCSharp.Model.Bebida
{
    Nome = "Coca Cola",
    Valor = 5.50M
});

foreach (var item in bebidaController.GetAll())
{
    Console.WriteLine(item.ToString());
    Console.WriteLine("Enchendo garrafa retornável...");
    bebidaController.EncherGarrafaRetornavel(item);
}