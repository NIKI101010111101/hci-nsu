#include <iostream>
#include "algorithm"
#include "string"
#include <cmath>
#include <string>

void DecToDifChislo(int num, std::string& result)
{
    int syst;
    std::cout << "Enter the base system: ";
    std::cin >> syst;

    std::cout << "Representation in base " << syst << ": ";
    while (num > 0)
    {
        int count = num %syst;
        if (count < 10) {
            result += ('0' + count);
        } else {
            result += ('a' + count - 10);
        }
        num /= syst;
    }
    std::reverse(result.begin(), result.end());
    std::cout << result << std::endl;
}

int DifChisloToDec(std::string& num)
{
    int result = 0;
    int base;
    std::cout << "Enter the base system: ";
    std::cin >> base;

    for (char c : num)
    {
        int digit = (c >= '0' && c <= '9') ? c - '0' : c - 'a' + 10;
        result = result * base + digit;
    }
    std::cout << "Decimal representation: " << result << std::endl;
    return result;
}

void FloatDecToDifChislo(double num, std::string& result)
{
    int base, sing;
    std::cout << "Enter the base system: ";
    std::cin >> base;
    std::cout << "Enter the sign after zapyatay: ";
    std::cin >> sing;

    const double eps = 1e-5;
    result = "0.";

    for (int i = 0; i < sing; ++i)
    {
        if (num < eps)
            break;
        num *= base;
        int digit = static_cast<int>(num);
        if (digit < 10)
            result += '0' + digit;
        else
            result += 'a' + (digit - 10);
        num -= digit;
    }
    std::cout << result << std::endl;
}

void FloatDifChisloToDec(std::string& num)
{
    int base;
    std::cout << "Enter the base system: ";
    std::cin >> base;

    double result = 0;
    int point = num.find('.');

    double power = 1.0 / base;

    for (int i = point + 1; i < num.length(); i++)
    {
        int digit = (num[i] >= '0' && num[i] <= '9') ? num[i] - '0' : num[i] - 'a' + 10;
        result += digit * power;
        power /= base;
    }
    std::cout << "Decimal representation: " << result << std::endl;
}

// task 5
void DifToDif(std::string& result)
{
    int base1, base2;
    std::string num;
    std::cout << "Enter the first base system: ";
    std::cin >> base1;
    std::cout << "Enter the second base system: ";
    std::cin >> base2;
    std::cout << "Enter the number: ";
    std::cin >> num;

    if (base1 == base2)
    {
        std::cout << "The number in the same base system is: " << num << std::endl;
        return;
    }

    if (base1 == 10)
    {
        std::cout << "The number in the base system " << base2 << " is: ";
        int num_int = std::stoi(num);
        DecToDifChislo(num_int, result);
        return;
    }

    if (base2 == 10)
    {
        std::cout << "The number in the base system " << base1 << " is: ";
        DifChisloToDec(num);
        return;
    }

    if (base1 != base2)
    {
        std::cout << "The number in the base system " << base2 << " is: ";
        int num_int = DifChisloToDec(num);
        DecToDifChislo(num_int, result);
        return;
    }
}

int main() {
    std::string result = "";
    // int num = 42;
    DifToDif(result);
    // double num;
    // std::cout << "Enter a decimal number: ";
    // std::cin >> num;
    // DecToDifChislo(num, result);
    // DifChisloToDec(result);
    // FloatDecToDifChislo(num, result);
    // FloatDifChisloToDec(result);
    return 0;
}
