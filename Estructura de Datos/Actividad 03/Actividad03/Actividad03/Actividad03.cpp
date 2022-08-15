#include <iostream>

int* fillArrayReals() {
	static int nums[11]{};
	int offset = 4;

	for (int i = 0; i <= 10; i++)
	{
		nums[i] = i + offset;
		std::cout << i + offset;
		std::cout << "\n";
	}

	return nums;
}

int* fillArrayEvens() {
	static int nums[11]{};
	int sum = 0;

	for (int i = 0; i <= 10; i++)
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
	fillArrayReals();
	//fillArrayEvens();
}