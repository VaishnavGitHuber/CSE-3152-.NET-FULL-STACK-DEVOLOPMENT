/* 
Assessment 1b:
Info: Design a console application to calculate the Simple Interest (SI) 
input : by providing Principal (p), Rate(r) and Time (t)
output : Simple Intrest 
Hint: S.I= (p × r × t)/100
*/
class SimpleIntrest {
    static void Main(string[] args){
        // input: principle, rate, time 
        Console.Write("Enter the principle amount(in rupees): ");
        double Principle = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Rate(in percentage): ");
        int Rate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Time(in hours): ");
        int Time = Convert.ToInt32(Console.ReadLine());

        // calculate : simple intrest 
        int SI = (int)((Principle * Rate * Time) / 100);

        // output : SI(Simple Intrest)
        Console.WriteLine($"Enter the Simple Intrest: {SI}");
    }
}