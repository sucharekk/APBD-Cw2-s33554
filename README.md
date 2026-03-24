# APBD-Cw2-s33554





Wybrałem podział na warstwy Modelu (dane), Serwisu (logika) i Prezentacji (interfejs), aby odizolować odpowiedzialności i zwiększyć czytelność kodu. Taka struktura ułatwia niezależną modyfikację logiki biznesowej bez konieczności ingerencji w sposób wyświetlania danych użytkownikowi.



Separacja Odpowiedzialności (SRP): Kod został podzielony na modele danych, serwis logiczny (Service) oraz warstwę prezentacji (Launcher), co ułatwia zarządzanie projektem.



Wysoka Kohezja: Każda klasa ma jedno zadanie – np. klasa Rent odpowiada wyłącznie za dane o wypożyczeniu i naliczanie kar, nie ingerując w logikę kolekcji.



Niskie Sprzężenie: Dzięki operowaniu na klasach abstrakcyjnych Device i User, klasa Service nie musi się przejmować konkretnym typem sprzętu.



Zasada Open/Closed (SOLID): Nowe typy sprzętu lub użytkowników można dodawać bez modyfikacji istniejącego kodu serwisu, wykorzystując polimorfizm i dziedziczenie.



Polimorfizm w regułach biznesowych: Limity wypożyczeń (DevicesCap) są zdefiniowane w klasach pochodnych użytkowników, co pozwala na łatwą zmianę parametrów systemu.



Obsługa Błędów: Zastosowałem autorskie wyjątki (np. TooManyDevices), co pozwala na jawną i czytelną kontrolę poprawności operacji biznesowych.

