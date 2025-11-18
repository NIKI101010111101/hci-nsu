#include <cstdlib>
#include <iostream>

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

void invtab_to_permut(int *a, int *b, int n)
{
    int count = 0;
    if (b[n - 1] != 0)
    {
        std::cout << "NO" << std::endl;
        return;
    }

    std::cout << std::endl;
    for (int i = 1; i < n + 1; i++)
    {
        if (b[i - 1] == 0)
        {
            for (int j = 0; j < n - 1; j++)
                if (a[j] == 0)
                {
                    a[j] = i;
                    break;
                }
        }
        else
        {
            for (int j = 0; j < b[i - 1] + count; j++)
            {
                if (i > a[j] && a[j] != 0)
                    count++;
            }
            a[b[i - 1] + count] = i;
            count = 0;
        }
    }
}


int main()
{
    int n;
    std::cout <<"Enter N: "<< std::endl;
    std::cin >> n;

    int* a = new int[n]{0};
    int* b = new int[n]{0};

    // createarr(a, n);
    // printarr(a, n);
    // printarr(b, n);
    // permut_to_invtab(a, b, n);
    // printarr(b, n);
    // free(a);
    // free(b);


    createarr(b, n);
    printarr(a, n);
    invtab_to_permut(a, b, n);
    printarr(a, n);
    free(a);
    free(b);

    return 0;
}
