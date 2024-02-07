using Managing_App_Secrets_in_.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Managing_App_Secrets_in_.NET_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public WeatherForecastController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //var connectionString = Configuration["ConnectionString"];
            //return Ok($"ConnectionString = { connectionString}");


            //var facebook = Configuration.GetSection("Facebook").Get<Facebook>();
            //return Ok($"Facebook Secret = {facebook?.AppSecret}, Facebook AppId = {facebook?.AppId}");

            var myConnection = new SqlConnectionStringBuilder("Server=DESKTOP-0D8DMT4;Initial Catalog=MyTodoDataBase;Integrated Security=true");
            myConnection.UserID = Configuration["User Name"];
            myConnection.Password = Configuration["Db-Password"];
            return Ok(myConnection.ToString());


        }
    }
}
