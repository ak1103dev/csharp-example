using System;
class GlobalVSLocal {
	static int sum = 1; // global

	static void Main() {
		int sum = 5; // local
		sum++;
		Console.WriteLine(sum);
		addSum();
		Console.WriteLine(sum);
	}

	static void addSum() {
		Console.WriteLine(sum++);
	}

	static void addSum(int sum) {
		Console.WriteLine(sum++);
		Console.ReadLine();
	}
}
