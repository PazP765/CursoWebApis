using System.Net;

namespace MagicVilla_API.Modelos
{
    public class APIResponse
    {
        //todos los endpoints retornen una respuesta estandar y que la respuesta se adapte en presentación..
        //a lo que queremos retornar, incluso si la respuesta retona errores, que tambien se muestren y todo sea consistente.
        //esta clase se encarga de todas las respuestas que se envian a los endpoints, para que todas sean similares..
        //y cambien según el contenido de dicha respuesta

        public HttpStatusCode statusCode { get; set; }
        public bool IsExitoso { get; set; } = true;
        public List<string> ErrorMessage { get; set; }
        public object Resultado {get; set; }    
    }
}
