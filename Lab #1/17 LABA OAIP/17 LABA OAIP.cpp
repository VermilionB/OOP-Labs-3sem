#include <ctime>             
#include <stdlib.h>
#include <iostream>
using namespace std;
void insOrd(int m[], int sm, int em, int e)
{ // m[] - массив чисел; sm - индекс 1-ого элемента левой части; cm - индекс
  //последн. элемента левой части; em - индекс последн. элемента правой части
	int buf;
	int i = sm;
	while (i <= em && m[i] < e)
	{
		if (i - 1 >= sm)
			m[i - 1] = m[i];
		i++;
	}  m[i - 1] = e;
}
int* merge(int m[], int sm, int cm, int em)
{
	for (int i = 0; i <= sm; i++)
	{
		if (m[i] > m[cm + 1])
		{
			int buf = m[i];
			m[i] = m[cm + 1];
			insOrd(m, cm + 1, em, buf);
		}
	}
	return m;
}
int* sortMerge(int m[], int lm, int sm = 0)
{
	if (lm > 1)
	{
		sortMerge(m, lm / 2, sm);
		sortMerge(m, lm - lm / 2, sm + lm / 2);
		merge(m, sm, sm + lm / 2 - 1, sm + lm - 1);
	};
	return m;
}
//-------------------------------

void SelectSort_increase(int A[], int size)
{
	int k, i, j;
	for (i = 0; i < size - 1; i++)
	{
		for (j = i + 1, k = i; j < size; j++)
			if (A[j] < A[k])
				k = j;
		int c = A[k];
		A[k] = A[i];
		A[i] = c;
	}
}

//------------------------------
int* sort2(int m[], int lm)
{
	int buf;
	bool sort;
	for (int g = lm / 2; g > 0; g /= 2)
		do
		{
			sort = false;
			for (int i = 0, j = g; j < lm; i++, j++)
				if (m[i] > m[j])
				{
					sort = true;
					buf = m[i];
					m[i] = m[j];
					m[j] = buf;
				}
		} while (sort);
		return m;
}
//------------------------------
int getRandKey(int reg = 0)     // генерация случайных ключей
{
	if (reg > 0)
		srand((unsigned)time(NULL));
	int rmin = 0;
	int rmax = 100000;
	return (int)(((double)rand() / (double)RAND_MAX) * (rmax - rmin) + rmin);
}
//------------------------------
int main()
{
	setlocale(LC_CTYPE, "Russian");
	const int N = 30000;
	int k[N], f[N];
	clock_t  t1, t2;
	getRandKey(1);
	for (int i = 0; i < N; i++)
		f[i] = getRandKey(0);
	for (int n = 10000; n <= N; n += 10000)
	{
		cout << "n = " << n << endl;
		cout << "Сортировка слиянием ";
		memcpy(k, f, n * sizeof(int));
		t1 = clock();
		sortMerge(k, n);
		t2 = clock();
		cout << "Прошло " << t2 - t1 << " тактов времени" << endl;
		cout << "Прошло " << (t2 - t1) / CLK_TCK << " секунд" << endl << endl;
		///////////////////////////////////////////////////////////
		cout << "Сортировка Шелла   ";
		memcpy(k, f, n * sizeof(int));
		t1 = clock();
		sort2(k, n);
		t2 = clock();
		cout << "Прошло " << t2 - t1 << " тактов времени" << endl;
		cout << "Прошло " << (t2 - t1)/CLK_TCK << " секунд" << endl << endl;
		//////////////////////////////////////////////////////////////////
		cout << "Сортировка выбором   ";
		memcpy(k, f, n * sizeof(int));
		t1 = clock();
		SelectSort_increase(k, n);
		t2 = clock();
		cout << "Прошло " << t2 - t1 << " тактов времени" << endl;
		cout << "Прошло " << (t2 - t1) / CLK_TCK << " секунд" << endl << endl;
	}
	return 0;
}
