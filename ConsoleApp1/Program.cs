public class Pila<T>
{
    private T[] vec = new T[5];
    private int tope = 0;

    public void Insertar(T x)
    {
        vec[tope] = x;
        tope++;
    }

    public T Extraer()
    {
        tope--;
        return vec[tope];
    }
}

public class Program1
{
    public static void Main(string[] args)
    {
        Pila<int> pila1 = new Pila<int>();
        pila1.Insertar(20);
        pila1.Insertar(40);
        pila1.Insertar(17);
        Console.WriteLine(pila1.Extraer());

        Pila<string> pila2 = new Pila<string>();
        pila2.Insertar("juan");
        pila2.Insertar("ana");
        pila2.Insertar("luis");
        Console.WriteLine(pila2.Extraer());

        Console.ReadKey();

    }
}