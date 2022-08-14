#include <iostream>

int* fillArrayReals() {
	static int nums[10]{};
	int offset = 4;

	for (int i = 0; i < 10; i++)
	{
		nums[i] = i + offset;
		std::cout << i;
		std::cout << "\n";
	}

	return nums;
}

int* fillArrayEvens() {
	static int nums[10]{};
	int sum = 0;

	for (int i = 0; i < 10; i++)
	{
		nums[i] = i * 2;
		sum += i * 2;
		std::cout << i * 2;
		std::cout << "\n";
	}

	std::cout << "\n";
	std::cout << "Suma:";
	std::cout << sum;
	return nums;
}

int main()
{
	fillArrayEvens();
}