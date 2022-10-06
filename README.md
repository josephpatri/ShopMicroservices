# ShopMicroservices

**A functional shop with microservices on docker and kubernetes enviroments**

---

:flags: These projects will have implemented patterns such as dependency injection, repositories, extension methods, reuse of functionality with local nuget packages.

:telephone: Each application is stored in a Docker container and will establish asynchronous communications through RabbitMQ with retry and health check logics.

:cloud: These containers at the same time will be orchestrated by Kubernetes in which we will deploy each independent image on the node enabling a node-port to be able to access them externally.

:mag_right: The architecture will implement the api-gateway pattern to control requests within the environment.

:mega: Finally we will implement a SPA with react that will consume these microservices.
