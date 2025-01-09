using Microsoft.AspNetCore.Mvc;
namespace userApi.Controllers{

// Stating the type of controller 
    [ApiController]
// The project knowing it is a controller (it checks the name of the controller and make sure the route ends when the 'controller' word starts like it would
// automatically assign the route to be user in userController)
    [Route("[controller]")]

    public class userController : ControllerBase{

        // Constructor 
        public userController(){

         }


        // When a get request is called
        // [HttpGet("getUsers/{value}")]
        // Function to perform when endpoint is being called 
        // public string Test(string value){
        //     return value;
        // }

        [HttpGet("getUsers/")]
        public string Test(string value){
            return value;
        }

    }
}