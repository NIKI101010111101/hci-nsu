#include <iostream>
#include <algorithm>

void createArray(int arr[], int size) {
    for (int i = 0; i < size; i++) {
        std::cin >> arr[i];
    }
    std::cout << std::endl;
}

void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++) {
        std::cout << arr[i] << " ";
    }
    std::cout << std::endl;
}

void ShellSort(int arr[], int size) {
    int gap = size / 2;
    while (gap > 0) {
        for (int i = gap; i < size; i++) {
            int temp = arr[i];
            int j = i;
            while (j >= gap && arr[j - gap] > temp) {
                arr[j] = arr[j - gap];
                j -= gap;
            }
            arr[j] = temp;
        }
        gap /= 2;
    }
}

// void HeapSort(int arr[], int size) {
//     for (int i = size / 2 - 1; i >= 0; i--) {
//         heapify(arr, size, i);
//     }
//     for (int i = size - 1; i > 0; i--) {
//         std::swap(arr[0], arr[i]);
//         heapify(arr, i, 0);
//     }
// }
//
// Pyramid Sort!!!!
// **********************************************************************
void siftDown(int arr[], int start, int end) {
    int root = start;
    while (2 * root + 1 <= end) {
        int child = 2 * root + 1;   // левый потомок
        int largest = root;

        if (arr[largest] < arr[child]) {
            largest = child;
        }
        // проверка правого потомка
        if (child + 1 <= end && arr[largest] < arr[child + 1]) {
            largest = child + 1;
        }

        if (largest == root) {
            break;  // куча в порядке
        }

        // обмен
        int temp = arr[root];
        arr[root] = arr[largest];
        arr[largest] = temp;

        root = largest;
    }
}

// Построение max-heap из массива
void heapify(int arr[], int n) {
    // последний родитель — узел с индексом (n / 2 - 1)
    for (int i = n / 2 - 1; i >= 0; --i) {
        siftDown(arr, i, n - 1);
    }
}

// Основная функция сортировки кучей
void HeapSort(int arr[], int n) {
    if (n <= 1) return;

    // 1. Построить max-heap
    heapify(arr, n);

    // 2. Последовательно извлекать максимумы
    for (int end = n - 1; end > 0; --end) {
        // Переместить корень (максимум) в конец неотсортированной части
        int temp = arr[0];
        arr[0] = arr[end];
        arr[end] = temp;

        // Восстановить кучу в диапазоне [0, end-1]
        siftDown(arr, 0, end - 1);
    }
}

void heapify(int arr[], int size, int root) {
    int largest = root;
    int left = 2 * root + 1;
    int right = 2 * root + 2;

    if (left < size && arr[left] > arr[largest]) {
        largest = left;
    }
    if (right < size && arr[right] > arr[largest]) {
        largest = right;
    }
    if (largest != root) {
        std::swap(arr[root], arr[largest]);
        heapify(arr, size, largest);
    }
}
//********************************************************

// Fast Sort
void FastSort(int arr[], int size) {
    if (size <= 1) return;

    int pivot = arr[size / 2];
    int i = -1, j = size;

    while (true) {
        do ++i; while (arr[i] < pivot);
        do --j; while (arr[j] > pivot);
        if (i >= j) break;
        std::swap(arr[i], arr[j]);
    }

    FastSort(arr, i);
    FastSort(arr + i, size - i);
}

int main() {
    //Shell
    // int n;
    // std::cin >> n;
    // int* arr = new int[n];
    // createArray(arr, n);
    // printArray(arr, n);
    // ShellSort(arr, n);
    // printArray(arr, n);
    // return 0;

    //Pyramid
    // int n;
    // std::cin >> n;
    // int* arr = new int[n];
    // createArray(arr, n);
    // printArray(arr, n);
    // HeapSort(arr, n);
    // printArray(arr, n);
    // return 0;

    //FastSort
    int n;
    std::cin >> n;
    int* arr = new int[n];
    createArray(arr, n);
    printArray(arr, n);
    FastSort(arr, n);
    printArray(arr, n);
    return 0;
}
