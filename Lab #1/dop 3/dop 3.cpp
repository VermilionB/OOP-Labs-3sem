#include<iostream>
#include<ctime>
#define SIZE 10
using namespace std;

void Sort_increase(int[], int, int);
void Sort_decrease(int[], int, int);

int main() {
	setlocale(LC_ALL, "RUS");
	srand((unsigned)time(NULL));

	int arr[SIZE];
	cout << "Массив: ";
	for (int i = 0; i < SIZE; i++) {
		arr[i] = rand() % 30;
		cout << arr[i] << " ";
	}

	Sort_increase(arr, 4, 0);
	Sort_decrease(arr, SIZE, SIZE - 4);

	cout << "\n\nОтсортированный массив: ";
	for (int i = 0; i < SIZE; i++) {
		cout << arr[i] << " ";
	}
}

void Sort_increase(int arr[], int sz, int start) {
	int t, i, j;
	for (i = start + 1; i < sz; i++) {
		t = arr[i];
		for (j = i - 1; j >= 0 && arr[j] > t; j--) arr[j + 1] = arr[j];
		arr[j + 1] = t;
	}
}

void Sort_decrease(int arr[], int size, int start) {
	int t, i, j;
	for (i = start + 1; i < size; i++) {
		t = arr[i];
		for (j = i - 1; j >= 0 && arr[j] < t; j--) arr[j + 1] = arr[j];
		arr[j + 1] = t;
	}
}