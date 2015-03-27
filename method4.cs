using System;
class LocalVar {
	static int quadratic(int a, int b, int c, int x) {
		return a*x*x + b*x + c; // ax^2 + bx + c
	}

	static void Main() {
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine(quadratic(a,b,c,x));
		Console.ReadLine();
	}
}
