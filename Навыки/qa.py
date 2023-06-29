array = [
	"1. В С# для обмена предусмотрено четыре типа параметров: параметры-значения, параметры-ссылки, выходные параметры, параметры-массивы. Сравните их.",
	"2. Охарактеризуйте механизм генерации исключительных ситуаций в С#.",
	"3. Сравните неизменяемые строки string и изменяемые строки StringBuilder. Ответ проиллюстрируйте примерами.",
	"4. Проведите анализ задач с регулярными выражениями.",
	"5. Как в С# организованы системы ввода-вывода в консольном режиме?",
	"6. Сформулируйте принципы наследования в С#. ",
	"7. Для чего используют виртуальные методы в С#.",
	"8. Для чего используют абстрактные методы и классы в С#.",
	"9. Как организовать запрет наследования в С#.",
	"10. Охарактеризуйте особенности структур в С#.",
	"11. Проклассифицируйте коллекции. Приведите пример.",
	"12. Охарактеризуйте особенности структур в С#.",
	"13. Проклассифицируйте коллекции. Приведите пример.",
	"14. Чем отличается С# от С++?",
	"15. Сравните чем отличается реализация массивов в С++ и С#?",
	"16. Можно ли при работе с многомерными массивами использовать приемы, которые используются для одномерных массивов в С#. Приведите примеры.",
	"17. Дайте характеристику статическим классам.",
	"18. Охарактеризуйте генерацию собственных исключений. Приведите пример.",
	"19. Охарактеризуйте особенности многоуровневой иерархии в С#.",
	"20. Сравните виртуальные и не виртуальные методы.",
]

for x in array:
	print(x)

qNumber = input()
fileName = "{q}.txt".format(q = qNumber)
f = open(fileName, "r")

for line in f:
	print(line)

f.close()