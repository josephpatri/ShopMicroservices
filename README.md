# ShopMicroservices
CI Pipelines Build Status:

Shop.Common:
[![Build status](https://dev.azure.com/josephville12/Microservices/_apis/build/status/Shop.Common)](https://dev.azure.com/josephville12/Microservices/_build/latest?definitionId=7)

Package status: [![Shop.Common package in Commons feed in Azure Artifacts](https://feeds.dev.azure.com/josephville12/_apis/public/Packaging/Feeds/Commons/Packages/83ddd6a7-8d1c-4ff2-be1f-caf879700ed9/Badge)](https://dev.azure.com/josephville12/Microservices/_artifacts/feed/Commons/NuGet/Shop.Common?preferRelease=true)

Shop.Catalog:
[![Build Status](https://dev.azure.com/josephville12/Microservices/_apis/build/status/Shop.Catalog?branchName=develop)](https://dev.azure.com/josephville12/Microservices/_build/latest?definitionId=8&branchName=develop)

Shop.Inventory:
[![Build Status](https://dev.azure.com/josephville12/Microservices/_apis/build/status/Shop.Inventory?branchName=develop)](https://dev.azure.com/josephville12/Microservices/_build/latest?definitionId=10&branchName=develop)



**A functional shop with microservices on docker and kubernetes enviroments**

---

:flags: These projects will have implemented patterns such as dependency injection, repositories, extension methods, reuse of functionality with local nuget packages.

:telephone: Each application is stored in a Docker container and will establish asynchronous communications through RabbitMQ with retry and health check logics.

:cloud: These containers at the same time will be orchestrated by Kubernetes in which we will deploy each independent image on the node enabling a node-port to be able to access them externally.

:mag_right: The architecture will implement the api-gateway pattern to control requests within the environment.

:mega: Finally we will implement a SPA with react that will consume these microservices.
