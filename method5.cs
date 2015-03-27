using System;
class GlobalVar {
	static int a = 5;
	
	static void printValueA() {
		Console.WriteLine(a);
	}

	static void add10() {
		a += 10;
	}

	static void addByNum(int n) {
		a += n;
	}

	static void Main() {
		printValueA();
		add10();
		printValueA();
		addByNum(19);
		printValueA();
		Console.ReadLine();
	}
}
