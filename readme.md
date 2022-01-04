docker run -d --restart unless-stopped --name seq -e ACCEPT_EULA=Y -v D:\DEV\SerilogDemoApp\Logs:/data -p 8081:80 datalust/seq:latest
