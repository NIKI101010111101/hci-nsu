#include <iostream>
#include "algorithm"
#include "string"
#include <cmath>

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

void DifChisloToDec(std::string& num)
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

int main() {
    std::string result = "";
    double num;
    std::cout << "Enter a decimal number: ";
    std::cin >> num;
    // DecToDifChislo(num, result);
    // DifChisloToDec(result);
    FloatDecToDifChislo(num, result);
    FloatDifChisloToDec(result);
    return 0;
}
