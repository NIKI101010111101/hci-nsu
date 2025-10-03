#include <iostream>
#include "algorithm"
#include "string"

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




int main() {
    std::string result = "";
    int num;
    std::cout << "Enter a decimal number: ";
    std::cin >> num;
    DecToDifChislo(num, result);
    DifChisloToDec(result);
    return 0;
}
