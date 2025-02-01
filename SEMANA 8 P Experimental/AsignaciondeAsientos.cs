using System;
using System.Collections.Generic;

// Clase que representa la atracción del parque
class AtraccionParque
{
    private Queue<string> colaEspera; // Cola para manejar la espera de personas
    private int capacidad; // Número máximo de asientos disponibles
    private List<string> asientosAsignados; // Lista de personas con asiento asignado

    // Constructor que inicializa la capacidad de la atracción
    public AtraccionParque(int capacidad)
    {
        this.capacidad = capacidad;
        colaEspera = new Queue<string>();
        asientosAsignados = new List<string>();
    }

    // Método para agregar personas a la atracción o a la cola de espera
    public void AgregarPersona(string nombre)
    {
        if (asientosAsignados.Count < capacidad) // Si hay asientos disponibles
        {
            asientosAsignados.Add(nombre);
            Console.WriteLine($"{nombre} ha recibido un asiento.");
        }
        else // Si no hay asientos disponibles, se añade a la cola de espera
        {
            colaEspera.Enqueue(nombre);
            Console.WriteLine($"{nombre} ha sido añadido a la cola de espera.");
        }
    }

    // Método para iniciar la atracción mostrando los pasajeros actuales
    public void IniciarAtraccion()
    {
        Console.WriteLine("La atracción ha comenzado con los siguientes pasajeros:");
        foreach (var pasajero in asientosAsignados)
        {
            Console.WriteLine(pasajero);
        }
    }

    // Método para finalizar la atracción y reasignar asientos
    public void FinalizarAtraccion()
    {
        Console.WriteLine("La atracción ha finalizado. Liberando asientos...");
        asientosAsignados.Clear(); // Se vacían los asientos

        // Se asignan nuevos pasajeros desde la cola de espera si hay disponibilidad
        while (asientosAsignados.Count < capacidad && colaEspera.Count > 0)
        {
            string siguiente = colaEspera.Dequeue(); // Se toma la primera persona en la cola
            asientosAsignados.Add(siguiente);
            Console.WriteLine($"{siguiente} ha tomado un asiento.");
        }
    }
}