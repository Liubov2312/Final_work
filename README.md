# Final_work
## Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Описание алгоритма решения:
Задаются два массива типа *string*. Первый - исходный. Второй - такой же длины с нулевыми элементами, в него будут записываться элементы, подходящие под представленное условие (<= 3). Программа выполняется двумя методами.
 **Первый метод** - в цикле *for* проверяется каждый элемент первого массива по условию <= 3, и записываются во второй массив только те элементы, которые проходят по условию (при этом также переменная *item* увеличивается на единицу, что бы во втором массиве не было пробелов при невыполнении условия).
**Второй метод** - выводит массивы на печать.

Код решения представлен: *Final_work/final_work/Program.cs*

**Блок схема** представлена в двух файлах с разными расширениями.
