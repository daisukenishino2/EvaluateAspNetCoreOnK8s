# EvaluateAspNetCoreOnK8s
KubernetesでASP.NET Coreを評価する。(Evaluate ASP.Net Core on Kubernetes.)

## [WebApplication1](https://github.com/daisukenishino2/EvaluateAspNetCoreOnK8s/tree/master/WebApplication1)
- [コチラ](https://github.com/daisukenishino2/EvaluateAspNetCoreOnDocker/tree/master/WebApplication1)をVS2019 & .NET Core3.0にアップグレードし、
- [コチラ](https://techinfoofmicrosofttech.osscons.jp/index.php?Azure%20Kubernetes%20Service%20%28AKS%29#eca47597)のチュートリアルに合わせて変更を加えたもの。
- 参考
  - OSSコンソーシアム  
Docker for Windows上で Docker Composeでテストし、Open PaaSにデプロイできる
    - [その１](https://www.osscons.jp/joweexgq6-537/)
    - [その２](https://www.osscons.jp/jo6610sfd-537/)

## [WebApplication2](https://github.com/daisukenishino2/EvaluateAspNetCoreOnK8s/tree/master/WebApplication2)
-[/EvaluateAspNetCoreOnK8s/.../WebApplication1](https://github.com/daisukenishino2/EvaluateAspNetCoreOnK8s/tree/master/WebApplication1)をベースにして、
-以下の２つのdocker-compose.ymlの良い所取りをした。
--[/EvaluateAspNetCoreOnDocker/.../WebApplication1](https://github.com/daisukenishino2/EvaluateAspNetCoreOnDocker/tree/master/WebApplication1)
--[/EvaluateAspNetCoreOnDocker/.../LocalServices](https://github.com/daisukenishino2/EvaluateAspNetCoreOnDocker/tree/master/LocalServices)

## [MVC_Sample](https://github.com/daisukenishino2/EvaluateAspNetCoreOnK8s/tree/master/MVC_Sample)
-[/EvaluateAspNetCoreOnDocker/.../MVC_Sample](https://github.com/daisukenishino2/EvaluateAspNetCoreOnDocker/tree/master/MVC_Sample)をベースにして、
-[WebApplication2](https://github.com/daisukenishino2/EvaluateAspNetCoreOnK8s/tree/master/WebApplication2)のdocker-compose.ymlの良い所取りをした。
