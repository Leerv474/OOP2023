Текстовая инструкция по настройке Wireguard к [видео](https://www.youtube.com/watch?v=5Aql0V-ta8A).  
Обновляем сервер:  

``` powershell
apt update && apt upgrade -y
```
  
Ставим wireguard:  
```powershell
apt install -y wireguard
```
  
Генерим ключи сервера:  
``` powershell
wg genkey | tee /etc/wireguard/privatekey | wg pubkey | tee /etc/wireguard/publickey
```
  
Проставляем права на приватный ключ:  
```powershell
chmod 600 /etc/wireguard/privatekey
```
Проверим, как у вас называется сетевой интерфейс:  
```powershell
ip a
```
  
Скорее всего у вас сетевой интерфейс `eth0`, но возможно и другой, например, `ens3` или как-то иначе. Это название интерфейса используется далее в конфиге `/etc/wireguard/wg0.conf`, который мы сейчас создадим:  
```powershell
vim /etc/wireguard/wg0.conf
```


```markup
[Interface]  
PrivateKey = <privatekey>  
Address = 10.0.0.1/24  
ListenPort = 51830  
PostUp = iptables -A FORWARD -i %i -j ACCEPT; iptables -t nat -A POSTROUTING -o eth0 -j MASQUERADE  
PostDown = iptables -D FORWARD -i %i -j ACCEPT; iptables -t nat -D POSTROUTING -o eth0 -j MASQUERADE
``` 
Если не знаете текстовый редактор `vim` — откройте файл с `nano`, он проще в работе.    
Обратите внимание — в строках `PostUp` и `PostDown` использован как раз сетевой интерфейс `eth0`. Если у вас другой — замените `eth0` на ваш.  
  
Вставляем вместо `<privatekey>` содержимое файла `/etc/wireguard/privatekey`  
  
Настраиваем IP форвардинг:  
```powershell
echo "net.ipv4.ip_forward=1" >> /etc/sysctl.conf  
sysctl -p
```
Включаем systemd демон с wireguard:  
```powershell
systemctl enable wg-quick@wg0.service  
systemctl start wg-quick@wg0.service  
systemctl status wg-quick@wg0.service
```

Создаём ключи клиента:  
```powershell
wg genkey | tee /etc/wireguard/keyname_privatekey | wg pubkey | tee /etc/wireguard/keyname_publickey
```
  
Добавляем в конфиг сервера клиента:  
```powershell
vim /etc/wireguard/wg0.conf
```

```markup
[Peer]  
PublicKey = <keyname_publickey>  
AllowedIPs = 10.0.0.2/32
```
  
  
Вместо `<keyname_publickey>` — заменяем на содержимое файла `/etc/wireguard/keyname_publickey`  
  
Перезагружаем systemd сервис с wireguard:  
```powershell
systemctl restart wg-quick@wg0  
systemctl status wg-quick@wg0
```
  
  
На локальной машине (например, на ноутбуке) создаём текстовый файл с конфигом клиента:  
``` powershell
vim keyname_wb.conf
```
  
  
```markup
[Interface]  
PrivateKey = <CLIENT-PRIVATE-KEY>  
Address = 10.0.0.2/32  
DNS = 8.8.8.8  
  
[Peer]  
PublicKey = <SERVER-PUBKEY>  
Endpoint = <SERVER-IP>:51830  
AllowedIPs = 0.0.0.0/0  
PersistentKeepalive = 20
```

Здесь `<CLIENT-PRIVATE-KEY>` заменяем на приватный ключ клиента, то есть содержимое файла `/etc/wireguard/goloburdin_privatekey` на сервере. `<SERVER-PUBKEY>` заменяем на публичный ключ сервера, то есть на содержимое файла `/etc/wireguard/publickey` на сервере. `<SERVER-IP>` заменяем на IP сервера.  
  
Этот файл открываем в Wireguard клиенте (есть для всех операционных систем, в том числе мобильных) — и жмем в клиенте кнопку подключения.