array = [
	"1. Создать абстрактный базовый класс с виртуальной функцией - площадь. Создать производные классы: прямоугольник, круг, прямоугольный треугольник, трапеция со своими функциями площади. Для проверки определить массив ссылок на абстрактный класс, которым присваиваются адреса различных объектов. Площадь трапеции:S=(a+b)h/2",
	"2. Создать абстрактный класс с виртуальной функцией: норма. Создать производные классы: комплексные числа, вектор из 10 элементов, матрица (2х2). Определить функцию нормы - для комплексных чисел - модуль в квадрате, для вектора - корень квадратный из суммы элементов по модулю, для матрицы - максимальное значение по модулю.",
	"3. Создать абстрактный класс (кривые) вычисления координаты y для некоторой x. Создать производные классы: прямая, эллипс, гипербола со своими функциями вычисления y в зависимости от входного параметра x. Уравнение прямой: y=ax+b , эллипса: x2/a2+y2/b2=1, гиперболы: x2/a2-y2/b2=1",
	"4. Создать абстрактный базовый класс с виртуальной функцией - сумма прогрессии. Создать производные классы: арифметическая прогрессия и геометрическая прогрессия. Каждый класс имеет два поля типа double. Первое - первый член прогрессии, второе (double) - постоянная разность (для арифметической) и постоянное отношение (для геометрической).",
	"5. Создать базовый класс список. Реализовать на базе списка стек и очередь с виртуальными функциями вставки и вытаскивания.",
	"6. Создать базовый класс - фигура, и производные класс - круг, прямоугольник, трапеция. Определить виртуальные функции площадь, периметр и вывод на печать.",
	"7. Создать базовый класс - работник и производные классы - служащий с почасовой оплатой, служащий в штате и служащий с процентной ставкой. Определить функцию начисления зарплаты.",
	"8. Создать абстрактный базовый класс с виртуальной функцией - площадь поверхности. Создать производные классы: параллелепипед, тетраэдр, шар со своими функциями площади поверхности. Для проверки определить массив ссылок на абстрактный класс, которым присваиваются адреса различных объектов.",
	"9. Создать класс человек, производные от которого девушки и молодые люди. Определить виртуальную функцию реакции человека на вновь увиденного другого человека.",
	"10. Создать абстрактный базовый класс с виртуальной функцией - объем. Создать производные классы: параллелепипед, пирамида, тетраэдр, шар со своими функциями объема. Для проверки определить массив ссылок на абстрактный класс, которым присваиваются адреса различных объектов.",
	"11. Создать абстрактный класс - млекопитающие. Определить производные классы - животные и люди. У животных определить производные классы собак и коров. Определить виртуальные функции описания человека, собаки и коровы.",
	"12. Создать базовый класс - Предок, у которого есть имя. определить виртуальную функцию печати. Создать производный класс Ребенок, у которого функция печати дополнительно выводит имя. Создать производный класс от последнего класса - Внук, у которого есть отчество. Написать свою функцию печати.",
	"13. Создать класс живущих с местоположением. Определить наследуемые классы - лиса, кролик и трава. Лиса ест кролика. Кролик ест траву. Лиса может умереть - определен возраст. Кролик тоже может умереть. Кроме этого определен класс - отсутствие жизни. ",
	"14. Создать абстрактный базовый класс с виртуальной функцией - корни уравнения. Создать производные классы: класс линейных уравнений и класс Создать класс живущих с местоположением. Определить наследуемые классы - лиса, кролик и трава. Лиса ест кролика. Кролик ест траву. ",
]

for x in array:
	print(x)