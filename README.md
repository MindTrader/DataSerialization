![GitHub last commit](https://img.shields.io/github/last-commit/MindTrader/DataSerialization?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/MindTrader/DataSerialization?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/MindTrader/DataSerialization?style=for-the-badge)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/MindTrader/DataSerialization?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/MindTrader/DataSerialization?style=for-the-badge)


# Data Serialization
Данное приложение создано для решения следующей задачи:  сериализация приложенного файла test.XML в JSON. Полученный JSON должен выглядить (не обязательно быть один к одному) как test.JSON — оба файла лежат в папке "OtherFiles/TestFiles".

Целевая платформа - .Net Framework 4.6.1

Приложение имеет графический пользовательский интерфейс, реализованный с использованием Windows Forms

## Описание работы приложения
При запуске приложения на экране появится окно, где пользователю необходимо выбрать XML файл с содержимым для дальнейшей сериализации. Кнопка "Сериализовать данные" неактивна:

<p align="center"><img src="https://github.com/MindTrader/DataSerialization/blob/98279c2bfb1ae6cc6d9b16efe086c1446f563c44/OtherFiles/Screenshots/MainWindow.jpg" alt="Главное окно приложение" title="Главное окно приложение"/></p>

После нажатия на кнопку "Выбрать файл" пользователю необходимо будет указать исходный файл с помощью диалогового окна Windows для открытия файла. При выборе файла с расширением, отличным от .Xml,
приложение выдаст пользователю предупреждение о несовпадении расширений и спросит решение хочет ли пользователь всё-таки использовать данный файл.

<p align="center"><img src="https://github.com/MindTrader/DataSerialization/blob/98279c2bfb1ae6cc6d9b16efe086c1446f563c44/OtherFiles/Screenshots/IncorrectExt.jpg" alt="Предупреждение о несовпадении расширения файла" title="Предупреждение о несовпадении расширения файла"/></p>

Если пользователь отвечает "Нет" или закрывает окно предупреждения, то выбор отменяется и пользователю придётся выбрать другой файл для дальнейшей сериализации.

После выбора файла кнопка "Сериализовать данные" становится активной и пользователь может запустить процесс сериализации:

<p align="center"><img src="https://github.com/MindTrader/DataSerialization/blob/98279c2bfb1ae6cc6d9b16efe086c1446f563c44/OtherFiles/Screenshots/SelectedXml.jpg" alt="Путь до выбранного файла" title="Путь до выбранного файла"/></p>

После успешной сериализации данных пользователю будет сообщён результат и будет предложено сохранить json данные в файл, имя и место которого он может указать, используя Windows диалог для сохранения файлов:

<p align="center"><img src="https://github.com/MindTrader/DataSerialization/blob/98279c2bfb1ae6cc6d9b16efe086c1446f563c44/OtherFiles/Screenshots/Success.jpg" alt="Сериализация прошла успешно" title="Сериализация прошла успешно"/></p>

<p align="center"><img src="https://github.com/MindTrader/DataSerialization/blob/98279c2bfb1ae6cc6d9b16efe086c1446f563c44/OtherFiles/Screenshots/Save.jpg" alt="Сохраните результат" title="Сохраните результат"/></p>

Однако в процессе сериализации могут возникнуть ошибки, при которых сериализация будет прервана и пользователю будет выведено сообщение об ошибке:

<p align="center"><img src="https://github.com/MindTrader/DataSerialization/blob/98279c2bfb1ae6cc6d9b16efe086c1446f563c44/OtherFiles/Screenshots/Fail_1.jpg" alt="Ошибка сериализации" title="Ошибка сериализации"/></p>

<p align="center"><img src="https://github.com/MindTrader/DataSerialization/blob/98279c2bfb1ae6cc6d9b16efe086c1446f563c44/OtherFiles/Screenshots/Fail_2.jpg" alt="Ошибка сериализации" title="Ошибка сериализации"/></p>

В таком случае пользователь должен выбрать подходящий файл и повторить сериализацию.

После окончания сериализации, кнопка "Сериализовать данные" становится снова неактивной, а в строке пути к .xml файлу пользователю будет предложено снова выбрать файл для обработки,
 т.е. главное окно примет вид начального состояния (первый скриншот) и пользователь сможет повторить вышеописанные действия.
 
 ## Тестирование приложения
 Для тестирования приложения, точнее метода `Serializer.Serialize(string pathToXml)`(определён в файле "DataSerialization/Serializer.cs"), было создано 5 Unit тестов, проверяющих работу метода в различных ситуациях.
 Исходный код тестов вы можете увидеть в файле "DataSerializationTests/SerializerTests.cs". В некоторых тестах были использованы различные файлы xml, 
 отличные от исходного ("OtherFiles/TestFiles/test.xml") - они расположены в каталоге "DataSerializationTests/testFiles"

## Установка приложения
Чтобы установить приложение - запустите установочный файл "OtherFiles/ForInstallation/setup.exe" и дождитесь окончания установки. После этого на рабочем столе появится ярлык для запуска приложения "Data Serialization"
