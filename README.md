# ObjectiveTestExercise2

Привет это апи.

                                                          Описание методов:

          GetCount
          
    Метод: GET

    Путь: /count/GetCount

Описание: Этот метод позволяет получить текущее значение счетчика.

  Пример запроса:

GET https://localhost:7056/count/GetCount

  Пример ответа:
    200 OK
    125

    
          AddCount
          
    Метод: GET
    
    Путь: /count/AddCount/{number}

Описание: Этот метод позволяет увеличить значение счетчика на указанное число.

  Параметры запроса:

number (int, обязательный) - Число, на которое нужно увеличить счетчик.


  Пример запроса:

GET https://localhost:7056/count/AddCount/5
  Пример ответа (успешно):

200 OK

  Пример ответа (ошибка):

  400 Bad Request
  
Это API предоставляет простой способ управления и чтения счетчика с использованием блокировок для обеспечения потокобезопасности. 

Метод GetCount читает значение счетчика, не блокируя другие читатели, 

и метод AddCount увеличивает значение счетчика с блокировкой на запись, чтобы предотвратить конфликты записи из разных потоков.


                                                          Параметры запуска
                                                                        
В проекте есть папка "Release", внутри нее есть файл "ObjectiveTestExercise.exe".

Для запуска приложения нужно запустить этот файл.

Для корректной работы не нужно менять состояние папки "Release". В ней находятся исполняемые файлы
