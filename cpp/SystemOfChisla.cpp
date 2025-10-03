#include <iostream>
#include "algorithm"
#include "string"

void DecToDifChislo()
{
    std::string result = "";
    int num, syst;
    std::cout << "Enter a decimal number: ";
    std::cin >> num;
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

void DifChisloToDec()
{
    int result = 0;
    std::string num;
    int base;
    std::cout << "Enter a number in base: ";
    std::cin >> num;
    std::cout << "Enter the base system: ";
    std::cin >> base;

    for (char c : num)
    {
        int digit = (c >= '0' && c <= '9') ? c - '0' : c - 'a' + 10;
        result = result * base + digit;
    }
    std::cout << "Decimal representation: " << result << std::endl;
}


int main() {
    DecToDifChislo();
    DifChisloToDec();
    return 0;
}
