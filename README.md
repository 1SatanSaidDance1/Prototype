Вывод:
	
	Преимущества и недостатки IMyCloneable:

		Преимущества:
			Позволяет создавать типобезопасные клоны объектов.
			Легко расширяется для новых типов.
		
		Недостатки:
			Требует дополнительной реализации для каждого класса.
			Может усложнить код, если используется в большом количестве классов.

	Преимущества и недостатки ICloneable
	
		Преимущества:
			Стандартный интерфейс, который уже известен многим разработчикам.
			Легко интегрируется с существующими библиотеками и фреймворками.
		Недостатки:
			Возвращает объект типа object, что требует приведения типов.
			Менее типобезопасен по сравнению с IMyCloneable.
