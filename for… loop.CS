using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Number\tSquare\tCube");
        for (int num = 2; num <= 10; num++) {
            Console.WriteLine("{0}\t{1}\t{2}", num, num*num, num*num*num);
        }
    }
}
