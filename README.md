# Unity 3D: ходьба по плоскости и сбор монет

В репозитории добавлена базовая механика:
- перемещение персонажа по WASD/стрелкам;
- поворот персонажа в сторону движения;
- монетки вращаются и собираются при касании;
- UI-счётчик монет обновляется в реальном времени.

## Что добавлено

- `Assets/Scripts/PlayerController.cs` — движение персонажа через `CharacterController`.
- `Assets/Scripts/Coin.cs` — логика монеты: вращение, триггер, начисление очков.
- `Assets/Scripts/GameManager.cs` — singleton-менеджер количества монет и обновление UI (`TMP_Text`).

## Как настроить сцену

1. Создай `Plane`.
2. Создай `Player` (например, `Capsule`):
   - добавь `CharacterController`;
   - добавь скрипт `PlayerController`;
   - установи тег `Player`.
3. Создай `Coin` (например, `Cylinder`/`Sphere`):
   - добавь `Collider` с `Is Trigger = true`;
   - добавь скрипт `Coin`.
4. Сделай префаб `Coin` и расставь несколько копий на сцене.
5. Создай пустой объект `GameManager` и повесь `GameManager` скрипт.
6. На Canvas добавь `TextMeshPro - Text` и привяжи в поле `Coins Text` у `GameManager`.

## Зависимости

- Unity Input Manager (старый input, `Input.GetAxis`)
- TextMeshPro (`TMPro`)

## Идеи для расширения

- Добавить спавнер монет.
- Добавить таймер уровня.
- Добавить звук/эффект при сборе.
