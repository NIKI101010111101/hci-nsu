#include <iostream>
#include <string>
#include <algorithm>

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

void BitOfNum2(int num, bool flag = false, int num_bit = 32)
{
    for (int i = num_bit - 1; i >= 0; i--)
    {
        int mask = 1 << i;
        if (!((num & mask) == 0))
        {
            std::cout << "1";
            flag = true;
        } else if(flag)
        {
            std::cout << "0";
        }
    }
    std::cout << std::endl;
}

int BinToDec(std::string& num)
{
    int result = 0;
    int base = 2;

    for (char c : num)
    {
        int digit = (c >= '0' && c <= '9') ? c - '0' : c - 'a' + 10;
        result = result * base + digit;
    }
    return result;
}

std::string BitNumReverse(int num, int num_bit = 32)
{
    std::string result = "";
    int bit = 0;
    for (int i = 0; i < num; num >>= 1)
    {
        bit++;
        result += std::to_string(num & 1);
    }
    for (int i = 0; i < num_bit - bit; i++)
    {
        result += "0";
    }
    return result;
}

int main()
{
    int num, a;
    std::cin >> num;
    std::cout << std::endl;
    std::cout << BitOfN(num) << std::endl;
    BitOfNum(num);
    BitOfNum2(num);
    std::cout << MaxOnes(num) << std::endl;
    std::cout << std::endl;
    BitOfNum2(num, true);
    std::string reversed = BitNumReverse(num);
    std::cout << BinToDec(reversed) << std::endl;
    std::cout << BitNumReverse(num) << std::endl;
    // std::cout << std::endl;
    return 0;
}
