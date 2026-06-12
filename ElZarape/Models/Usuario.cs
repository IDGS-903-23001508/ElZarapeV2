namespace ElZarape.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }

        public string nombre { get; set; }

        public string correo { get; set; }
        public string contraseña { get; set; }

        public bool estatus { get; set; }
    }
}
