using Microsoft.AspNetCore.Mvc; // imports the Microsoft.AspNetCore.Mvc namespace, which contains the core functionalities for building web APIs in ASP.NET Core, including the ControllerBase class and various attributes like [ApiController] and [Route]

namespace AuctionService.Controllers; // defien namespae for weatherforcastcontroller

[ApiController] //atribute to define this as a API controller
[Route("[controller]")] //This attribute defines the base route for the controller. The [controller] token is replaced by the name of the controller class without the "Controller" suffix. In this case, it means the base route will be /weatherforecast
//Controller base  provides a base class for creating API controllers

// It provides several methods for returning various types of HTTP responses easily. Some common methods include:
// Ok(): Returns a 200 OK response with an optional value.
// NotFound(): Returns a 404 Not Found response.
// BadRequest(): Returns a 400 Bad Request response.
// CreatedAtAction(): Returns a 201 Created response along with a URI to the newly created resource.

// Model Binding and Validation:
// ControllerBase integrates with the model binding and validation system in ASP.NET Core, making it easier to work with data passed in from HTTP requests.
// You can use attributes like [FromBody], [FromQuery], and others to specify how to bind data to action parameters.

// Action Results:
// It allows you to return various types of IActionResult or ActionResult<T> from your action methods, providing a flexible way to return results based on the outcome of the action.

// Support for Dependency Injection:
// Just like any other class in ASP.NET Core, controllers that inherit from ControllerBase can take dependencies via their constructors, enabling the use of services for logging, data access, etc.
public class WeatherForecastController : ControllerBase 
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger; //ILogger<T> is part of the Microsoft.Extensions.Logging namespace in ASP.NET Core and represents a logging interface 
    //The <WeatherForecastController> part is a generic type parameter. By specifying WeatherForecastController, you're telling the logging system that the logger is specific to that controller.
// This helps in categorizing log messages, making it easier to filter and identify logs related to a specific component in your application.

    public WeatherForecastController(ILogger<WeatherForecastController> logger) // constructor for the WeatherForecastController. It takes an ILogger<WeatherForecastController> parameter named logger, which allows for dependency injection of the logging service 
    {
        _logger = logger;
    }

// Action Naming:
// The name "GetWeatherForecast" assigned in the [HttpGet] attribute is mainly for internal use in your code. It allows you to reference this action method by name when generating URLs or redirects.
// For example, you could use this name in methods like Url.Action("GetWeatherForecast") to dynamically generate the URL for this action.

// URL Access:
// The actual URL that clients (like Postman or browsers) need to use to access the API endpoint is determined by your routing configuration and any [Route] attributes you have on the controller.
// In your case, since you've set up the controller with the [Route("[controller]")] attribute, the URL to access the Get method will always be: http://localhost:5038/weatherforecast
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get() //This is the declaration of the Get action method. It returns an IEnumerable<WeatherForecast>, which is a collection of WeatherForecast objects. This method will be called when a GET request is made to the base route (e.g., /weatherforecast).
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });
    }
}
