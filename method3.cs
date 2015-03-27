using System;
class Method3 {
	static int quadratic(int a, int b, int c, int x) {
		return a*x*x + b*x + c; // ax^2 + bx + c
	}

	static void Main() {
		Console.WriteLine(quadratic(1,2,3,4));
		Console.ReadLine();
	}
}
