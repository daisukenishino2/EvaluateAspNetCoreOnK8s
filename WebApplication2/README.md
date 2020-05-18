このフォルダのコンテンツを実行するには、

当該リポジトリをクローンした後、
```
git clone https://github.com/daisukenishino2/EvaluateAspNetCoreOnK8s.git
```

このフォルダの WebApplication2.sln を Visual Studio で開き、  
以下の手順で、Visual Studio Tools for Docker を使用して起動する。

- https://techinfoofmicrosofttech.osscons.jp/index.php?Visual%20Studio%20Tools%20for%20Docker#e09b7e2d

起動後は、以下のURLからアクセス可能。  
前者は、AP Server直、後者は、Web Server経由。

- http://localhost:5000/
- http://localhost:8888/
