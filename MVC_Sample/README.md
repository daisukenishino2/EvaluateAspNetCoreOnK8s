このフォルダのコンテンツを実行するには、

当該リポジトリをクローンした後、
```
git clone https://github.com/daisukenishino2/EvaluateAspNetCoreOnDocker.git
```

0_ExecAllBat.bat をダブルクリックして、  
実行し、ライブラリ類をNuGetから取得＆ビルド。

次いで、このフォルダの MVC_Sample.sln を Visual Studio で開き、  
以下の手順で、Visual Studio Tools for Docker を使用して起動する。

- https://techinfoofmicrosofttech.osscons.jp/index.php?Visual%20Studio%20Tools%20for%20Docker#e09b7e2d

起動後は、以下のURLからWeb Server経由でのみアクセス可能。  

- http://localhost:8888/

このプロジェクトは、起動するコンテナが多いせいか、少々不安定です。
