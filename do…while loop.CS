using System;

class Program {
    static void Main(string[] args) {
        int num = 2;
        Console.WriteLine("Number\tSquare\tCube");
        do {
            Console.WriteLine("{0}\t{1}\t{2}", num, num*num, num*num*num);
            num++;
        } while (num <= 10);
    }
}
