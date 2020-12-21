Poniższy plik pozwoli łatwiej zrozumieć strukturę programu.

Wymagane funkcjonalności zostały zaimplementowane w następujący sposób :

1)Stworzono abstakcyjną klasę Shape.

2)Stworzono interfejs IAreaShape z metodą CalculateArea() dla figur posiadających pole.
  Stworzono interfejs IVolumeShape z metodą CalculateVolume() dla figur posiadających objętość.

3)Stworzono abstrakcyjną klasę FlatShape dziedziczącą po Shape i implementującą IAreaShape.
  Stworzono abstrakcyjną klasę SolidShape diedziczącą po Shape, implementującą IAreaShape i IVolumeShape.

4)Stworzono klasy Square i Circle dziedziczące po FlatShape.
  Stworzono klasy Cube i Sphere dziedziczące po SolidShape.

5)Stworzono interfejs IFigureComparer z metodą Compare().

6)Stworzono klasy AreaComparer i VolumeComparer.

7)Napisano klasę testową na podstawie przykładowego użycia programu z treści zadania.

