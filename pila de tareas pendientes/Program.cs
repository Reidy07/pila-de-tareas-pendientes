using System;
using System.Collections.Generic;

class Program
{
    static Stack<string> tareasPendientes = new Stack<string>();

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Gestión de Tareas Pendientes ---");
            Console.WriteLine("1. Agregar tarea a la pila");
            Console.WriteLine("2. Completar tarea");
            Console.WriteLine("3. Mostrar tareas pendientes");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarTarea();
                    break;
                case 2:
                    CompletarTarea();
                    break;
                case 3:
                    MostrarTareas();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 0);
    }

    static void AgregarTarea()
    {
        Console.Write("Descripción de la tarea: ");
        string descripcion = Console.ReadLine();
        tareasPendientes.Push(descripcion);
        Console.WriteLine("Tarea agregada a la pila.");
    }

    static void CompletarTarea()
    {
        if (tareasPendientes.Count > 0)
        {
            string tareaCompletada = tareasPendientes.Pop();
            Console.WriteLine($"Tarea completada: {tareaCompletada}");
        }
        else
        {
            Console.WriteLine("No hay tareas pendientes.");
        }
    }

    static void MostrarTareas()
    {
        Console.WriteLine("\nTareas pendientes:");
        foreach (var tarea in tareasPendientes)
        {
            Console.WriteLine(tarea);
        }
    }
}
