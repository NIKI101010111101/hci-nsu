#include <iostream>
#include<string>
#include<fstream>

int Task1 (std::string& name_file)
{
    int result = 0, count = 0, max_sub = 0;
    std::ifstream F(name_file);
    std::string s;
    std::getline( F, s );
    F.close();
    if (s.empty())
        return -1;

    for (char c : s)
    {
        if (c == 'E')
            count++;
        else if (c == 'A' && count == 1)
        {
            count++;
            result += 1;
        }
        else if (c == 'B' && count == 2)
            count = 0;
        else
        {
            result = 0;
            count = 0;
        }
        if (result > max_sub)
            max_sub = result;

    }
    return max_sub;
}

int Task2(std::string& name_file)
{
    int result = 0, count = 0;
    std::ifstream F(name_file);
    std::string s;
    std::getline( F, s );
    F.close();
    if (s.empty())
        return -1;

    for (char c : s)
   {
       if (c == 'C')
           count ++;
       else if (c != 'C')
       {
           if  (count > result)
               result = count;
           count = 0;
       }
   }
    return result;
}

int Task3(std::string& name_file)
{
    int result = 0, count = 0, max_sub = 0;
    std::ifstream F(name_file);
    std::string s;
    std::getline( F, s );
    F.close();
    if (s.empty())
        return -1;
    for (char c : s)
    {
        if (c == 'A' || c == 'B' || c == 'C')
            count++;
        else
        {
            if (count > result)
                result = count;
            count = 0;
        }
    }
    return result;
}

int Task4(std::string& name_file)
{
    int result = 0, count = 0, max_sub = 0;
    std::ifstream F(name_file);
    std::string s;
    std::getline( F, s );
    F.close();
    if (s.empty())
        return -1;

    for (char c : s)
    {
        if (c == 'D')
            count++;
        else if (c == 'B' && count == 1)
        {
            count++;
            result += 1;
        }
        else if (c == 'A' && count == 2)
            count ++;
        else if (c == 'C' && count == 3)
            count = 0;
        else
        {
            result = 0;
            count = 0;
        }
        if (result > max_sub)
            max_sub = result;

    }
    return max_sub;
}

int main()
{
    std::string name_file = "k7b-2.txt";
    std::cout << "Последовательность EAB = " << Task1(name_file) << std::endl;
    std::cout << "Последовательность C = " << Task2(name_file) << std::endl;
    std::cout << "Последовательность ABC = " << Task3(name_file) << std::endl;
    std::cout << "Последовательность DBAC = " << Task4(name_file) << std::endl;
    return 0;
}
