using Refit;

using RefitClientPlayground;

var api = RestService.For<IStarsController>("https://localhost:7218/");
var reasult1 = await api.GetAsync(3);
Console.WriteLine(reasult1);
var reasult2 = await api.GetDoubleAsync(3);
Console.WriteLine(reasult2);