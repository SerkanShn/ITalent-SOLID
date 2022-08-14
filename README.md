# SOLID
SOLID prensibi Robert C. Martin tarafından sunulan ve geliştirdiğimiz yazılımın okunabilir, geliştirilebilir ve esnek bir yapıda olmasını sağlayan prensiptir.

- Single Responsibility Principle (SRP)
- Open Closed Principle (OSP)
- Liskov Substitution Principle (LSP)
- Interface Segregation Principle (ISP)
- Dependency Inversion Principle (DIP)


## Single Responsibility Principle (SRP)
Her class'ın kendine ait tek bir görevi yani sorumluluğu olmalıdır. Eğer birden fazla görevi bulunuyorsa bu SRP' ye uymamaktadır.
## Open Closed Principle (OSP)
Her class geliştirmeye açık olmalı fakat değişime kapalı olmalıdır. İleride farklı bir fonksiyon geldiğinde diğer kısımlara dokunmadan eklenebilir halde olmalıdır.
## Liskov Substitution Principle (LSP)
Türetilen sınıflar türeyen sınıflardan kalıtım olarak aldığı bütün özellikleri kullanmak zorundadır.
## Interface Segregation Principle (ISP)
Her interface'in kendine ait bir görevi olmalıdır. Birbirinden ayrı gruplara hizmet veren fonksiyonları ayrı interfacelerde toplamamız gerekir.
## Dependency Inversion Principle (DIP)
Üst seviye sınıflar ile alt seviye sınıflar bağlı olmamalıdır. Bunun yerine araya bir soyutlama olmalıdır.
