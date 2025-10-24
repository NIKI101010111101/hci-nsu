#include <iostream>
#include <algorithm>
#include <string>


long long fact(int n) {
     if (n < 0)
         return -1;
     if (n == 0)
         return 1;
     return n * fact(n - 1);
 }

void next_permut(int *a, int n)
{
    int i = n - 2;
    while (i >= 0 && a[i] >= a[i + 1])
        i--;
    if (i >= 0)
    {
        int j = n - 1;
        while (a[j] <= a[i])
            j--;
        std::swap(a[i], a[j]);
    }
    std::reverse(a + i + 1, a + n);
}

std::string next_permut_str(std::string a, int n)
{
    int i = n - 2;
    while (i >= 0 && a[i] >= a[i + 1])
        i--;
    if (i >= 0)
    {
        int j = n - 1;
        while (a[j] <= a[i])
            j--;
        std::swap(a[i], a[j]);
    }
    std::reverse(a.begin() + i + 1, a.end());
    return a;
}

void all_permut(std::string a, int n)
{
    bool flag = true;
    std::cout << a << std::endl;
    while(flag)
    {
        for(int i = n-2; i > 0; i--)
            if(a[i] < a[i+1])
                flag = false;
        a = next_permut_str(a, n);
        std::cout << a << std::endl;
    }
}

void print_array(int *a, int n)
{
    for (int i = 0; i < n; i++)
        std::cout << a[i] << " ";
    std::cout << std::endl;
}

int main()
{
    int arr[] = {5,2,7,3,8,6,4,1};
    int n = sizeof(arr) / sizeof(arr[0]);

    print_array(arr, n);
    next_permut(arr, n);
    print_array(arr, n);

    all_permut("312", 3);
    return 0;
}
