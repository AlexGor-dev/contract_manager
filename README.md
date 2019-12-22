# contract_manager
Manager contracts for ton blockchain.

//*********************************************************

Файлы fift, func, lite-client - собраны на Ubuntu 18.04.3.
Необходимо установить Mono - "deb-packages.sh".
Программа запускается командой - "mono Messenger.exe" из папки bin\.
Видео по запуску "Contract Manager.mp4".

//*********************************************************

Менеджер контрактов.
На ПК храниться информация только о менеджере смарт-контрактов.
Информация о созданных в нём контрактах - хранится в смарт-контракте (Manager) в ton blockchain .
Храниться приватный ключ и адрес контракта.
Приватный ключ шифруется и дешифруется приватным ключом менеджера.
В менеджере можно:
- Создавать дочерние смарт-контракты разных типов. (на данный момент реализован один тип - "Messenger")
- Отправлять граммы дочерним контрактам.
- Изменять имя менеджера и дочерних контрактов.
- Отправлять запрос на изменение кода.
- Удалять дочерние контракты.

//*********************************************************

Contract manager.

//*********************************************************

Files fift, func, lite-client - compiled on Ubuntu 18.04.3.
You must install Mono - "deb-packages.sh".
The program is launched by the command - "mono Messenger.exe" from the bin \ folder.
Video on launching "Contract Manager.mp4".

//*********************************************************

Only information about the smart contract manager is stored on the PC.
Information about the contracts created in it is stored in the smart contract (Manager) in the ton blockchain.
The private key and address of the contract are stored.
The private key is encrypted and decrypted by the manager’s private key.
In the manager you can:
- Create subsidiary smart contracts of various types. (currently implemented one type - "Messenger")
- Send grams to child contracts.
- Change the name of the manager and child smart contracts.
- Send a request to change the code.
- Delete subsidiary contracts.


