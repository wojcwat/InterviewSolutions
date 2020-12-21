Poniższy plik przedstawia schemat wykonania zadania.

1)Stworzono interfejs ILogOutput

2)Stworzono dwie klasy implementujące ILogOutput (FileLogOutput i ConsoleLogOutput)

3)Zmieniono klasę Logger na JsonLogger

4)Stworzono klasę XmlLogger implementującą ILogger

W celu rozszerzenia loggera o dodatkowy sposób formatowania wystarczy dodać nową klasę ABCLogger implementującą ILogger(analogicznie do JsonLogger i XmlLogger).