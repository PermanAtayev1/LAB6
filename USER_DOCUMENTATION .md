# Пользовательская документация

## 1. Введение

Программа **PKG_6** предназначена для визуализации работы аффинных преобразований в трёхмерной графике. С её помощью пользователи могут выполнять вращение, перенос и масштабирование трёхмерного объекта, наблюдать изменения в реальном времени, а также управлять проекциями и положением наблюдателя.

Приложение разработано для образовательных целей и может быть использовано для изучения основ работы с матрицами преобразований и их применения в компьютерной графике.

---

## 2. Системные требования

- **Операционная система**: Windows 7 и выше
- **Программное обеспечение**: .NET Framework 4.7.2 или выше
- **Аппаратные требования**:
  - Процессор: с тактовой частотой не менее 1 ГГц
  - Оперативная память: не менее 512 МБ
  - Свободное место на диске: 50 МБ
  - Дисплей: разрешение не менее 1024x768 пикселей

---

## 3. Установка

### 3.1 Установка Visual Studio

1. Скачайте последнюю версию Visual Studio с официального сайта: [visualstudio.microsoft.com](https://visualstudio.microsoft.com).
2. Установите Visual Studio, выбрав рабочую нагрузку **"Разработка приложений для рабочего стола на .NET"**.

### 3.2 Скачивание программы

1. Перейдите в репозиторий проекта (если доступен) или получите исходный код программы.
2. Сохраните проект в удобной для вас папке.

### 3.3 Сборка и запуск программы

1. Откройте файл решения `PKG_6.sln` в Visual Studio.
2. Нажмите `Ctrl+Shift+B` для сборки проекта.
3. После успешной сборки нажмите `F5` для запуска программы.

---

## 4. Использование приложения

### 4.1 Элементы управления

Программа имеет следующие основные элементы управления:

1. **Холст (`PictureBox`)**:
   - Отображает трёхмерный объект, оси координат и сетку.
   - Поддерживает вращение объекта с помощью мыши (зажмите левую кнопку и перемещайте мышь).

2. **Слайдеры (`TrackBar`)**:
   - **Вращение объекта**:
     - `tbAngleOx`, `tbAngleOy`, `tbAngleOz` — вращение вокруг осей \(O_x\), \(O_y\), \(O_z\) в локальной системе координат.
   - **Вращение наблюдателя**:
     - `tbGlobalCoordsOx`, `tbGlobalCoordsOy`, `tbGlobalCoordsOz` — вращение вокруг осей \(O_x\), \(O_y\), \(O_z\) в глобальной системе координат.

3. **Поля ввода (`NumericUpDown`)**:
   - Перенос объекта:
     - `numUDTranslateOx`, `numUDTranslateOy`, `numUDTranslateOz` — ввод координат для переноса объекта.
   - Масштабирование:
     - `numUDScale` — коэффициент масштабирования.
   - Расстояние до объекта:
     - `numUDDist` — расстояние наблюдателя от объекта.

4. **Кнопки**:
   - `bTranslate` — применить перенос.
   - `bScale` — применить масштабирование.
   - `bDist` — изменить расстояние до объекта.
   - `bResetAffine` — сбросить все аффинные преобразования.
   - `bResetPicture` — сбросить положение наблюдателя.

5. **Радиокнопки (`RadioButton`)**:
   - Выбор проекции:
     - Фронтальная
     - Профильная
     - Горизонтальная
   - Включение/выключение отображения глобальной системы координат.

---

### 4.2 Основные функции

#### Вращение объекта
1. Используйте слайдеры `tbAngleOx`, `tbAngleOy`, `tbAngleOz`, чтобы задать угол вращения вокруг соответствующих осей.
2. Объект будет обновляться в реальном времени.

#### Перенос объекта
1. Введите значения смещения по осям \(O_x\), \(O_y\), \(O_z\) в соответствующие поля.
2. Нажмите кнопку **"Применить перенос"**.

#### Масштабирование объекта
1. Укажите коэффициент масштабирования в поле `numUDScale`.
2. Нажмите кнопку **"Применить масштабирование"**.

#### Вращение наблюдателя
1. Используйте слайдеры `tbGlobalCoordsOx`, `tbGlobalCoordsOy`, `tbGlobalCoordsOz`, чтобы задать угол вращения вокруг осей в глобальной системе координат.
2. Объект будет обновляться в реальном времени.

#### Сброс настроек
- Нажмите **"Сбросить преобразования"**, чтобы вернуть объект в исходное состояние.
- Нажмите **"Сбросить положение наблюдателя"**, чтобы вернуть камеру в начальное положение.

#### Изменение проекции
1. Выберите одну из радиокнопок для переключения проекции:
   - **Фронтальная**: вид спереди.
   - **Профильная**: вид сбоку.
   - **Горизонтальная**: вид сверху.
2. Проекция изменится автоматически.

---

## 5. Пример использования

### Пример 1: Вращение объекта
1. Перетащите слайдер `tbAngleOx` вправо, чтобы повернуть объект вокруг оси \(O_x\).
2. Перетащите слайдер `tbAngleOy` вправо, чтобы повернуть объект вокруг оси \(O_y\).
3. Объект изменит своё положение согласно заданным углам.

### Пример 2: Перенос объекта
1. Введите значения \(x = 10\), \(y = 5\), \(z = -3\) в поля переноса.
2. Нажмите кнопку **"Применить перенос"**.
3. Объект переместится на указанные координаты.

### Пример 3: Масштабирование объекта
1. Укажите значение \(2.0\) в поле масштабирования.
2. Нажмите кнопку **"Применить масштабирование"**.
3. Объект увеличится в 2 раза.

---

## 6. Обратная связь

Если у вас возникли вопросы или вы обнаружили ошибку, отправьте сообщение на электронную почту: **imprmnata00@gmail.com**.

---

## 7. Приложения

### Приложение 1. Список реализованных функций

1. Вращение объекта вокруг осей \(O_x\), \(O_y\), \(O_z\) в локальной системе координат.
2. Вращение наблюдателя вокруг осей \(O_x\), \(O_y\), \(O_z\) в глобальной системе координат.
3. Перенос объекта.
4. Масштабирование объекта.
5. Сброс положения объекта и наблюдателя.
6. Изменение проекций.

### Приложение 2. Возможные улучшения

1. Добавление перспективной проекции.
2. Реализация поддержки нескольких объектов.
3. Улучшение пользовательского интерфейса.

---

## Лицензия

Программа распространяется на условиях лицензии MIT. Вы можете свободно использовать и модифицировать её в соответствии с условиями лицензии.

---

## Дополнительные материалы

- Репозиторий проекта: [GitHub Link](https://github.com/PermanAtayev1/LAB6)
- Документация по аффинным преобразованиям: [Affine Transformations](https://en.wikipedia.org/wiki/Affine_transformation)

---

## Обновления документации

Документация обновляется с выходом новых версий программы. Рекомендуется регулярно проверять актуальность документации.