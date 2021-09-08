#include<iostream>
#include<ctime>
#define SIZE 15
using namespace std;

int main() {
	setlocale(LC_ALL, "RUS");
	srand((unsigned)time(NULL));

	int arr[SIZE];
	cout << "Массив: ";
	for (int i = 0; i < SIZE; i++) {
		arr[i] = (rand() % 10) - 5;
		cout << arr[i] << " ";
	}

	int newSize = SIZE;
	for (int i = 0; i < newSize; i++) {
		for (int j = i + 1; j < newSize; j++) {
			if (arr[i] == arr[j]) {
				for (int k = j; k < newSize; k++) arr[k] = arr[k + 1];
				newSize--;
			}
		}
	}

	cout << "\n\nНовый массив: ";
	for (int i = 0; i < newSize; i++) {
		cout << arr[i] << " ";
	}
}