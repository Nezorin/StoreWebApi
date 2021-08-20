# StoreWebApi
WebAPI включающее в себя стандартные CRUD операции для работы с БД.
В решении присутствуют 3 проекта: WebAPI (ASP.NET Core), DataAccessLayer (Class Library), Domain (Class Library).

WebAPI: стандартное API, содержащие GET,POST,PUT,DELETE запросы, для проверки работы присутствует Swagger.

Domain: библиотека классов содержащаяя DTO объекты, профиль для маппинга этих объектов(AutoMapper), сервисы для работы с сущностями

DataAccessLayer: содержит контекст БД(EF) и сущности, также реализован паттерн репозиторий.
