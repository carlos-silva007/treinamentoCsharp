using Microsoft.AspNetCore.Mvc;

namespace ApiRest
{
    [Route("api/Basica")]
    [ApiController]

    public class BasicaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Basica/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Basica
        [HttpPost]
        public string Post([FromBody] string value)
        {
            var alu = value;
            return value;
        }

        // PUT api/Basica/5
        [HttpPut("{id}")] // id vem na rota
        public string Put(int id, [FromBody] string value) //value vem no body
        {
            var param = id;
            var texto = value;
            return $"id = {id} e value = {value}"; //concatenar string em c#
        }

        // DELETE api/Basica/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"id = {id} - Deletado!";
        }
    }
}


