===Платформы===
Билд по Windows:

&#x09;Architecture: Intel 64-bit
	Compression Method: Default
Билд Android:
	В разработке
Web Билд:
	В разработке

\--------------------------------


=======Пэкеджи=======
Unity Packages:
	Asset Store:
		Simple 2D Template https://assetstore.unity.com/packages/p/simple-2d-template-137981
	Unity:

&#x09;	Custom NUnit
		JetBrains Rider Editor
		Test Framework

&#x09;	Visual Studio Editor

\--------------------------------





===Структура===

IndieMarc:
	PlatformerDemo:

&#x09;	Иконка игры

&#x09;	PDF руководство
		Игровая сцена
		Editor:

&#x09;		ImportPackage.cs - Инициализирует правильные настройки после импорта
		Materials:
			Материалы
		Prefabs:
			Игрок
			Трава
			Рычаг
			Лес
		Scripts:

&#x09;		CarryItem.cs - Скрипт, позволяющий персонажу носить предметы

&#x09;		CharacterAnim.cs - Скрипт, анимирующий персонажа

&#x09;		CharacterHoldItem.cs - Скрипт, для непосредственно хватания игроком

&#x09;		FollowCamera.cs - Скрипт, привязывающий камеру к игроку
			Lever.cs - Скрипт рычага

&#x09;		ParallaxBackground.cs - Скрипт движения фона

&#x09;		PlayerCharacter.cs - Главный скрипт игрока - ходьба, здоровье, прыжки

&#x09;		PlayerControls - Скрипт, принимающий нажатие клавиш игроком

&#x09;		TheAudio.cs - Скрипт, для продвинутой работы со звуком

&#x09;	Sprites:

&#x09;		Спрайты кругов
			Background:

&#x09;			Спрайты травы и деревьев

&#x09;		Character:

&#x09;			Анимации игрока

&#x09;			Тайл мап спрайты игрока

&#x09;		Lever:

&#x09;			Спрайты рычага

&#x09;		Tilemap:

&#x09;			Black:

&#x09;				Черные тайлы

&#x09;			Old:

&#x09;				Синие тайлы

&#x09;			Префаб с сеткой

\--------------------------------



=======Размер на диске=======
Суммарный размер всех файлов проекта: \~150 Мб
Размер папки Assets: \~3-5 МБ
Прогнозируемый размер билда: \~43 МБ

\---------------------------------


