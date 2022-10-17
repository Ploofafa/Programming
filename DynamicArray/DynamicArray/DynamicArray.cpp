#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <cmath>
using namespace std;

struct DynamicArray
{
	int length = 4;
	
	double* array = new double[length];

	//Реализация заполнения массива случайными числами
	void RandomFillArray() 
	{
		double maxValue;
		double minValue;
		int roundCount = 100;

		cout << "Enter max random number: ";
		cin >> maxValue;

		cout << "Enter min random number: ";
		cin >> minValue;


		for (int i = 0; i < length; i++)
		{
			double number = (double)(rand()) / RAND_MAX * (maxValue - minValue) + minValue;
			// Вызываем метод round библиотеки cmath для округления вещественных чисел
			number = round(number * roundCount) / roundCount;
			array[i] = number;
		}
	}

	//Создаём массив вещественных чисел
	void CreateArray() 
	{
		delete[] array;

		cout << "Enter the length for array: ";
		cin >> length;

		array = new double[length];
	}

	//Заполнение массива
	void FillArray()
	{
		cout << "Choose filling method:" << endl;
		cout << "1.Randomly;" << endl << "2.From the keyboard." << endl;

		int choose;

		do
		{
			cin >> choose;
			if (choose == 2)
			{
				for (int i = 0; i < length; i++)
				{
					cout << "array[" << i << "] = ";
					cin >> array[i];
				}
				cout << "Array is filled." << endl;
			}

			else if (choose == 1)
			{
				RandomFillArray();
			}

			else
			{
				cout << "Enter the correct number: ";
			}
		} while (choose != 1 && choose != 2);
	}

	//Добавляем 1 элемент в конец массива
	void AppendEndElement()
	{
		cout << "Enter the number which you're wanna append in array:" << endl;
		double element;
		cin >> element;

		length++;
		double* temp = new double[length];
		for (int i = 0; i < length; i++) 
		{
			temp[i] = array[i];
		}
		delete[] array;
		array = new double[length];

		for (int i = 0; i < length; i++)
		{
			array[i] = temp[i];
		}

		array[length - 1] = element;
		delete[] temp;
	}

	//Добавляем в начало массива 1 элемент.
	void AppendStartElement() 
	{
		cout << "Enter the number which you're wanna append in array on start position: " << endl;
		double element;
		cin >> element;
		double* temp = new double[length];
		length++;

		for (int i = 0; i < length; i++)
		{
			temp[i] = array[i];
		}

		delete[] array;
		array = new double[length];
		
		for (int i = 0; i < length; i++)
		{
			array[i + 1] = temp[i];
		}

		array[0] = element;
		delete[] temp;
	}

	//Вставка после определённого элемента в массив
	void AppendArray() 
	{
		cout << "Enter index after which need insert element:" << endl;
		int index;
		cin >> index;

		cout << "Enter the number which you're wanna append in array:" << endl;
		double element;
		cin >> element;

		double* temp = new double[length];
		length++;

		for (int i = 0; i < length; i++)
		{
			temp[i] = array[i];
		}

		delete[] array;
		array = new double[length];

		for (int i = 0; i < index; i++)
		{
			array[i] = temp[i];
		}

		array[index] = element;

		for (int i = index + 1; i < length; i++)
		{
			array[i] = temp[i - 1];
		}

		delete[] temp;
	}

	// Вывод массива на экран
	void PrintArray()
	{
		cout << "Current array is:" << endl;
		for (int i=0; i < length; i++)
		{
			cout << array[i] << " ";
		}
		cout << endl;
	}

	//Сортировка массива методом выбора
	void SortArray()
	{
		double min;

		int index = 0;
		for (int i = 0; i < length - 1; i++)
		{
			min = array[i];
			index = i;
			for (int g = i + 1; g < length; g++)
			{
				if (array[g] < min)
				{
					min = array[g];
					index = g;
				}
			}
			if (index != i)
			{
				array[index] = array[i];
				array[i] = min;
			}
		}
		cout << "After sort ";
		PrintArray();
	}

	//Удаление элемента по индексу из массива
	void DeleteElement() 
	{
		cout << "Enter index of element array which need to delete:" << endl;
		int index;
		cin >> index;

		double* temp = new double[length];
		for (int i = 0; i < length; i++)
		{
			temp[i] = array[i];
		}

		length--;

		delete[] array;
		array = new double[length];

		for (int i = 0; i < index; i++) 
		{
			array[i] = temp[i];
		}

		for (int i = index; i < length; i++) 
		{
			array[i] = temp[i + 1];
		}
		delete[] temp;
	}

	//Реализация линейного поиска элемента в массиве
	void LinearSearch()
	{
		cout << "Enter the number to be found: " << endl;
		double number;
		cin >> number;

		for(int i = 0; i < length; i++)
		{
			if (array[i] == number)
			{
				cout << "The first number " << number << "located at index = " << i << endl;
				break;
			}
		}
	}

	void Search(double number)
	{
		return Search(0, length - 1, number);
	}


	//Реализация рекурсивной функции для бинарного поиска
	void Search(int left, int right, double number) 
	{
		int middle = (left + right) / 2;
		if (array[middle] == number)
		{
			cout << "Element founded at index = " << middle;
		}
		else if (right < left)
		{

		}
	}

	//Реализация бинарного поиска в массиве
	void BinarySearch() 
	{
		cout << "Enter the number to be found: " << endl;
		double number;
		cin >> number;

		

	}
};

void PrintMenu()
{
	cout << "----------------------------------------------------------------------------" << endl;
	cout << "Select the action you want to perform on the array: " << endl << "1. Create array;" << endl;
	cout << "2. Fill the array;" << endl;
	cout << "3. Append element in array;" << endl << "4. Append end element in array;" << endl;
	cout << "5. Append start element in array;" << endl << "6. Sort array;" << endl;
	cout << "7. Delete element from array;" << endl << "8.Linear search in an array;" << endl;
	cout << "9. Binary search in an array" << endl << "10. Print array." << endl;
	cout << "0. Out from program." << endl;
	cout << "----------------------------------------------------------------------------" << endl;
}

int main()
{
	DynamicArray p;
	
	int choose;

	PrintMenu();

	do {
		cout << "Select the action you want to perform on the array: " << endl;
		cin >> choose;
		switch (choose)
		{
		case 1:
			p.CreateArray();
			break;
		case 2:
			p.FillArray();
			break;
		case 3:
			p.AppendArray();
			break;
		case 4:
			p.AppendEndElement();
			break;
		case 5:
			p.AppendStartElement();
			break;
		case 6:
			p.SortArray();
			break;
		case 7:
			p.DeleteElement();
			break;
		case 8:
			 p.LinearSearch();
			break;
		case 9:
			cout << "In developing" << endl;
			break;
		case 10:
			p.PrintArray();
			break;
		case 0:
			cout << "You have successfully exited the program";
			break;
		default:
			PrintMenu();
			cout << "Enter the correct number: ";
			break;
		}
	} while (choose != 0);
}