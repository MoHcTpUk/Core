# Core

Ядро приложенения.

Содержит базовые сущности для работы с репозиториями, сервисами и командами а так же реализует паттерн Dependency Injection и CQRS (MediatR).

- **Core.DAL** Data Access Layer, содержит репозитории и базовые сущности
- **Core.BLL** Business Logic Layer, содержит сервисы и конфигурацию Dependency Injection
- **Core.Module.MongoDb** - поддержка MongoDb

Ядро сканирует все сборки в приложении на наличие сервисов, репозиториев, команд и контекстов и внедряет их в систему Dependency Injection.
