# Шаблон "Адаптер"

- **[`ILogger`](./1Adapter/ILogger.cs)** — інтерфейс для логування з методами: `Log()`, `Error()`, `Warn()`.
- **[`Logger`](./1Adapter/Logger.cs)** — консольний логер, що виводить повідомлення з кольоровим форматуванням.
- **[`FileWriter`](./1Adapter/FileWriter.cs)** — клас для запису в файл.
- **[`FileLoggerAdapter`](/1Adapter/FileLogerAdapter.cs)** — адаптер для використання `FileWriter` з інтерфейсом `ILogger`, записує логування у файл з префіксами `[INFO]`, `[ERROR]`, `[WARNING]`.

## Як працює

Адаптер дозволяє використовувати `FileWriter` як логер, забезпечуючи можливість запису логів у файл, замість прямого використання консольного логера.


# Шаблон "Декоратор"

- **[`IHero`](./2Decorator/IHero.cs)** — інтерфейс героя з методами: `GetDescription()` та властивостями: `Strength`, `Agility`, `Wisdom`, `Charisma`.
- **Warrior**, **Mage**, **Palladin** — [`базові класи героїв`](./2Decorator/Heroes.cs).
- **[`HeroDecorator`](./2Decorator/HeroDecorator.cs)** — абстрактний декоратор, реалізує інтерфейс `IHero`, обгортаючи базового героя.

### [`Класи предметів:`](./2Decorator/Decorations.cs) 
- **Sword** — додає +5 до сили та опис "Sword".
- **Armor** — додає +2 до сили, +3 до спритності та опис "Armor".
- **Artifact** — додає +5 до мудрості, +4 до харизми та опис "Magic Artifact".

## Як працює

Шаблон **"Декоратор"** дозволяє динамічно додавати нову функціональність до об'єкта (`IHero`) без зміни його структури.  
Кожен новий елемент екіпірування (меч, броня, артефакт) додається як обгортка навколо базового героя.


# Шаблон "Міст"

- **[`IRenderer`](./3Bridge/IRenderer.cs)** — інтерфейс для візуалізації фігур.
- **VectorRenderer** та **RasterRenderer** — [`реалізації IRenderer`](./3Bridge/RenderTypes.cs) для векторного та растрового рендерингу.
- **[`Shape`](./KPZ_lab3.3Bridge/Shape.cs)** — абстрактний клас фігур, який містить посилання на `IRenderer`.
- **Circle**, **Square**, **Triangle** — [`конкретні фігури`](./3Bridge/Figures.cs), які викликають `Draw()` через відповідний рендерер.

## Як працює

Шаблон **"Bridge"** відокремлює абстракцію (`Shape`) від її реалізації (`IRenderer`), що дозволяє змінювати їх незалежно.


# Шаблон "Проксі"

- **[`ITextReader`](./4Proxy/ITextReader.cs)** — інтерфейс для читання текстових файлів.
- **[`SmartTextReader`](./4Proxy/SmartTextReader.cs)** — базовий клас, який читає файл і повертає масив символів.
- **[`SmartTextChecker`](./4Proxy/SmartTextChecker.cs)** — проксі, який додає логування при читанні файлу.
- **[`SmartTextReaderLocker`](./4Proxy/SmartTextReaderLocker.cs)** — ще один проксі, який обмежує доступ до певних файлів за шаблоном.

## Як працює

Проксі об'єкти (`SmartTextChecker`, `SmartTextReaderLocker`) реалізують інтерфейс `ITextReader` і контролюють доступ до справжнього читача файлів (`SmartTextReader`).


# Шаблон "Компонувальник"

- **[`LightNode`](./5Composit/LightNode.cs)** — абстрактний базовий клас вузла дерева.
- **[`LightElementNode`](./5Composit/LightElementNode.cs)** — вузол-елемент (тег HTML), який може мати дочірні вузли.
- **[`LightTextNode`](./5Composit/LightTextNode.cs)** — вузол-текст, який містить лише текст.

## Як працює

Шаблон дозволяє будувати дерево HTML-документа, де **і текст**, і **елементи** можуть оброблятися однаково через спільний базовий клас `LightNode`.


# Шаблон "Легковаговик"

- **[`FlyweightFactory`](./6Flyweight/FlyweightFactory.cs)** — фабрика, яка керує спільними екземплярами HTML-елементів (`LightElementNode`).
- **[`LightHTMLConverter`](./6Flyweight/LightHTMLConverter.cs)** — перетворює текст у список HTML-вузлів, використовуючи шаблон Flyweight для економії памʼяті.
- **Використовує `LightElementNode` та `LightTextNode` з шаблону Компонувальник.**

## Як працює

Шаблон **Flyweight** дозволяє розділяти обʼєкти, що мають однаковий внутрішній стан, зменшуючи споживання памʼяті.
**Згідно із завданням**, вхідний текст ділиться на різні HTML-елементи залежно від його змісту та позиції.
