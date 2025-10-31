#include <iostream>

void permut_to_invtab(int *a, int *b, int n)
{
    int count = 0;
    for (int i = n - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (a[i] < a[j])
                count++;
        }
        b[a[i]-1] = count;
        count = 0;
    }
}

void createarr(int *arr, int n)
{
    int temp;
    for (int i = 0; i < n; i++)
    {
        std::cin >> temp;
        arr[i] = temp;
    }
}

void printarr(int *arr, int n)
{
    for(int i = 0; i < n; i++)
        std::cout << arr[i] << " ";
    std::cout << std::endl;
}

int main()
{
    int a[8]{0}, b[8]{0}, n = 8;
    createarr(a, n);
    printarr(a, n);
    printarr(b, n);

    permut_to_invtab(a, b, n);
    printarr(b, n);
    free(a);
    free(b);
    return 0;
}
