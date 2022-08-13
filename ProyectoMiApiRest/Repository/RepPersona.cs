using ProyectoMiApiRest.Emtities;
using System.Data;
namespace ProyectoMiApiRest.Repository
{
    public class RepPersona
    {
        readonly FuncionesGenerales funciones;
        readonly Dictionary<string, string> parametros;

        public RepPersona()
        {
            funciones = new FuncionesGenerales();
            parametros = new Dictionary<string, string>();
        }

        //METODO PARA MOSTRAR LOS DATOS
        public List<ModPersona>? MostrarPersona()
        {
            DataTable dt = funciones.CargarDatos("sel_all_persona");

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<ModPersona> list = new();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ModPersona persona = new()
                {
                    id = Convert.ToInt32(dt.Rows[i]["id"].ToString()),
                    nombre = dt.Rows[i]["nombre"].ToString(),
                    apellidos = dt.Rows[i]["apellidos"].ToString(),
                    edad = Convert.ToInt32(dt.Rows[i]["edad"].ToString()),
                    sexo = dt.Rows[i]["sexo"].ToString(),
                };
                list.Add(persona);

            }
            return list;
        }


    }
}







