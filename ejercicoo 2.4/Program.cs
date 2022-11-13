namespace calcular
{
    public class calcular
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;

            int suma;
            double media;
            int produc;
            Console.WriteLine("ingrese el primer numero ");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero ");
            num3= int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto numero ");
            num4 = int.Parse(Console.ReadLine());

            produc = num1 * num2 * num3 * num4;
            suma = num1 + num2 + num3 + num4;
            media = suma / 4;
            Console.WriteLine($"la suma de los numeros es {suma}, el producto de los numeros es {produc}, la media de los numeros es {media}");
        }
    }
}
