#include <iostream>
#include <string>
#include <algorithm>

std::string DecToDifChislo(int num, std::string& result, int base)
{
    while (num > 0)
    {
        int count = num %base;
        if (count < 10) {
            result += ('0' + count);
        } else {
            result += ('a' + count - 10);
        }
        num /= base;
    }
    std::reverse(result.begin(), result.end());
    return result;
}


int MaxOnes (int num, int num_bit = 32)
{
    int maxOnes = 0;
    int count   = 0;
    {
        bool check = false;
        for (int i = num_bit - 1; i >= 0; i--)
        {
            int mask = 1 << i;
            if (!((num & mask) == 0))
            {
                count++;
                check = true;
            } else if(check)
            {
                maxOnes = std::max(maxOnes, count);
                count = 0;
            }
        }
    }
    return maxOnes;
}

int BitOfN (int num)
{
    int count = 0;
    while (num > 0)
    {
        count += num & 1;
        num >>= 1;
    }
    return count;
}

void BitOfNum(int num)
{
    int bit = 0;
    for (int i = 0; i < num; num >>= 1)
    {
        std::cout << (num & 1);
    }
    std::cout << std::endl;
}

void BitOfNum2(int num, int num_bit = 32)
{
    bool check = false;
    for (int i = num_bit - 1; i >= 0; i--)
    {
        int mask = 1 << i;
        if (!((num & mask) == 0))
        {
            std::cout << "1";
            check = true;
        } else if(check)
        {
            std::cout << "0";
        }
    }
    std::cout << std::endl;
}

int main()
{

    // std::string str = "";
    int num, a;
    std::cin >> num;
    // str = DecToDifChislo(10, str, 2);
    // MaxOnes(str);
    std::cout << std::endl;
    std::cout << BitOfN(num) << std::endl;
    BitOfNum(num);
    BitOfNum2(num);
    std::cout << MaxOnes(num) << std::endl;
    return 0;
}
