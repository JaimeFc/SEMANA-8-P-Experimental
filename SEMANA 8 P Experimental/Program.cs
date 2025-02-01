// Clase principal para ejecutar el programa

class Program
{
    static void Main()
    {
        AtraccionParque atraccion = new AtraccionParque(30); // Se crea una atracción con 30 asientos
        
        // Se añaden 35 personas a la atracción, las primeras 30 obtienen asiento, las demás esperan
        for (int i = 1; i <= 35; i++)
        {
            atraccion.AgregarPersona("Persona " + i);
        }
        
        atraccion.IniciarAtraccion(); // Se inicia la atracción con los primeros 30 pasajeros
        atraccion.FinalizarAtraccion(); // Se finaliza la atracción y se asignan nuevos pasajeros desde la cola
    }
}