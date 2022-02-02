using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaCore.Modelos;
using SistemaCore.Modelos.Interventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaCore.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [Route("Login")]
        [HttpPost]
        public async Task<ActionResult<ResponseLogin>> Login(Login login)
        {
            var url = "https://api.bdeo.io/prod/v2/login";
            var jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            try
            {
                using (var httpCliente = new HttpClient())
                {
                    var respuesta = await httpCliente.PostAsJsonAsync(url, login);

                    if (respuesta.IsSuccessStatusCode)
                    {

                        var cuerpo = await respuesta.Content.ReadAsStringAsync();

                        var resp = JsonSerializer.Deserialize<ResponseLogin>(cuerpo, jsonSerializerOptions);

                        return resp;
                    }
                    else
                    {
                        return BadRequest();
                    }

                }
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }



        }


        //TODO
        [Route("Generate-Url")]
        [HttpPost]
        public async Task<ActionResult<string>> Generate_Url(GenerateAgentModel agent)
        {

            string agent_url= string.Empty;

            var url = "https://api.bdeo.io/prod/v2/generate-agent-url";
            var jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            using (var httpCliente = new HttpClient())
            {
                var respuesta = await httpCliente.PostAsJsonAsync(url, agent);

                if (respuesta.IsSuccessStatusCode)
                {

                    var cuerpo = await respuesta.Content.ReadAsStringAsync();

                    agent_url = JsonSerializer.Deserialize<string>(cuerpo, jsonSerializerOptions);

                    return agent_url;
                }
                else
                {
                    return BadRequest("ha ocurrido un error");
                }

            }

        }



        [Route("Intervention")]
        [HttpPost]
        public async Task<ActionResult<RespIntervention>> InterventionPost([FromBody]Intervention model )
        {
            var url = "https://api.bdeo.io/prod/v2/intervention";

            var headerValues = Request.Headers;
            string token = "";
            Microsoft.Extensions.Primitives.StringValues tokenprueba = "";
            // var headers = this.Request.Headers;

            if(headerValues.TryGetValue("access_token", out tokenprueba))
            {
                 token = tokenprueba.First();
            }            
            
            var jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Accept.Add(
                    //  new MediaTypeWithQualityHeaderValue("application/json")
                    //    );

                    client.DefaultRequestHeaders.Add("access_token", token);

                    var respuesta = await client.PostAsJsonAsync(url, model);

                    if (respuesta.IsSuccessStatusCode)
                    {
                        var cuerpo = await respuesta.Content.ReadAsStringAsync();

                        var resp = JsonSerializer.Deserialize<RespIntervention>(cuerpo, jsonSerializerOptions);

                        return resp;
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            catch (Exception e)
            {

                throw e.InnerException ?? e;
            }



        }



        
    }

    

    
    
}
