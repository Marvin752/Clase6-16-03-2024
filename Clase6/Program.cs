static void ejem1()
{
    //Delcaracion de un arreglo
    int[] calificaciones;

    float c = 0; 

    //Creacion de un arreglo con valores inciales
    calificaciones = new int[] { 85, 92, 77, 68, 94, 45, 62, 84, 12, 36 };

    //Acceso a un elemento del arreglo 
    Console.WriteLine(calificaciones[2]); //Imprime 77

    foreach(int i in calificaciones)
    {
        Console.WriteLine(i);
        c = i + c;
    }
    c = c / calificaciones.Length;
    Console.WriteLine("\nEl promedio es: " + c + "\n");

    float p = 0, j = 0;
    for(int ñ = 0; ñ  < calificaciones.Length; ñ++)
    {
        p = calificaciones[ñ];
        j = j + p;
        Console.WriteLine(calificaciones[ñ]+"");
    }
    j = j / calificaciones.Length;
    Console.WriteLine("\nEl promedio es de: " + j);
}
static void ejem2()
{
    int[] melones = new int[] { 50, 20, 80, 90, 60, };
    Console.WriteLine("Original:\n");
    despliegue(melones);
    Array.Sort(melones);
    Console.WriteLine("\nOrdenados:\n");
    despliegue(melones);
    Array.Reverse(melones);
    Console.WriteLine("\nReverso:\n");
    despliegue(melones);

    //Buscar 90 y 105

    int papel = Array.IndexOf(melones, 90);
    Console.WriteLine("\n90 Se encuentra en la posicion: " +  papel);
    papel = Array.IndexOf(melones, 105);
    Console.WriteLine("105 Se encuentra en la posicion: " + papel);

    bool pandepan = Array.Exists(melones, pan => pan >= 60);
    if(pandepan)
    {
        Console.WriteLine("\nSi hay aprobados");
    }
}
static void despliegue(int[] arreglo)
{
    foreach (int i in arreglo)
    {
        Console.WriteLine(i);
    }
}
ejem2();