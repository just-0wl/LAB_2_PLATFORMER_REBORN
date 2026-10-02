Сцены:

PlatformerDemo.unity : Главная сцена с геймплеем - первый уровень, на котором игрок управляет персонажем. На сцене есть платформы, ямы и декорации. Локация уровня - лес.



Префабы основной игровой сцены PlatformerDemo.unity:

TreesBackground, CharacterPlatformer.



Игрок состоит из компонентов:

Transform, Sprite Renderer, Animator, Rigidbody 2D, Capsule Collider 2D, Player Character (Script), Character Anim (Script), Character Hold Item (Script).



Через Inspector можно настроить позицию, поворот, размеры, спрайт, анимацию, физику, коллайдер и скрипты игрока.



Скрипты проекта:

CarryItem.cs - позволяет играбельному персонажу носить предметы.

CharacterAnim.cs - настраивает анимацию игрока.

CharacterHoldItem.cs - позволяет играбельному персонажу держать предметы в руке.

FollowCamera.cs - камера следит за игроком.

Lever.cs - скрипт c функционалом рычагов.

ParallaxBackground.cs - создаёт эффект паралакса для фона.

PlayerCharacter.cs - скрипт управления персонажем.

PlayerControls.cs - список клавиш для управления персонажем.

TheAudio.cs - главный скрипт для проигрывания аудио.



